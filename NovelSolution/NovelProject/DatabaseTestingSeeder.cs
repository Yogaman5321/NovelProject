using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.Data.SqlClient;

namespace NovelProject
{
    public static class DatabaseTestingSeeder
    {
        public static void SeedDatabase()
        {
            // Check if database is already seeded
            string checkQuery = "SELECT COUNT(*) FROM Users";
            int userCount = DatabaseHelper.ExecuteScalar<int>(checkQuery);

            if (userCount > 0)
            {
                Debug.WriteLine("Database already seeded. Skipping seeding.");
                return;
            }

            // Seed test user
            string insertUserQuery = @"INSERT INTO Users (Username, EncryptedPassword) 
                                      VALUES (@Username, @EncryptedPassword)";
            
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", "Hunter"),
                new SqlParameter("@EncryptedPassword", BCrypt.Net.BCrypt.HashPassword("password123")),
            };

            int rowsAffected = DatabaseHelper.ExecuteNonQuery(insertUserQuery, parameters);

            if (rowsAffected > 0)
            {
                Debug.WriteLine("Database seeded successfully with test user 'Hunter'.");
            }
            else
            {
                Debug.WriteLine("Failed to seed database.");
            }
        }
    }
}
