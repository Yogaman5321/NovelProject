using Microsoft.Data.SqlClient;
using NovelProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelProject.AuthorPage
{
    public class AuthorController
    {
        public AuthorObserver observer;

        public AuthorController(AuthorObserver observer)
        {
            this.observer = observer;
        }

        public void HandleEvents(AuthorState state, string authorName, Novel novel)
        {
            switch (state)
            {
                case AuthorState.GetNovels:
                    var novels = GetNovelsByAuthor(authorName);
                    observer(novels != null ? AuthorState.GotNovels : AuthorState.GotError, novels);
                    break;
                case AuthorState.DeleteNovel:
                    DeleteNovel(novel);
                    var updatedNovels = GetNovelsByAuthor(EnvironmentVars.username);
                    observer(updatedNovels != null ? AuthorState.GotNovels : AuthorState.GotError, updatedNovels);
                    break;
                default:
                    break;
            }
        }

        private List<Novel> GetNovelsByAuthor(string authorName)
        {
            string query = @"
            SELECT NovelId, NovelName, AuthorName, Description, DatePosted, UploadedByUserId
            FROM Novels
            WHERE UploadedByUserId = @UploadedByUserId
            ";

            string userIdQuery = @"
                SELECT UserId
                FROM Users
                WHERE Username = @Username
            ";

            int userId = DatabaseHelper.ExecuteScalar<int>(userIdQuery, new SqlParameter("@Username", authorName));

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@UploadedByUserId", userId));

            return GetFilteredNovels(query, parameters.ToArray());
        }

        private void DeleteNovel(Novel selectedNovel)
        {
            string query = @"
                DELETE FROM Novels
                WHERE NovelId = @NovelId
            ";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@NovelId", selectedNovel.NovelId));

            DatabaseHelper.ExecuteNonQuery(query, parameters.ToArray());
        }

        private List<Novel> GetFilteredNovels(string fullQuery, SqlParameter[] parameters)
        {
            try
            {
                var novels = new List<Novel>();
                using (var reader = DatabaseHelper.ExecuteReader(fullQuery, parameters))
                {
                    while (reader.Read())
                    {
                        var novel = new Novel
                        {
                            NovelId = reader.GetInt32(0),
                            NovelName = reader.GetString(1),
                            AuthorName = reader.GetString(2),
                            Description = reader.GetString(3),
                            DatePosted = reader.GetDateTime(4),
                            UploadedByUserId = reader.GetInt32(5)
                        };
                        novels.Add(novel);
                        Debug.WriteLine($"Retrieved novel: {novel.NovelName} by {novel.AuthorName}");
                    }
                }
                return novels;
            }
            catch
            {
                return null;
            }
        }
    }
}
