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
            SeedUsers();
            SeedNovels();
            SeedTags();
        }

        private static void SeedUsers()
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

        private static void SeedNovels()
        {
            string checkQuery = "SELECT COUNT(*) FROM Novels";
            int novelCount = DatabaseHelper.ExecuteScalar<int>(checkQuery);
            if (novelCount > 0) 
            {
                Debug.WriteLine("Database already seeded with novels. Skipping seeding.");
                return;
            }

            string insertNovelQuery = @"INSERT INTO Novels (NovelName, AuthorName, Description, UploadedByUserId) 
                                        VALUES (@NovelName, @AuthorName, @Description, @UploadedByUserId)";

            var novels = new List<(string NovelName, string AuthorName, string Description, int UploadedByUserId)>
            {
                ("The Enchanted Forest", "Jane Doe", "A magical adventure in a mysterious forest.", 1),
                ("Space Odyssey", "John Smith", "A thrilling journey through space and time.", 1),
                ("Love in Paris", "Emily Johnson", "A romantic tale set in the city of love.", 1),
            };

            foreach (var novel in novels)
            {
                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@NovelName", novel.NovelName),
                    new SqlParameter("@AuthorName", novel.AuthorName),
                    new SqlParameter("@Description", novel.Description),
                    new SqlParameter("@UploadedByUserId", novel.UploadedByUserId),
                };
                int rowsAffected = DatabaseHelper.ExecuteNonQuery(insertNovelQuery, parameters);
                if (rowsAffected > 0)
                {
                    Debug.WriteLine($"Inserted novel '{novel.NovelName}' successfully.");
                }
                else
                {
                    Debug.WriteLine($"Failed to insert novel '{novel.NovelName}'.");
                }
            }
        }

        private static void SeedChapters()
        {
        }

        private static void SeedTags()
        {
            string checkQuery = "SELECT COUNT(*) FROM Tags";
            int tagCount = DatabaseHelper.ExecuteScalar<int>(checkQuery);

            if (tagCount > 0) 
            {
                Debug.WriteLine("Database already seeded with tags. Skipping seeding.");
                return;
            }

            string insertTagQuery = @"INSERT INTO Tags (TagName, TagDescription) VALUES (@Name, @Description)";

            var tags = new List<(string Name, string Description)>
            {
                ("Fantasy", "Novels that contain magical or supernatural elements."),
                ("Science Fiction", "Novels that explore futuristic concepts and advanced technology."),
                ("Romance", "Novels that focus on romantic relationships."),
                ("Mystery", "Novels that involve solving a crime or uncovering secrets."),
                ("Horror", "Novels that aim to evoke fear and suspense."),
            };

            foreach (var tag in tags)
            {
                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@Name", tag.Name),
                    new SqlParameter("@Description", tag.Description),
                };
                int rowsAffected = DatabaseHelper.ExecuteNonQuery(insertTagQuery, parameters);
                if (rowsAffected > 0)
                {
                    Debug.WriteLine($"Inserted tag '{tag.Name}' successfully.");
                }
                else
                {
                    Debug.WriteLine($"Failed to insert tag '{tag.Name}'.");
                }
            }
        }

        private static void SeedReviews()
        {
        }

        private static void SeedComments()
        {
        }

        //private void SeedReadHistories() don't know if we need this?
    }
}
