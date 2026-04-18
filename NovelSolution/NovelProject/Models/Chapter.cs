using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelProject.Models
{
    public class Chapter
    {
        public int ChapterId { get; set; }
        public int NovelId { get; set; }
        public int ChapterNumber { get; set; }
        public string ChapterName { get; set; }
        public DateTime DateAdded { get; set; }

    }
}
