using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelProject.LeaderboardPage
{
    public class LeaderboardData
    {
        public List<LeaderboardUser> TopNovelsRead { get; set; }
        public List<LeaderboardUser> TopChaptersRead { get; set; }
        public List<LeaderboardUser> TopNovelsPosted { get; set; }

        public List<LeaderboardNovel> TopRatedNovels { get; set; }
        public List<LeaderboardNovel> TopReadNovels { get; set; }
    }
}
