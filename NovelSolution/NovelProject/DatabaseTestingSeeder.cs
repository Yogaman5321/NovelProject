using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
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
            SeedChapters();
            SeedComments();
            SeedReadHistories();
        }

        private static void SeedUsers()
        {
            string checkQuery = "SELECT COUNT(*) FROM Users";
            int userCount = DatabaseHelper.ExecuteScalar<int>(checkQuery);

            if (userCount > 0)
            {
                Debug.WriteLine("Database already seeded. Skipping seeding.");
                return;
            }

            string csvPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SeedingFiles", "UserSeed.csv");

            if (!File.Exists(csvPath))
            {
                Debug.WriteLine($"UserSeed.csv not found at '{csvPath}'. Skipping user seeding.");
                return;
            }

            string insertUserQuery = @"INSERT INTO Users (Username, EncryptedPassword, AccountCreatedDate) 
                                      VALUES (@Username, @EncryptedPassword, @AccountCreatedDate)";

            string[] lines = File.ReadAllLines(csvPath);

            // Skip the header row
            foreach (string line in lines.Skip(1))
            {
                string[] parts = ParseCsvLine(line);

                if (parts.Length < 2)
                {
                    Debug.WriteLine($"Skipping malformed CSV line: '{line}'");
                    continue;
                }

                string username = parts[0].Trim();
                string password = parts[1].Trim();
                string createdDateStr = parts.Length > 2 ? parts[2].Trim() : null;
                DateTime? createdDate = null;
                if (!string.IsNullOrEmpty(createdDateStr) && DateTime.TryParse(createdDateStr, out DateTime parsedDate))
                {
                    createdDate = parsedDate;
                }

                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@Username", username),
                    new SqlParameter("@EncryptedPassword", BCrypt.Net.BCrypt.HashPassword(password)),
                    new SqlParameter("@AccountCreatedDate", (object)createdDate ?? DBNull.Value),
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(insertUserQuery, parameters);

                if (rowsAffected > 0)
                    Debug.WriteLine($"Seeded user '{username}' successfully.");
                else
                    Debug.WriteLine($"Failed to seed user '{username}'.");
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

            string csvPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SeedingFiles", "NovelSeed.csv");

            if (!File.Exists(csvPath))
            {
                Debug.WriteLine($"NovelSeed.csv not found at '{csvPath}'. Skipping novel seeding.");
                return;
            }

            string insertNovelQuery = @"INSERT INTO Novels (UploadedByUserId, AuthorName, NovelName, Description, DatePosted) 
                                        VALUES (@UploadedByUserId, @AuthorName, @NovelName, @Description, @DatePosted)";

            string[] lines = File.ReadAllLines(csvPath);

            foreach (string line in lines.Skip(1))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] parts = ParseCsvLine(line);

                if (parts.Length < 4)
                {
                    Debug.WriteLine($"Skipping malformed CSV line: '{line}'");
                    continue;
                }

                if (!int.TryParse(parts[0].Trim(), out int uploadedByUserId))
                {
                    Debug.WriteLine($"Skipping line with invalid UploadedByUserId: '{line}'");
                    continue;
                }

                string authorName = parts[1].Trim();
                string novelName = parts[2].Trim();
                string description = parts[3].Trim();
                string dateStr = parts.Length > 4 ? parts[4].Trim() : null;

                DateTime? datePosted = null;
                if (!string.IsNullOrEmpty(dateStr) && DateTime.TryParse(dateStr, out DateTime parsedDate))
                    datePosted = parsedDate;

                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@UploadedByUserId", uploadedByUserId),
                    new SqlParameter("@AuthorName", authorName),
                    new SqlParameter("@NovelName", novelName),
                    new SqlParameter("@Description", description),
                    new SqlParameter("@DatePosted", (object)datePosted ?? DBNull.Value),
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(insertNovelQuery, parameters);

                if (rowsAffected > 0)
                    Debug.WriteLine($"Seeded novel '{novelName}' successfully.");
                else
                    Debug.WriteLine($"Failed to seed novel '{novelName}'.");
            }
        }

        private static void SeedChapters()
        {
            string checkQuery = "SELECT COUNT(*) FROM Chapters";
            int chapterCount = DatabaseHelper.ExecuteScalar<int>(checkQuery);

            if (chapterCount > 0)
            {
                Debug.WriteLine("Database already seeded with chapters. Skipping seeding.");
                return;
            }

            string csvPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SeedingFiles", "ChapterSeed.csv");

            if (!File.Exists(csvPath))
            {
                Debug.WriteLine($"ChapterSeed.csv not found at '{csvPath}'. Skipping chapter seeding.");
                return;
            }

            string novelsFolder = Path.Combine(AppContext.BaseDirectory, "Novels");
            Directory.CreateDirectory(novelsFolder);

            string insertQuery = @"INSERT INTO Chapters (NovelId, ChapterNumber, ChapterName)
                                   VALUES (@NovelId, @ChapterNumber, @ChapterName);
                                   SELECT CAST(SCOPE_IDENTITY() AS INT)";

            string[] lines = File.ReadAllLines(csvPath);

            foreach (string line in lines.Skip(1))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] parts = ParseCsvLine(line);

                if (parts.Length < 3)
                {
                    Debug.WriteLine($"Skipping malformed CSV line: '{line}'");
                    continue;
                }

                if (!int.TryParse(parts[0].Trim(), out int novelId) ||
                    !int.TryParse(parts[1].Trim(), out int chapterNumber))
                {
                    Debug.WriteLine($"Skipping line with invalid NovelId or ChapterNumber: '{line}'");
                    continue;
                }

                string chapterName = parts[2].Trim();

                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@NovelId", novelId),
                    new SqlParameter("@ChapterNumber", chapterNumber),
                    new SqlParameter("@ChapterName", chapterName),
                };

                int chapterId = DatabaseHelper.ExecuteScalar<int>(insertQuery, parameters);

                if (chapterId > 0)
                {
                    string filePath = Path.Combine(novelsFolder, $"{chapterId}.txt");
                    string content = $"Chapter {chapterNumber}: {chapterName}\n\n" +
                                     $"This is placeholder content for chapter {chapterNumber} of novel {novelId}.\n\n" +
                                     string.Concat(Enumerable.Repeat($"Lorem ipsum dolor sit amet for {chapterName}. ", 20));

                    File.WriteAllText(filePath, content);
                    Debug.WriteLine($"Seeded chapter '{chapterName}' (ChapterId={chapterId}) and wrote '{chapterId}.txt'.");
                }
                else
                {
                    Debug.WriteLine($"Failed to seed chapter '{chapterName}'.");
                }
            }
        }

        private static void SeedTags()
        {
            string checkQuery = "SELECT COUNT(*) FROM Tags";
            int tagCount = DatabaseHelper.ExecuteScalar<int>(checkQuery);

            if (tagCount > 0)
            {
                Debug.WriteLine("Database already seeded. Skipping seeding.");
                return;
            }

            string csvPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SeedingFiles", "TagSeed.csv");

            if (!File.Exists(csvPath))
            {
                Debug.WriteLine($"TagSeed.csv not found at '{csvPath}'. Skipping tag seeding.");
                return;
            }

            string insertUserQuery = @"INSERT INTO Tags (TagName, TagDescription) 
                                      VALUES (@tagName, @tagDescription)";

            string[] lines = File.ReadAllLines(csvPath);

            // Skip the header row
            foreach (string line in lines.Skip(1))
            {
                string[] parts = ParseCsvLine(line);

                if (parts.Length < 2)
                {
                    Debug.WriteLine($"Skipping malformed CSV line: '{line}'");
                    continue;
                }

                string tagName = parts[0].Trim();
                string tagDesc = parts[1].Trim();

                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@tagName", tagName),
                    new SqlParameter("@tagDescription", tagDesc),
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(insertUserQuery, parameters);

                if (rowsAffected > 0)
                    Debug.WriteLine($"Seeded tag '{tagName}' successfully.");
                else
                    Debug.WriteLine($"Failed to seed tag '{tagName}'.");
            }
        }

        private static void SeedNovelTags()
        {
            string checkQuery = "SELECT COUNT(*) FROM NovelTags";
            int novelTagCount = DatabaseHelper.ExecuteScalar<int>(checkQuery);

            if (novelTagCount > 0)
            {
                Debug.WriteLine("Database already seeded. Skipping seeding.");
                return;
            }

            string csvPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SeedingFiles", "NovelTagSeed.csv");

            if (!File.Exists(csvPath))
            {
                Debug.WriteLine($"NovelTagSeed.csv not found at '{csvPath}'. Skipping tag seeding.");
                return;
            }

            string insertUserQuery = @"INSERT INTO NovelTags (NovelId, TagId) 
                                      VALUES (@novelId, @tagId)";

            string[] lines = File.ReadAllLines(csvPath);

            // Skip the header row
            foreach (string line in lines.Skip(1))
            {
                string[] parts = ParseCsvLine(line);

                if (parts.Length < 2)
                {
                    Debug.WriteLine($"Skipping malformed CSV line: '{line}'");
                    continue;
                }

                string novelId = parts[0].Trim();
                string tagId = parts[1].Trim();

                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@novelId", novelId),
                    new SqlParameter("@tagId", tagId),
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(insertUserQuery, parameters);

                if (rowsAffected > 0)
                    Debug.WriteLine($"Seeded novelTag novel '{novelId}', tag '{tagId}' successfully.");
                else
                    Debug.WriteLine($"Did not Seed novelTag '{novelId}', '{tagId}'.");
            }
        }

        private static void SeedReviews()
        {
            string checkQuery = "SELECT COUNT(*) FROM Reviews";
            int reviewCount = DatabaseHelper.ExecuteScalar<int>(checkQuery);

            if (reviewCount > 0)
            {
                Debug.WriteLine("Database already seeded. Skipping seeding.");
                return;
            }

            string csvPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SeedingFiles", "ReviewSeed.csv");

            if (!File.Exists(csvPath))
            {
                Debug.WriteLine($"ReviewSeed.csv not found at '{csvPath}'. Skipping tag seeding.");
                return;
            }

            string insertUserQuery = @"INSERT INTO Reviews (UserId, NovelId, ReviewContent, Rating, ReviewPostedDate) 
                                      VALUES (@userId, @novelId, @reviewContent, @rating, @reviewPostedDate)";

            string[] lines = File.ReadAllLines(csvPath);

            // Skip the header row
            foreach (string line in lines.Skip(1))
            {
                string[] parts = ParseCsvLine(line);

                if (parts.Length < 2)
                {
                    Debug.WriteLine($"Skipping malformed CSV line: '{line}'");
                    continue;
                }

                string userId = parts[0];
                string novelId = parts[1];
                string reviewContent = parts[2];
                string rating = parts[3];
                string dateStr = parts.Length > 4 ? parts[4].Trim() : null;

                DateTime? reviewPostedDate = null;
                if (!string.IsNullOrEmpty(dateStr) && DateTime.TryParse(dateStr, out DateTime parsedDate))
                    reviewPostedDate = parsedDate;


                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@userId", userId),
                    new SqlParameter("@novelId", novelId),
                    new SqlParameter("@reviewContent", reviewContent),
                    new SqlParameter("@rating", rating),
                    new SqlParameter("@reviewPostedDate", reviewPostedDate)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(insertUserQuery, parameters);

                if (rowsAffected > 0)
                    Debug.WriteLine($"Seeded review user '{userId}', novel '{novelId}' successfully.");
                else
                    Debug.WriteLine($"Did not seed review user '{userId}', novel '{novelId}' successfully.");
            }
        }

        private static void SeedComments()
        {
            string checkQuery = "SELECT COUNT(*) FROM Comments";
            int commentCount = DatabaseHelper.ExecuteScalar<int>(checkQuery);

            if (commentCount > 0)
            {
                Debug.WriteLine("Database already seeded. Skipping seeding.");
                return;
            }

            string csvPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SeedingFiles", "CommentSeed.csv");

            if (!File.Exists(csvPath))
            {
                Debug.WriteLine($"CommentSeed.csv not found at '{csvPath}'. Skipping comment seeding.");
                return;
            }

            string insertCommentQuery = @"INSERT INTO Comments (UserId, ChapterId, CommentString, CommentPostedDate) 
                                      VALUES (@userId, @chapterId, @commentString, @commentPostedDate)";

            string[] lines = File.ReadAllLines(csvPath);

            // Skip the header row
            foreach (string line in lines.Skip(1))
            {
                string[] parts = ParseCsvLine(line);

                if (parts.Length < 2)
                {
                    Debug.WriteLine($"Skipping malformed CSV line: '{line}'");
                    continue;
                }

                string userId = parts[0];
                string chapterId = parts[1];
                string commentString = parts[2];
                string dateStr = parts.Length > 3 ? parts[3].Trim() : null;
                DateTime? commentPostedDate = null;
                if (!string.IsNullOrEmpty(dateStr) && DateTime.TryParse(dateStr, out DateTime parsedDate))
                    commentPostedDate = parsedDate;


                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@userId", userId),
                    new SqlParameter("@chapterId", chapterId),
                    new SqlParameter("@commentString", commentString),
                    new SqlParameter("@commentPostedDate", commentPostedDate)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(insertCommentQuery, parameters);

                if (rowsAffected > 0)
                    Debug.WriteLine($"Seeded comment user '{userId}', chapter '{chapterId}' successfully.");
                else
                    Debug.WriteLine($"Did not seed comment user '{userId}', chapter '{chapterId}' successfully.");
            }
        }

        private static void SeedReadHistories()
        {
            string checkQuery = "SELECT COUNT(*) FROM ReadHistories";
            int count = DatabaseHelper.ExecuteScalar<int>(checkQuery);

            if (count > 0)
            {
                Debug.WriteLine("Database already seeded with read histories. Skipping seeding.");
                return;
            }

            string csvPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SeedingFiles", "ReadHistorySeed.csv");

            if (!File.Exists(csvPath))
            {
                Debug.WriteLine($"ReadHistorySeed.csv not found at '{csvPath}'. Skipping read history seeding.");
                return;
            }

            string insertQuery = @"INSERT INTO ReadHistories (UserId, ChapterId, LastReadDate)
                                   VALUES (@UserId, @ChapterId, @LastReadDate)";

            string[] lines = File.ReadAllLines(csvPath);

            foreach (string line in lines.Skip(1))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] parts = ParseCsvLine(line);

                if (parts.Length < 3)
                {
                    Debug.WriteLine($"Skipping malformed CSV line: '{line}'");
                    continue;
                }

                if (!int.TryParse(parts[0].Trim(), out int userId) ||
                    !int.TryParse(parts[1].Trim(), out int chapterId))
                {
                    Debug.WriteLine($"Skipping line with invalid UserId or ChapterId: '{line}'");
                    continue;
                }

                if (!DateTime.TryParse(parts[2].Trim(), out DateTime lastReadDate))
                {
                    Debug.WriteLine($"Skipping line with invalid LastReadDate: '{line}'");
                    continue;
                }

                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@UserId", userId),
                    new SqlParameter("@ChapterId", chapterId),
                    new SqlParameter("@LastReadDate", lastReadDate),
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(insertQuery, parameters);

                if (rowsAffected > 0)
                    Debug.WriteLine($"Seeded read history UserId={userId}, ChapterId={chapterId} successfully.");
                else
                    Debug.WriteLine($"Failed to seed read history UserId={userId}, ChapterId={chapterId}.");
            }
        }

        private static string[] ParseCsvLine(string line)
        {
            var fields = new List<string>();
            bool inQuotes = false;
            var current = new StringBuilder();

            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];

                if (c == '"')
                {
                    inQuotes = !inQuotes;
                }
                else if (c == ',' && !inQuotes)
                {
                    fields.Add(current.ToString());
                    current.Clear();
                }
                else
                {
                    current.Append(c);
                }
            }

            fields.Add(current.ToString());
            return fields.ToArray();
        }
    }
}
