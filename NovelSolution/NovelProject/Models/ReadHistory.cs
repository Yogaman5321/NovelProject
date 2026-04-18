using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelProject.Models
{
    public class ReadHistory
    {
        public int UserId { get; set; }

        public int ChapterId { get; set; }

        public DateTime LastReadDate { get; set; }



    }
}
