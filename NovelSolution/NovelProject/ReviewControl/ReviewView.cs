using System;
using System.Windows.Forms;
using NovelProject.Models;
using Microsoft.Data.SqlClient;

namespace NovelProject.ReviewControl
{
    public partial class ReviewView : UserControl
    {
        private ReviewHandler _reviewHandler;
        private const int MaxChars = 500;
        private int _reviewId;
        private Novel _novel;

        public ReviewView()
        {
            InitializeComponent();
        }

        public ReviewView(Novel novel)
        {
            InitializeComponent();

            _novel = novel;
            reviewContentBox.MaxLength = MaxChars;
            reviewContentBox.TextChanged += reviewContentBox_TextChanged;
            submitReviewButton.Enabled = false;
            editReviewButton.Enabled = false;
            deleteReviewButton.Enabled = false;
            _reviewId = GetReviewId();
            Load += ReviewViewLoadInfo;
            VisibleChanged += ReviewViewLoadInfo;
        }

        public void DisplayState(ReviewState s, Review r)
        {
            switch (s)
            {
                case ReviewState.GotReview:
                    reviewContentBox.Text = r.ReviewContent;
                    ratingNumericUpDown.Value = r.Rating;
                    _reviewId = GetReviewId();
                    break;
                case ReviewState.NoReview:
                case ReviewState.DeleteReview:
                    reviewContentBox.Text = "";
                    ratingNumericUpDown.Value = 1.0m;
                    _reviewId = GetReviewId();
                    break;
                case ReviewState.PostReview:
                    _reviewId = GetReviewId();
                    submitReviewButton.Enabled = false;
                    editReviewButton.Enabled = reviewContentBox.Text.Length > 0 && _reviewId != -1;
                    deleteReviewButton.Enabled = _reviewId != -1;
                    break;
            }
        }

        public void SetHandler(ReviewHandler handler) => _reviewHandler = handler;

        public void SetNovel(Novel novel) => _novel = novel;

        private void submitReviewButton_Click(object sender, EventArgs e)
        {
            SetButtonsEnabled(false, false, false);
            _reviewHandler(ReviewState.PostReview, reviewContentBox.Text, ratingNumericUpDown.Value, _novel, -1);
        }

        private void editReviewButton_Click(object sender, EventArgs e)
        {
            SetButtonsEnabled(false, false, false);
            _reviewHandler(ReviewState.EditReview, reviewContentBox.Text, ratingNumericUpDown.Value, _novel, _reviewId);
        }

        private void deleteReviewButton_Click(object sender, EventArgs e)
        {
            SetButtonsEnabled(false, false, false);
            _reviewHandler(ReviewState.DeleteReview, null, -1, null, _reviewId);
        }

        private void reviewContentBox_TextChanged(object sender, EventArgs e)
        {
            characterCountLabel.Text = $"{reviewContentBox.Text.Length}/{MaxChars}";
            submitReviewButton.Enabled = reviewContentBox.Text.Length > 0 && _reviewId == -1;
            editReviewButton.Enabled = reviewContentBox.Text.Length > 0 && _reviewId != -1;
            deleteReviewButton.Enabled = _reviewId != -1;
        }

        private void ReviewViewLoadInfo(object sender, EventArgs e)
        {
            _reviewId = GetReviewId();
            submitReviewButton.Enabled = _reviewId == -1;
            editReviewButton.Enabled = _reviewId != -1;
            deleteReviewButton.Enabled = _reviewId != -1;
            _reviewHandler(ReviewState.GetReview, null, -1, _novel, _reviewId);
        }

        private int GetReviewId()
        {
            string query = "SELECT ReviewId FROM Reviews r " +
                           "JOIN Users u ON r.UserId = u.UserId " +
                           "WHERE r.NovelId = @NovelId AND u.Username = @Username";

            using var reader = DatabaseHelper.ExecuteReader(
                query,
                new SqlParameter("@NovelId", _novel.NovelId),
                new SqlParameter("@Username", EnvironmentVars.username));

            return reader.Read() ? reader.GetInt32(0) : -1;
        }

        private void SetButtonsEnabled(bool submit, bool edit, bool delete)
        {
            submitReviewButton.Enabled = submit;
            editReviewButton.Enabled = edit;
            deleteReviewButton.Enabled = delete;
        }
    }
}
