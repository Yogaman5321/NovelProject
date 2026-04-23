using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelProject.HomePage
{
    public class HistoryInfo
    {
        public int NovelId { get; set; }
        public string NovelName { get; set; }
        public int ChapterNumber { get; set; }
        public string ChapterTitle { get; set; }
        public DateTime LastReadDate { get; set; }
    }
}
