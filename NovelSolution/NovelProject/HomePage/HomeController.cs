using NovelProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace NovelProject.HomePage
{
    public class HomeController
    {
        public HomeObserver observer;

        public HomeController(HomeObserver observer)
        {
            this.observer = observer;

        }

        public void HandleEvents(HomePageState state)
        {
            switch (state)
            {
                case HomePageState.LoadRecentNovels:
                    var history = LoadReadHistory();
                    observer(HomePageState.GotHistory, history, null);
                    break;
                case HomePageState.LoadSimilarNovels:
                    var similarNovels = LoadSimilarNovels();
                    observer(HomePageState.GotSimilarNovels, null, similarNovels);
                    break;
                case HomePageState.LoadNewestNovels:
                    var newestNovels = LoadNewestNovels();
                    observer(HomePageState.GotNewestNovels, null, newestNovels);
                    break;
                default:
                    break;
            }
        }

        private List<HistoryInfo> LoadReadHistory()
        {
            var history = new List<HistoryInfo>();

            int userID = DatabaseHelper.ExecuteScalar<int>(
                "SELECT UserId FROM Users WHERE Username = @Username",
                new SqlParameter("@Username", EnvironmentVars.username));

            string sql = @"
                    WITH RankedHistory AS (
                        SELECT 
                            N.NovelId,
                            N.NovelName,
                            C.ChapterNumber,
                            C.ChapterName,
                            RH.LastReadDate,
                            ROW_NUMBER() OVER (
                                PARTITION BY N.NovelId 
                                ORDER BY RH.LastReadDate DESC
                            ) AS rn
                        FROM ReadHistories RH
                        INNER JOIN Chapters C ON C.ChapterId = RH.ChapterId
                        INNER JOIN Novels N ON N.NovelId = C.NovelId
                        WHERE RH.UserId = @UserID
                    ),
                    LatestPerNovel AS (
                        SELECT *
                        FROM RankedHistory
                        WHERE rn = 1
                    )
                    SELECT TOP 10 *
                    FROM LatestPerNovel
                    ORDER BY LastReadDate DESC;";

            using (var reader = DatabaseHelper.ExecuteReader(sql, new SqlParameter("@UserID", userID)))
            {
                while (reader.Read())
                {
                    history.Add(new HistoryInfo
                    {
                        NovelId       = reader.GetInt32(0),
                        NovelName     = reader.GetString(1),
                        ChapterNumber = reader.GetInt32(2),
                        ChapterTitle  = reader.GetString(3),
                        LastReadDate  = reader.GetDateTime(4)
                    });
                }
            }

            return history;
        }

        private List<Novel> LoadSimilarNovels()
        {
            var novels = new List<Novel>();

            int userID = DatabaseHelper.ExecuteScalar<int>(
                "SELECT UserId FROM Users WHERE Username = @Username",
                new SqlParameter("@Username", EnvironmentVars.username));

            string sql = @"
                SELECT TOP 20
                    N.NovelId, N.NovelName, N.AuthorName, N.Description, N.DatePosted, N.UploadedByUserId,
                    COUNT(DISTINCT rh_similar.UserId) AS SimilarUserReadCount
                FROM ReadHistories rh_similar
                INNER JOIN Chapters c_similar ON c_similar.ChapterId = rh_similar.ChapterId
                INNER JOIN Novels N ON N.NovelId = c_similar.NovelId
                WHERE
                    rh_similar.UserId IN (
                        SELECT DISTINCT rh_other.UserId
                        FROM ReadHistories rh_other
                        INNER JOIN Chapters c_other ON c_other.ChapterId = rh_other.ChapterId
                        WHERE c_other.NovelId IN (
                            SELECT DISTINCT c_mine.NovelId
                            FROM ReadHistories rh_mine
                            INNER JOIN Chapters c_mine ON c_mine.ChapterId = rh_mine.ChapterId
                            WHERE rh_mine.UserId = @UserID
                        )
                        AND rh_other.UserId != @UserID
                    )
                    AND N.NovelId NOT IN (
                        SELECT DISTINCT c_mine2.NovelId
                        FROM ReadHistories rh_mine2
                        INNER JOIN Chapters c_mine2 ON c_mine2.ChapterId = rh_mine2.ChapterId
                        WHERE rh_mine2.UserId = @UserID
                    )
                    AND EXISTS (
                        SELECT 1
                        FROM NovelTags nt_candidate
                        INNER JOIN NovelTags nt_read ON nt_read.TagId = nt_candidate.TagId
                        INNER JOIN Chapters c_read   ON c_read.NovelId = nt_read.NovelId
                        INNER JOIN ReadHistories rh_read ON rh_read.ChapterId = c_read.ChapterId
                        WHERE nt_candidate.NovelId = N.NovelId
                        AND rh_read.UserId = @UserID
                    )
                GROUP BY N.NovelId, N.NovelName, N.AuthorName, N.Description, N.DatePosted, N.UploadedByUserId
                ORDER BY SimilarUserReadCount DESC;";

            using (var reader = DatabaseHelper.ExecuteReader(sql, new SqlParameter("@UserID", userID)))
            {
                while (reader.Read())
                {
                    novels.Add(new Novel
                    {
                        NovelId          = reader.GetInt32(0),
                        NovelName        = reader.GetString(1),
                        AuthorName       = reader.GetString(2),
                        Description      = reader.GetString(3),
                        DatePosted       = reader.GetDateTime(4),
                        UploadedByUserId = reader.GetInt32(5)
                    });
                }
            }

            return novels;
        }

        private List<Novel> LoadNewestNovels()
        {
            var novels = new List<Novel>();

            string sql = @"
                SELECT TOP 20 NovelId, NovelName, AuthorName, Description, DatePosted, UploadedByUserId
                FROM Novels
                ORDER BY DatePosted DESC;";

            using (var reader = DatabaseHelper.ExecuteReader(sql))
            {
                while (reader.Read())
                {
                    novels.Add(new Novel
                    {
                        NovelId          = reader.GetInt32(0),
                        NovelName        = reader.GetString(1),
                        AuthorName       = reader.GetString(2),
                        Description      = reader.GetString(3),
                        DatePosted       = reader.GetDateTime(4),
                        UploadedByUserId = reader.GetInt32(5)
                    });
                }
            }

            return novels;
        }
    }
}
