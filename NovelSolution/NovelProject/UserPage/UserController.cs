using BCrypt.Net;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
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
        public UserObserver observer;

        public UserController(UserObserver observer)
        {
            this.observer = observer;
        }

        public void HandleEvents(UserState state, string username, string newPassword)
        {
            switch (state)
            {
                case UserState.LoadUser:
                    var data = LoadUserData(username);
                    observer(UserState.GotUserData, data);
                    break;
                case UserState.ChangePassword:
                    ChangePassword(username, newPassword);
                    observer(UserState.PasswordChanged, null);
                    break;
                default:
                    break;
            }
        }

        private UserPageData LoadUserData(string username)
        {
            var data = new UserPageData();

            string query = $@"
                SELECT 
                    (SELECT COUNT(*) FROM Novels WHERE UploadedByUserId = (SELECT UserId FROM Users WHERE Username = '{username}')) AS NovelsPosted,
                    (SELECT COUNT(DISTINCT c.NovelId) FROM ReadHistories h INNER JOIN Chapters c ON c.ChapterId = h.ChapterId WHERE h.UserId = (SELECT UserId FROM Users WHERE Username = '{username}')) AS NovelsRead,
                    (SELECT COUNT(*) FROM Reviews r JOIN Users u ON r.UserId = u.UserId WHERE u.Username = '{username}') AS ReviewsPosted
            ";

            var statsReader = DatabaseHelper.ExecuteReader(query);
            if (statsReader.Read())
            {
                data.NovelsPosted = statsReader.GetInt32(0);
                data.NovelsRead = statsReader.GetInt32(1);
                data.ReviewsPosted = statsReader.GetInt32(2);
            }

            data.History = GetHistory(username);

            data.Uploads = new List<string>();
            string uploadsQuery = $"SELECT NovelName, AuthorName FROM Novels WHERE UploadedByUserId = (SELECT UserId FROM Users WHERE Username = '{username}')";
            var uploadsReader = DatabaseHelper.ExecuteReader(uploadsQuery);
            while (uploadsReader.Read())
            {
                data.Uploads.Add($"{uploadsReader.GetString(0)}|{uploadsReader.GetString(1)}");
            }

            data.Comments = new List<string>();
            string commentsQuery = $@"SELECT n.NovelName, c.ChapterNumber, s.CommentString
                              FROM Comments s
                              JOIN Chapters c on c.ChapterId = s.ChapterId
                              JOIN Novels n on n.NovelId = c.NovelId
                              where s.UserId = (Select UserId FROM Users WHERE Username = '{username}')";
            var commentsReader = DatabaseHelper.ExecuteReader(commentsQuery);
            while (commentsReader.Read())
            {
                data.Comments.Add($" \n{commentsReader.GetString(0)}, Chapter: {commentsReader.GetInt32(1)} \n{commentsReader.GetString(2)}\n ");
            }

            return data;
        }

        private void ChangePassword(string username, string newPassword)
        {
            string query = $"SELECT UserId FROM Users WHERE Username = '{username}'";
            int userID = DatabaseHelper.ExecuteScalar<int>(query);
            string newHash = BCrypt.Net.BCrypt.HashPassword(newPassword);
            string updateQuery = $"UPDATE Users SET EncryptedPassword = '{newHash}' WHERE UserId = {userID}";
            DatabaseHelper.ExecuteNonQuery(updateQuery);
        }

        private static Tuple<List<Novel>, List<decimal>, List<string>, List<int>> GetHistory(string currentUsername)
        {
            string query = @"
                WITH LastRead AS (
                    SELECT c.NovelId, MAX(r.LastReadDate) AS MaxLastRead
                    FROM ReadHistories r
                    INNER JOIN Chapters c ON c.ChapterId = r.ChapterId
                    WHERE r.UserId = (SELECT UserId FROM Users WHERE Username = @Username)
                    GROUP BY c.NovelId
                )
                SELECT n.NovelId, n.NovelName, n.AuthorName, n.Description, n.DatePosted, n.UploadedByUserId
                FROM Novels n
                INNER JOIN LastRead lr ON lr.NovelId = n.NovelId
                ORDER BY lr.MaxLastRead DESC;";

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
                string ratingQuery = $"SELECT Rating FROM Reviews WHERE NovelId = {item.NovelId} AND UserId = (SELECT UserId FROM Users WHERE Username = '{currentUsername}')";
                decimal averageRating = DatabaseHelper.ExecuteScalar<decimal>(ratingQuery);
                ratings.Add(averageRating > 0 ? averageRating : -1);

                string lastReadQuery = @"
                    SELECT MAX(r.LastReadDate)
                    FROM ReadHistories r
                    INNER JOIN Chapters c ON c.ChapterId = r.ChapterId
                    WHERE c.NovelId = @NovelId
                      AND r.UserId = (SELECT UserId FROM Users WHERE Username = @Username)";

                DateTime? lastRead = DatabaseHelper.ExecuteScalar<DateTime?>(
                    lastReadQuery,
                    new SqlParameter("@NovelId", item.NovelId),
                    new SqlParameter("@Username", currentUsername)
                );
                lastReads.Add(lastRead.HasValue ? lastRead.Value.ToString("g") : "N/A");

                string lastChapterQuery = @"
                    SELECT TOP 1 c.ChapterNumber
                    FROM ReadHistories r
                    INNER JOIN Chapters c ON c.ChapterId = r.ChapterId
                    WHERE c.NovelId = @NovelId
                      AND r.UserId = (SELECT UserId FROM Users WHERE Username = @Username)
                    ORDER BY r.LastReadDate DESC";

                int? lastChapterNumber = DatabaseHelper.ExecuteScalar<int?>(
                    lastChapterQuery,
                    new SqlParameter("@NovelId", item.NovelId),
                    new SqlParameter("@Username", currentUsername)
                );
                lastChapter.Add(lastChapterNumber.HasValue ? lastChapterNumber.Value : 0);
            }

            return Tuple.Create(novels, ratings, lastReads, lastChapter);
        }
    }
}
