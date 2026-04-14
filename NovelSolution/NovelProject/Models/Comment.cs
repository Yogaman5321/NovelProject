using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelProject.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public int UserId { get; set; }
        public int ChapterId { get; set; }
        public string CommentString { get; set; }
        public DateTime DatePosted { get; set; }

        public Comment(int commentId, int userId, int chapterId, string commentString)
        {
            CommentId = commentId;
            UserId = userId;
            ChapterId = chapterId;
            CommentString = commentString;
            DatePosted = DateTime.Now;
        }
    }
}
