    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;

namespace NovelProject
{
    public static class DatabaseHelper
    {
        private static readonly string ConnectionString = "Server=(localdb)\\mssqllocaldb;Database=NovelProjectDB;Trusted_Connection=True;";

        private static readonly string MasterConnectionString = "Server=(localdb)\\mssqllocaldb;Database=master;Trusted_Connection=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public static void ExecuteSqlScript(string script)
        {
            // Use regex to split by GO with optional whitespace before/after
            string[] batches = Regex.Split(script, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);

            if (batches.Length > 0)
            {
                using (var connection = new SqlConnection(MasterConnectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand(batches[0].Trim(), connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

                using (var connection = GetConnection())
                {
                    connection.Open();
                    for(int i = 1; i < batches.Length; i++)
                    {
                        string batch = batches[i].Trim();
                        if (string.IsNullOrWhiteSpace(batch))
                            continue;

                        if (batch.StartsWith("USE ", StringComparison.OrdinalIgnoreCase))
                            continue;

                        using(var command = new SqlCommand(batch, connection))
                        {
                            command.CommandTimeout = 60; // Set timeout to 60 seconds for potentially long-running scripts
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }

        }
        

        public static T ExecuteScalar<T>(string query, params SqlParameter[] parameters)
        {
            using (var connection = GetConnection())
            {
                using (var command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    connection.Open();
                    var result = command.ExecuteScalar();
                    return result == null || result == DBNull.Value ? default(T) : (T)result;
                }
            }
                
        }


        public static int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            using (var connection = GetConnection())
            {
                using (var command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

        public static SqlDataReader ExecuteReader(string query, params SqlParameter[] parameters)
        {
            var connection = GetConnection();
            var command = new SqlCommand(query, connection);
            if (parameters != null)
                command.Parameters.AddRange(parameters);
            connection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
