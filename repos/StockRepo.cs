using System;
using System.Collections.Generic;
using MySqlConnector;
using RusdiBakery.Models;

namespace RusdiBakery.repos
{
    public static class StockRepo
    {
        /// <summary>
        /// Returns the actual stock column name in the DB ('stock' or 'stock_qty').
        /// </summary>
        private static string GetStockColumnName(MySqlConnection conn)
        {
            foreach (var columnName in new[] { "stock", "stock_qty" })
            {
                using var cmd = new MySqlCommand("SHOW COLUMNS FROM stock LIKE @columnName", conn);
                cmd.Parameters.AddWithValue("@columnName", columnName);

                using var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    return columnName;
                }
            }

            throw new Exception("Kolom stok tidak ditemukan. Tabel stock harus memiliki kolom 'stock' atau 'stock_qty'.");
        }

        public static List<Stock> GetAll()
        {
            var list = new List<Stock>();
            using var conn = Database.GetConnection();
            conn.Open();

            string col = GetStockColumnName(conn);

            string query = $@"
                SELECT s.id_stock, s.id_product, s.{col} AS qty_val,
                       p.product_name, p.price
                FROM stock s
                INNER JOIN product p ON s.id_product = p.id_product
                ORDER BY p.product_name ASC";

            using var cmd = new MySqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var stock = new Stock
                {
                    IdStock = reader.GetInt32("id_stock"),
                    IdProduct = reader.IsDBNull(reader.GetOrdinal("id_product")) ? null : reader.GetInt32("id_product"),
                    StockQty = reader.IsDBNull(reader.GetOrdinal("qty_val")) ? null : reader.GetInt32("qty_val"),
                    Product = new Product
                    {
                        IdProduct = reader.GetInt32("id_product"),
                        ProductName = reader.GetString("product_name"),
                        Price = reader.GetDouble("price")
                    }
                };
                list.Add(stock);
            }
            return list;
        }

        public static bool Create(Stock stock)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            string col = GetStockColumnName(conn);

            string query = $"INSERT INTO stock (id_product, {col}) VALUES (@idProduct, @qty)";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idProduct", stock.IdProduct);
            cmd.Parameters.AddWithValue("@qty", stock.StockQty);

            return cmd.ExecuteNonQuery() > 0;
        }

        public static bool Update(Stock stock)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            string col = GetStockColumnName(conn);

            string query = $"UPDATE stock SET {col} = @qty WHERE id_stock = @id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", stock.IdStock);
            cmd.Parameters.AddWithValue("@qty", stock.StockQty);

            return cmd.ExecuteNonQuery() > 0;
        }

        public static bool Delete(int idStock)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string query = "DELETE FROM stock WHERE id_stock = @id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", idStock);

            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
