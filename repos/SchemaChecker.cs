using System;
using MySqlConnector;
using RusdiBakery.Models;

namespace RusdiBakery.repos
{
    public static class SchemaChecker
    {
        public static string GetTransactionSchema()
        {
            try
            {
                using var conn = Database.GetConnection();
                conn.Open();
                using var cmd = new MySqlCommand("DESCRIBE transaction", conn);
                using var reader = cmd.ExecuteReader();
                string schema = "Transaction Columns:\n";
                while (reader.Read())
                {
                    schema += $"{reader["Field"]} - {reader["Type"]}\n";
                }
                return schema;
            }
            catch (Exception ex)
            {
                return "Error reading schema: " + ex.Message;
            }
        }

        public static string GetStockSchema()
        {
            try
            {
                using var conn = Database.GetConnection();
                conn.Open();
                using var cmd = new MySqlCommand("DESCRIBE stock", conn);
                using var reader = cmd.ExecuteReader();
                string schema = "Stock Columns:\n";
                while (reader.Read())
                {
                    schema += $"{reader["Field"]} - {reader["Type"]}\n";
                }
                return schema;
            }
            catch (Exception ex)
            {
                return "Error reading schema: " + ex.Message;
            }
        }
    }
}
