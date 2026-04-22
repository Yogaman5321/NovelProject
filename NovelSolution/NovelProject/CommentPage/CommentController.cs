using Microsoft.Data.SqlClient;
using NovelProject.Models;
using System.Collections.Generic;

namespace NovelProject.CommentPage
{
    public class CommentController
    {
        public CommentObserver observer;

        public CommentController(CommentObserver observer)
        {
            this.observer = observer;
        }

        public void HandleEvents(CommentState state, int chapterId, string commentText)
        {
            switch (state)
            {
                case CommentState.LoadComments:
                    var comments = LoadComments(chapterId);
                    observer(CommentState.GotComments, comments, null, 0);
                    break;
                case CommentState.AddComment:
                    AddComment(chapterId, commentText);
                    observer(CommentState.CommentAdded, null, null, 0);
                    break;
                case CommentState.GetChapterForBack:
                    var (novel, chapterNumber) = GetChapterForBack(chapterId);
                    observer(CommentState.GotChapter, null, novel, chapterNumber);
                    break;
                default:
                    break;
            }
        }

        private List<string> LoadComments(int chapterId)
        {
            var comments = new List<string>();

            string query = $@"
                SELECT c.CommentString, u.Username, c.CommentPostedDate
                FROM Comments c
                JOIN Users u ON c.UserId = u.UserId
                WHERE c.ChapterId = {chapterId}
                ORDER BY c.CommentPostedDate ASC;
            ";

            var result = DatabaseHelper.ExecuteReader(query);
            while (result.Read())
            {
                comments.Add($" \n{result.GetString(0)} \nBy: {result.GetString(1)} on {result.GetDateTime(2)}\n ");
            }

            return comments;
        }

        private void AddComment(int chapterId, string commentText)
        {
            string query = $@"
                INSERT INTO Comments (ChapterId, UserId, CommentString)
                VALUES (
                    {chapterId},
                    (SELECT UserId FROM Users WHERE Username = '{EnvironmentVars.username}'),
                    '{commentText}'
                );
            ";

            DatabaseHelper.ExecuteNonQuery(query);
        }

        private (Novel novel, int chapterNumber) GetChapterForBack(int chapterId)
        {
            string novelQuery = $@"
                SELECT n.NovelId, n.NovelName, n.AuthorName, n.Description, n.DatePosted, n.UploadedByUserId
                FROM Novels n
                JOIN Chapters c ON c.NovelId = n.NovelId
                WHERE c.ChapterId = {chapterId};
            ";

            Novel novel = null;
            var novelResult = DatabaseHelper.ExecuteReader(novelQuery);
            if (novelResult.Read())
            {
                novel = new Novel
                {
                    NovelId = novelResult.GetInt32(0),
                    NovelName = novelResult.GetString(1),
                    AuthorName = novelResult.GetString(2),
                    Description = novelResult.GetString(3),
                    DatePosted = novelResult.GetDateTime(4),
                    UploadedByUserId = novelResult.GetInt32(5)
                };
            }

            string chapterQuery = $@"
                SELECT ChapterNumber
                FROM Chapters
                WHERE ChapterId = {chapterId};
            ";
            int chapterNumber = DatabaseHelper.ExecuteScalar<int>(chapterQuery);

            return (novel, chapterNumber);
        }
    }
}
