using System;
using System.Collections.Generic;
using MySqlConnector;
using RusdiBakery.Models;

namespace RusdiBakery.repos
{
    public static class ProductRepo
    {
        /// <summary>
        /// Fetches all products, sorted based on selection.
        /// </summary>
        public static List<Product> GetAll(string sortBy = "A - Z")
        {
            var list = new List<Product>();
            using var conn = Database.GetConnection();
            conn.Open();

            string query = sortBy switch
            {
                "Z - A" => "SELECT id_product, product_name, price FROM product ORDER BY product_name DESC",
                "Most Ordered" => "SELECT p.id_product, p.product_name, p.price FROM product p LEFT JOIN transaction t ON p.id_product = t.id_product GROUP BY p.id_product, p.product_name, p.price ORDER BY SUM(COALESCE(t.qty, 0)) DESC",
                _ => "SELECT id_product, product_name, price FROM product ORDER BY product_name ASC"
            };

            using var cmd = new MySqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Product
                {
                    IdProduct = reader.GetInt32("id_product"),
                    ProductName = reader.GetString("product_name"),
                    Price = reader.GetDouble("price")
                });
            }
            return list;
        }

        /// <summary>
        /// Fetches a single product by ID.
        /// </summary>
        public static Product? GetById(int id)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string query = "SELECT id_product, product_name, price FROM product WHERE id_product = @id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Product
                {
                    IdProduct = reader.GetInt32("id_product"),
                    ProductName = reader.GetString("product_name"),
                    Price = reader.GetDouble("price")
                };
            }
            return null;
        }

        /// <summary>
        /// Adds a new product to the database. Returns true if successful.
        /// </summary>
        public static bool Create(Product product)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string query = "INSERT INTO product (product_name, price) VALUES (@name, @price)";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", product.ProductName);
            cmd.Parameters.AddWithValue("@price", product.Price);

            return cmd.ExecuteNonQuery() > 0;
        }

        /// <summary>
        /// Updates an existing product. Returns true if successful.
        /// </summary>
        public static bool Update(Product product)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string query = "UPDATE product SET product_name = @name, price = @price WHERE id_product = @id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", product.IdProduct);
            cmd.Parameters.AddWithValue("@name", product.ProductName);
            cmd.Parameters.AddWithValue("@price", product.Price);

            return cmd.ExecuteNonQuery() > 0;
        }

        /// <summary>
        /// Deletes a product from the database. Returns true if successful.
        /// </summary>
        public static bool Delete(int id)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string query = "DELETE FROM product WHERE id_product = @id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);

            return cmd.ExecuteNonQuery() > 0;
        }

        /// <summary>
        /// Fetches all products that do not have a stock record yet.
        /// </summary>
        public static List<Product> GetProductsWithoutStock()
        {
            var list = new List<Product>();
            using var conn = Database.GetConnection();
            conn.Open();

            string query = "SELECT id_product, product_name, price FROM product WHERE id_product NOT IN (SELECT id_product FROM stock) ORDER BY product_name ASC";
            using var cmd = new MySqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Product
                {
                    IdProduct = reader.GetInt32("id_product"),
                    ProductName = reader.GetString("product_name"),
                    Price = reader.GetDouble("price")
                });
            }
            return list;
        }
    }
}
