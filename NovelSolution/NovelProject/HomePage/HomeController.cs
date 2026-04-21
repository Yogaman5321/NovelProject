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
                    observer(HomePageState.GotHistory, history);
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
                SELECT TOP 10 C.ChapterName, RH.LastReadDate
                FROM ReadHistories RH
                INNER JOIN Chapters C ON RH.LastChapterRead = C.ChapterNumber
                WHERE RH.UserId = @UserID
                ORDER BY RH.LastReadDate DESC;";

            using (var reader = DatabaseHelper.ExecuteReader(sql, new SqlParameter("@UserID", userID)))
            {
                while (reader.Read())
                {
                    string chapterTitle = reader.GetString(0);
                    DateTime lastReadDate = reader.GetDateTime(1);
                    history.Add(new HistoryInfo { ChapterTitle = chapterTitle, LastReadDate = lastReadDate });
                }
            }

            return history;
        }
    }
}
