using Microsoft.Data.SqlClient;
using NovelProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelProject.UserPage
{
    public class UserController
    {
        internal static object getDetails(string currentUsername)
        {
            throw new NotImplementedException();
        }

        internal static Tuple<List<Novel>, List<decimal>, List<string>, List<int>> getHistory(string currentUsername)
        {
            string query = @"
                SELECT *
                FROM Novels n
                WHERE EXISTS (
                    SELECT 1
                    FROM ReadHistories r
                    WHERE r.NovelId = n.NovelId
                      AND r.UserId = (SELECT UserId FROM Users WHERE Username = @Username)
                )
                ORDER BY (
                    SELECT MAX(r.LastReadDate)
                    FROM ReadHistories r
                    WHERE r.NovelId = n.NovelId
                      AND r.UserId = (SELECT UserId FROM Users WHERE Username = @Username)
                ) DESC;
                ";


            var novels = new List<Novel>();
            using (var reader = DatabaseHelper.ExecuteReader(query, new SqlParameter("@Username", currentUsername)))
            {
                while (reader.Read())
                {
                    var novel = new Novel
                    {
                        NovelId = reader.GetInt32(0),
                        NovelName = reader.GetString(1),
                        AuthorName = reader.GetString(2),
                        Description = reader.GetString(3),
                        DatePosted = reader.GetDateTime(4),
                        UploadedByUserId = reader.GetInt32(5)
                    };
                    novels.Add(novel);
                    Debug.WriteLine($"Retrieved novel: {novel.NovelName} by {novel.AuthorName}");
                }
            }

            var ratings = new List<decimal>();
            var lastReads = new List<string>();
            var lastChapter = new List<int>();
            foreach (var item in novels)
            {
                string ratingQuery = $"SELECT Rating FROM Reviews WHERE NovelId = {item.NovelId} and UserId = (SELECT UserId FROM Users WHERE Username = '{currentUsername}')";
                decimal averageRating = DatabaseHelper.ExecuteScalar<decimal>(ratingQuery);
                if (averageRating > 0)
                {
                    ratings.Add(averageRating);
                } else
                {
                    ratings.Add(-1);
                }

                string lastReadQuery = $"SELECT MAX(LastReadDate) FROM ReadHistories WHERE NovelId = {item.NovelId} and UserId = (SELECT UserId FROM Users WHERE Username = '{currentUsername}')";
                DateTime? lastRead = DatabaseHelper.ExecuteScalar<DateTime?>(lastReadQuery);
                if (!lastRead.HasValue)
                {
                    lastReads.Add("N/A");
                }
                else
                {
                    lastReads.Add(lastRead.Value.ToString("g"));
                }

                string lastChapterQuery = @"
                    SELECT TOP 1 LastChapterRead
                    FROM ReadHistories
                    WHERE NovelId = @NovelId
                    AND UserId = (SELECT UserId FROM Users WHERE Username = @Username)
                    ORDER BY LastReadDate DESC";

                int? lastChapterNumber = DatabaseHelper.ExecuteScalar<int?>(
                    lastChapterQuery,
                    new SqlParameter("@NovelId", item.NovelId),
                    new SqlParameter("@Username", currentUsername)
                );

                if (!lastChapterNumber.HasValue)
                {
                    lastChapter.Add(0);
                }
                else
                {
                    lastChapter.Add(lastChapterNumber.Value);
                }
            }

            return Tuple.Create(novels, ratings, lastReads, lastChapter);
        }
    }
}
