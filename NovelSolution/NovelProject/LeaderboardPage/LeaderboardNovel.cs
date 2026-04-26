using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelProject.LeaderboardPage
{
    public class LeaderboardNovel
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Value { get; set; } // rating or read count
    }
}
