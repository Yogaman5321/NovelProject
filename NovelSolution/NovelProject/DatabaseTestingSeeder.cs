using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovelProject.Models;
using System.Diagnostics;

namespace NovelProject
{
    public static class DatabaseTestingSeeder
    {
        public static void SeedDatabase(ProjectDatabaseContext context)
        {
            if (context.Users.Any())
            {
                Debug.WriteLine("Database already seeded. Skipping seeding.");
                return;
            }

            var users = new[]
            {
                new UserAccount
                {
                    Username = "Hunter",
                    EncryptedPassword = BCrypt.Net.BCrypt.HashPassword("password123"),
                    AccountCreatedDate = DateTime.Now
                }
            };

            context.Users.AddRange(users);
            context.SaveChanges();
            Debug.WriteLine("Database seeded successfully.");
        }
    }
}
