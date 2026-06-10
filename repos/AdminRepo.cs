using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;
using RusdiBakery.Models;

namespace RusdiBakery.repos
{
    public static class AdminRepo
    {
        /// <summary>
        /// Authenticates an admin by email and password.
        /// Returns the Admin object if credentials match, or null if not found.
        /// </summary>
        public static Admin? Login(string email, string password)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string query = "SELECT id_admin, username, email, password FROM admin WHERE email = @email";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string storedHash = reader.GetString("password");
                if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                {
                    return new Admin
                    {
                        IdAdmin = reader.GetInt32("id_admin"),
                        Username = reader.GetString("username"),
                        Email = reader.GetString("email"),
                        Password = storedHash
                    };
                }
            }

            return null;
        }

        /// <summary>
        /// Registers a new admin. Returns true if the insert succeeds.
        /// </summary>
        public static bool Register(Admin admin)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(admin.Password);

            string query = "INSERT INTO admin (username, email, password) VALUES (@username, @email, @password)";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", admin.Username);
            cmd.Parameters.AddWithValue("@email", admin.Email);
            cmd.Parameters.AddWithValue("@password", hashedPassword);

            int rows = cmd.ExecuteNonQuery();
            return rows > 0;
        }

        /// <summary>
        /// Checks whether an email is already registered in the admin table.
        /// </summary>
        public static bool IsEmailExists(string email)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string query = "SELECT COUNT(*) FROM admin WHERE email = @email";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);

            long count = Convert.ToInt64(cmd.ExecuteScalar());
            return count > 0;
        }

        /// <summary>
        /// Retrieves an admin by email.
        /// </summary>
        public static Admin? GetByEmail(string email)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string query = "SELECT id_admin, username, email, password FROM admin WHERE email = @email";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Admin
                {
                    IdAdmin = reader.GetInt32("id_admin"),
                    Username = reader.GetString("username"),
                    Email = reader.GetString("email"),
                    Password = reader.GetString("password")
                };
            }

            return null;
        }

        /// <summary>
        /// Updates the password for an admin.
        /// </summary>
        public static bool UpdatePassword(int idAdmin, string newPassword)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);
            return UpdatePasswordHash(idAdmin, hashedPassword);
        }

        /// <summary>
        /// Restores or sets an already-hashed admin password.
        /// </summary>
        public static bool UpdatePasswordHash(int idAdmin, string hashedPassword)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string query = "UPDATE admin SET password = @password WHERE id_admin = @id_admin";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@password", hashedPassword);
            cmd.Parameters.AddWithValue("@id_admin", idAdmin);

            int rows = cmd.ExecuteNonQuery();
            return rows > 0;
        }
    }
}
