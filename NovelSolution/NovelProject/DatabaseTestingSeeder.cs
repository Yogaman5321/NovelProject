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
            SeedNovelTags();
            SeedReviews();
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
                ("The Lost Kingdom", "Arthur King", "A quest to reclaim a forgotten throne.", 1),
                ("Haunted Manor", "Sarah Night", "A chilling story of a haunted house.", 1),
                ("Galactic Frontier", "Rick Star", "Exploring the unknown edges of the galaxy.", 1),
                ("Author Test Novel", "hunter", "This is to test the author view functionality.", 1),
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
                ("Adventure", "Novels with exciting journeys or quests."),
                ("Drama", "Novels with intense character development and interaction."),
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

        private static void SeedNovelTags()
        {
            string checkQuery = "SELECT COUNT(*) FROM NovelTags";
            int novelTagCount = DatabaseHelper.ExecuteScalar<int>(checkQuery);

            if (novelTagCount > 0) 
            {
                Debug.WriteLine("Database already seeded with novel tags. Skipping seeding.");
                return;
            }

            string insertNovelTagQuery = @"INSERT INTO NovelTags (NovelId, TagId) VALUES (@NovelId, @TagId)";

            var novelTags = new List<(int NovelId, int TagId)>
            {
                (1, 1), // The Enchanted Forest - Fantasy
                (1, 4), // The Enchanted Forest - Mystery
                (1, 6), // The Enchanted Forest - Adventure
                (2, 2), // Space Odyssey - Science Fiction
                (2, 5), // Space Odyssey - Horror
                (2, 6), // Space Odyssey - Adventure
                (3, 3), // Love in Paris - Romance
                (3, 7), // Love in Paris - Drama
                (4, 1), // The Lost Kingdom - Fantasy
                (4, 6), // The Lost Kingdom - Adventure
                (5, 5), // Haunted Manor - Horror
                (5, 4), // Haunted Manor - Mystery
                (6, 2), // Galactic Frontier - Science Fiction
                (6, 6), // Galactic Frontier - Adventure
                (7, 6), // Author Test Novel - Adventure
            };

            foreach (var novelTag in novelTags)
            {
                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@NovelId", novelTag.NovelId),
                    new SqlParameter("@TagId", novelTag.TagId),
                };
                int rowsAffected = DatabaseHelper.ExecuteNonQuery(insertNovelTagQuery, parameters);
                if (rowsAffected > 0)
                {
                    Debug.WriteLine($"Inserted novel tag (NovelId: {novelTag.NovelId}, TagId: {novelTag.TagId}) successfully.");
                }
                else
                {
                    Debug.WriteLine($"Failed to insert novel tag (NovelId: {novelTag.NovelId}, TagId: {novelTag.TagId}).");
                }
            }
        }

        private static void SeedReviews()
        {
            string checkQuery = "SELECT COUNT(*) FROM Reviews";
            int reviewCount = DatabaseHelper.ExecuteScalar<int>(checkQuery);
            if (reviewCount > 0)
            {
                Debug.WriteLine("Database already seeded with reviews. Skipping seeding.");
                return;
            }

            string insertReviewQuery = @"INSERT INTO Reviews (UserId, NovelId, ReviewContent, Rating) VALUES (@UserId, @NovelId, @ReviewContent, @Rating)";

            var reviews = new List<(int UserId, int NovelId, string ReviewContent, decimal Rating)>
            {
                (1, 1, "Absolutely loved the magical world!", 9.50m),
                (1, 2, "A mind-bending journey through the stars.", 8.75m),
                (1, 3, "A sweet and touching romance.", 8.20m),
                (1, 4, "Epic adventure with great characters.", 9.00m),
                (1, 5, "Spooky and suspenseful!", 7.80m),
                (1, 6, "Fascinating look at the galaxy's edge.", 8.90m),
            };

            foreach (var review in reviews)
            {
                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@UserId", review.UserId),
                    new SqlParameter("@NovelId", review.NovelId),
                    new SqlParameter("@ReviewContent", review.ReviewContent),
                    new SqlParameter("@Rating", review.Rating),
                };
                int rowsAffected = DatabaseHelper.ExecuteNonQuery(insertReviewQuery, parameters);
                if (rowsAffected > 0)
                {
                    Debug.WriteLine($"Inserted review for NovelId: {review.NovelId} successfully.");
                }
                else
                {
                    Debug.WriteLine($"Failed to insert review for NovelId: {review.NovelId}.");
                }
            }
        }

        private static void SeedComments()
        {
        }

        //private void SeedReadHistories() don't know if we need this?
    }
}
