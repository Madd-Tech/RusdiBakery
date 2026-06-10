using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;
using RusdiBakery.Models;

namespace RusdiBakery.repos
{
    public static class CustomerRepo
    {
        /// <summary>
        /// Authenticates a customer by email and password.
        /// Returns the Customer object if credentials match, or null if not found.
        /// </summary>
        public static Customer? Login(string email, string password)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string query = "SELECT id_customer, username, email, password FROM customer WHERE email = @email";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string storedHash = reader.GetString("password");
                if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                {
                    return new Customer
                    {
                        IdCustomer = reader.GetInt32("id_customer"),
                        Username = reader.GetString("username"),
                        Email = reader.GetString("email"),
                        Password = storedHash
                    };
                }
            }

            return null;
        }

        /// <summary>
        /// Registers a new customer. Returns true if the insert succeeds.
        /// </summary>
        public static bool Register(Customer customer)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(customer.Password);

            string query = "INSERT INTO customer (username, email, password) VALUES (@username, @email, @password)";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", customer.Username);
            cmd.Parameters.AddWithValue("@email", customer.Email);
            cmd.Parameters.AddWithValue("@password", hashedPassword);

            int rows = cmd.ExecuteNonQuery();
            return rows > 0;
        }

        /// <summary>
        /// Checks whether an email is already registered in the customer table.
        /// </summary>
        public static bool IsEmailExists(string email)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string query = "SELECT COUNT(*) FROM customer WHERE email = @email";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);

            long count = Convert.ToInt64(cmd.ExecuteScalar());
            return count > 0;
        }
    }
}
