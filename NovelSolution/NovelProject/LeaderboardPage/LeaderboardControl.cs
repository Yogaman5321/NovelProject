using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelProject.LeaderboardPage
{
    public class LeaderboardController
    {
        public LeaderboardObserver observer;

        public LeaderboardController(LeaderboardObserver observer)
        {
            this.observer = observer;
        }

        public void HandleEvents(LeaderboardState state)
        {
            switch (state)
            {
                case LeaderboardState.LoadLeaderboard:
                    var data = LoadLeaderboard();
                    observer(LeaderboardState.GotLeaderboard, data);
                    break;
            }
        }

        private LeaderboardData LoadLeaderboard()
        {
            var data = new LeaderboardData();

            data.TopNovelsRead = GetTopUsers(@"
                SELECT TOP 100 u.Username, COUNT(DISTINCT c.NovelId) AS Total
                FROM ReadHistories h
                JOIN Users u ON u.UserId = h.UserId
                JOIN Chapters c ON c.ChapterId = h.ChapterId
                GROUP BY u.Username
                ORDER BY Total DESC
            ");

            data.TopChaptersRead = GetTopUsers(@"
                SELECT TOP 100 u.Username, COUNT(DISTINCT h.ChapterId) AS Total
                FROM ReadHistories h
                JOIN Users u ON u.UserId = h.UserId
                GROUP BY u.Username
                ORDER BY Total DESC
            ");

            data.TopNovelsPosted = GetTopUsers(@"
                SELECT TOP 100 u.Username, COUNT(*) AS Total
                FROM Novels n
                JOIN Users u ON u.UserId = n.UploadedByUserId
                GROUP BY u.Username
                ORDER BY Total DESC
            ");

            data.TopRatedNovels = GetTopNovels1(@"
                SELECT TOP 10 n.NovelName, n.AuthorName, AVG(r.Rating) AS AvgRating
                FROM Reviews r
                JOIN Novels n ON n.NovelId = r.NovelId
                GROUP BY n.NovelName, n.AuthorName
                ORDER BY AvgRating DESC
            ");

            data.TopReadNovels = GetTopNovels2(@"
                SELECT TOP 10 n.NovelName, n.AuthorName, COUNT(*) AS Reads
                FROM ReadHistories h
                JOIN Chapters c ON c.ChapterId = h.ChapterId
                JOIN Novels n ON n.NovelId = c.NovelId
                GROUP BY n.NovelName, n.AuthorName
                ORDER BY Reads DESC
            ");

            return data;
        }

        private List<LeaderboardUser> GetTopUsers(string query)
        {
            var list = new List<LeaderboardUser>();
            var reader = DatabaseHelper.ExecuteReader(query);

            while (reader.Read())
            {
                list.Add(new LeaderboardUser
                {
                    Username = reader.GetString(0),
                    Value = reader.GetInt32(1)
                });
            }

            return list;
        }

        private List<LeaderboardNovel> GetTopNovels2(string query)
        {
            var list = new List<LeaderboardNovel>();
            var reader = DatabaseHelper.ExecuteReader(query);

            while (reader.Read())
            {
                list.Add(new LeaderboardNovel
                {
                    Title = reader.GetString(0),
                    Author = reader.GetString(1),
                    Value = reader.GetInt32(2)
                });
            }

            return list;
        }

        private List<LeaderboardNovel> GetTopNovels1(string query)
        {
            var list = new List<LeaderboardNovel>();
            var reader = DatabaseHelper.ExecuteReader(query);

            while (reader.Read())
            {
                list.Add(new LeaderboardNovel
                {
                    Title = reader.GetString(0),
                    Author = reader.GetString(1),
                    Value = reader.GetDecimal(2)
                });
            }

            return list;
        }
    }
}