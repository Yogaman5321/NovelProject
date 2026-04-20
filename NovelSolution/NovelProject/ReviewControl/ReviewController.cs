using Microsoft.IdentityModel.Tokens;
using NovelProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace NovelProject.ReviewControl
{
    public class ReviewController
    {
        private readonly ReviewObserver _reviewObserver;

        public ReviewController(ReviewObserver observer)
        {
            _reviewObserver = observer;
        }

        public void HandleEvents(ReviewState s, string content, decimal rating, Novel novel, int id)
        {
            switch (s)
            {
                case ReviewState.GetReview:
                    Review r = GetReview(novel);
                    _reviewObserver(r == null ? ReviewState.NoReview : ReviewState.GotReview, r);
                    break;
                case ReviewState.PostReview:
                    PostReview(content, rating, novel);
                    _reviewObserver(ReviewState.PostReview, null);
                    break;
                case ReviewState.EditReview:
                    EditReview(content, rating, id);
                    _reviewObserver(ReviewState.EditReview, null);
                    break;
                case ReviewState.DeleteReview:
                    DeleteReview(id);
                    _reviewObserver(ReviewState.DeleteReview, null);
                    break;
            }
        }

        private Review GetReview(Novel novel)
        {
            string query = "SELECT r.ReviewId, ReviewContent, Rating, ReviewPostedDate, r.UserId " +
                           "FROM Reviews r " +
                           "JOIN Users u ON r.UserId = u.UserId " +
                           "WHERE r.NovelId = @NovelId AND u.Username = @Username";

            using var reader = DatabaseHelper.ExecuteReader(
                query,
                new SqlParameter("@NovelId", novel.NovelId),
                new SqlParameter("@Username", EnvironmentVars.username));

            if (!reader.Read()) return null;

            return new Review
            {
                ReviewId = reader.GetInt32(0),
                ReviewContent = reader.GetString(1),
                Rating = reader.GetDecimal(2),
                ReviewPostedDate = reader.GetDateTime(3),
                UserId = reader.GetInt32(4),
                NovelId = novel.NovelId
            };
        }

        private void PostReview(string content, decimal rating, Novel novel)
        {
            int userId = DatabaseHelper.ExecuteScalar<int>(
                "SELECT UserId FROM Users WHERE Username = @Username",
                new SqlParameter("@Username", EnvironmentVars.username));

            if (userId == 0)
                throw new Exception("User not found.");

            DatabaseHelper.ExecuteNonQuery(
                "INSERT INTO Reviews (UserId, NovelId, ReviewContent, Rating) VALUES (@UserId, @NovelId, @Content, @Rating)",
                new SqlParameter("@UserId", userId),
                new SqlParameter("@NovelId", novel.NovelId),
                new SqlParameter("@Content", content),
                new SqlParameter("@Rating", rating));
        }

        private void EditReview(string content, decimal rating, int reviewId)
        {
            DatabaseHelper.ExecuteNonQuery(
                "UPDATE Reviews SET ReviewContent = @Content, Rating = @Rating WHERE ReviewId = @ReviewId",
                new SqlParameter("@Content", content),
                new SqlParameter("@Rating", rating),
                new SqlParameter("@ReviewId", reviewId));
        }

        private void DeleteReview(int reviewId)
        {
            DatabaseHelper.ExecuteNonQuery(
                "DELETE FROM Reviews WHERE ReviewId = @ReviewId",
                new SqlParameter("@ReviewId", reviewId));
        }
    }
}
