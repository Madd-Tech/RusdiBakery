using System;
using System.Collections.Generic;
using MySqlConnector;
using RusdiBakery.Models;

namespace RusdiBakery.repos
{
    public static class TransactionRepo
    {
        /// <summary>
        /// Returns the actual stock column name in the DB ('stock' or 'stock_qty').
        /// </summary>
        private static string GetStockColumnName(MySqlConnection conn, MySqlTransaction? tr = null)
        {
            foreach (var columnName in new[] { "stock", "stock_qty" })
            {
                using var cmd = new MySqlCommand("SHOW COLUMNS FROM stock LIKE @columnName", conn, tr);
                cmd.Parameters.AddWithValue("@columnName", columnName);

                using var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    return columnName;
                }
            }

            throw new Exception("Kolom stok tidak ditemukan. Tabel stock harus memiliki kolom 'stock' atau 'stock_qty'.");
        }

        public static (bool success, string message) Create(Transaction transaction)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            // Detect stock column name before starting transaction
            string stockCol = GetStockColumnName(conn);

            using var tr = conn.BeginTransaction();
            try
            {
                if (string.IsNullOrEmpty(transaction.TransactionCode))
                {
                    transaction.TransactionCode = "TRX-" + DateTime.Now.ToString("yyyyMMddHHmmss") + new Random().Next(100, 999);
                }

                // 1. Check stock availability
                string checkStockQuery = $"SELECT {stockCol} FROM stock WHERE id_product = @idProduct FOR UPDATE";
                int currentStock = 0;
                using (var cmdCheckStock = new MySqlCommand(checkStockQuery, conn, tr))
                {
                    cmdCheckStock.Parameters.AddWithValue("@idProduct", transaction.IdProduct);
                    var result = cmdCheckStock.ExecuteScalar();
                    if (result == null || result == DBNull.Value)
                    {
                        throw new Exception($"Produk ID {transaction.IdProduct} belum memiliki data stok. Tambahkan stok terlebih dahulu di menu Admin > Stock.");
                    }
                    currentStock = Convert.ToInt32(result);
                }

                if (currentStock < transaction.Qty)
                {
                    throw new Exception($"Stok tidak mencukupi. Tersedia: {currentStock}, Diminta: {transaction.Qty}");
                }

                // 2. Insert transaction
                string queryTrans = @"
                    INSERT INTO transaction (id_product, id_customer, qty, total)
                    VALUES (@idProduct, @idCustomer, @qty, @total)";

                using var cmdTrans = new MySqlCommand(queryTrans, conn, tr);
                cmdTrans.Parameters.AddWithValue("@idProduct", transaction.IdProduct);
                cmdTrans.Parameters.AddWithValue("@idCustomer", (object?)transaction.IdCustomer ?? DBNull.Value);
                cmdTrans.Parameters.AddWithValue("@qty", transaction.Qty);
                cmdTrans.Parameters.AddWithValue("@total", transaction.Total);
                cmdTrans.ExecuteNonQuery();

                // 3. Deduct stock
                string queryStock = $"UPDATE stock SET {stockCol} = {stockCol} - @qty WHERE id_product = @idProduct";
                using var cmdStock = new MySqlCommand(queryStock, conn, tr);
                cmdStock.Parameters.AddWithValue("@qty", transaction.Qty);
                cmdStock.Parameters.AddWithValue("@idProduct", transaction.IdProduct);
                cmdStock.ExecuteNonQuery();

                tr.Commit();
                return (true, "Success");
            }
            catch (Exception ex)
            {
                tr.Rollback();
                return (false, ex.Message);
            }
        }

        public static List<Transaction> GetAll()
        {
            var list = new List<Transaction>();
            using var conn = Database.GetConnection();
            conn.Open();

            string query = @"
                SELECT t.id_transaction, t.id_product, t.id_customer, t.qty, t.total,
                       p.product_name, p.price,
                       c.username AS customer_name
                FROM transaction t
                LEFT JOIN product p ON t.id_product = p.id_product
                LEFT JOIN customer c ON t.id_customer = c.id_customer
                ORDER BY t.id_transaction DESC";

            using var cmd = new MySqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var trans = new Transaction
                {
                    IdTransaction = reader.GetInt32("id_transaction"),
                    IdProduct = reader.IsDBNull(reader.GetOrdinal("id_product")) ? null : reader.GetInt32("id_product"),
                    IdCustomer = reader.IsDBNull(reader.GetOrdinal("id_customer")) ? null : reader.GetInt32("id_customer"),
                    Qty = reader.IsDBNull(reader.GetOrdinal("qty")) ? null : reader.GetInt32("qty"),
                    Total = reader.IsDBNull(reader.GetOrdinal("total")) ? null : reader.GetDouble("total"),
                    Product = new Product
                    {
                        ProductName = reader.IsDBNull(reader.GetOrdinal("product_name")) ? "Unknown" : reader.GetString("product_name"),
                        Price = reader.IsDBNull(reader.GetOrdinal("price")) ? 0 : reader.GetDouble("price")
                    },
                    Customer = new Customer
                    {
                        Username = reader.IsDBNull(reader.GetOrdinal("customer_name")) ? "Guest" : reader.GetString("customer_name")
                    }
                };
                list.Add(trans);
            }
            return list;
        }

        public static double GetTotalRevenue()
        {
            using var conn = Database.GetConnection();
            conn.Open();
            string query = "SELECT SUM(total) FROM transaction";
            using var cmd = new MySqlCommand(query, conn);
            var result = cmd.ExecuteScalar();
            return result != null && result != DBNull.Value ? Convert.ToDouble(result) : 0;
        }
    }
}
