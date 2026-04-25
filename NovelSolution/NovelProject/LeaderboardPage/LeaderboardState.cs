using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelProject.LeaderboardPage
{

    public enum LeaderboardState
    {
        LoadLeaderboard,
        GotLeaderboard,
        GotError
    }


    public class LeaderboardUser
    {
        public string Username { get; set; }
        public int Value { get; set; }
    }

    public class LeaderboardNovel
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Value { get; set; } // rating or read count
    }

    public class LeaderboardData
    {
        public List<LeaderboardUser> TopNovelsRead { get; set; }
        public List<LeaderboardUser> TopChaptersRead { get; set; }
        public List<LeaderboardUser> TopNovelsPosted { get; set; }

        public List<LeaderboardNovel> TopRatedNovels { get; set; }
        public List<LeaderboardNovel> TopReadNovels { get; set; }
    }

}
