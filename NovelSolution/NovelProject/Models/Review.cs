using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelProject.Models
{
    public class Review
    {

        public int ReviewId { get; set; }

        public int UserId { get; set; }

        public int NovelId { get; set; }

        public string ReviewContent { get; set; }

        public decimal Rating { get; set; }

        public DateTime ReviewPostedDate { get; set; }
    }
}
