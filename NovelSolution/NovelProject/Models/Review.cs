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

        // Maybe change to int if we only want to do that
        public decimal Rating { get; set; }

        public DateTime ReviewPostedDate { get; set; }

        public Review(int reviewId, int userId, int novelId, string reviewContent, decimal rating)
        {
            ReviewId = reviewId;
            UserId = userId;
            NovelId = novelId;
            ReviewContent = reviewContent;
            Rating = rating;
            ReviewPostedDate = DateTime.Now;
        }
    }
}
