using Microsoft.Data.SqlClient;
using NovelProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.ListBox;
using static System.Windows.Forms.ListView;

namespace NovelProject.NovelEditPage
{
    public class NovelEditController
    {
        public NovelEditObserver observer;

        public NovelEditController(NovelEditObserver observer)
        {
            this.observer = observer;
        }

        public void HandleEvents(NovelEditState state, Novel novel, Chapter chapter, string title, ObjectCollection tags, ListViewItemCollection chapters)
        {
            switch (state)
            {
                case NovelEditState.CreateNovel:
                    var createdNovel = CreateNovel(novel);
                    observer(NovelEditState.NovelCreated, createdNovel, null);
                    break;
                case NovelEditState.DeleteNovel:
                    DeleteNovel(novel);
                    break;
                case NovelEditState.UpdateNovel:
                    UpdateNovel(novel, tags, chapters);
                    break;
                case NovelEditState.SaveChapter:
                    var savedChapter = SaveChapter(novel.NovelId, title, chapters.Count + 1);
                    observer(NovelEditState.ChapterSaved, null, savedChapter);
                    break;
                case NovelEditState.EditChapter:
                    var editedChapter = EditChapter(chapter, title);
                    observer(NovelEditState.ChapterEdited, null, editedChapter);
                    break;
                default:
                    break;
            }
        }

        private Novel CreateNovel(Novel novel)
        {
            string userIdQuery = $"SELECT UserId FROM Users WHERE Username = '{EnvironmentVars.username}'";
            int userId = DatabaseHelper.ExecuteScalar<int>(userIdQuery);
            string query = $"INSERT INTO Novels (NovelName, UploadedByUserId, AuthorName, Description) VALUES ('{novel.NovelName}', {userId}, '{novel.AuthorName}', '{novel.Description}'); SELECT CAST(SCOPE_IDENTITY() AS INT)";
            int novelId = DatabaseHelper.ExecuteScalar<int>(query);
            novel.NovelId = novelId;
            return novel;
        }

        private Chapter EditChapter(Chapter chapter, string title)
        {
            string query = $"UPDATE Chapters SET ChapterName = '{title}' WHERE ChapterId = {chapter.ChapterId}";
            DatabaseHelper.ExecuteNonQuery(query);

            return new Chapter
            {
                ChapterId = chapter.ChapterId,
                NovelId = chapter.NovelId,
                ChapterNumber = chapter.ChapterNumber,
                ChapterName = title,
                DateAdded = DateTime.Now
            };
        }

        private Chapter SaveChapter(int novelID, string title, int chapternumber)
        {
            string query = $"INSERT INTO Chapters (NovelId, ChapterNumber, ChapterName) VALUES ({novelID}, {chapternumber}, '{title}'); SELECT CAST(SCOPE_IDENTITY() AS INT)";
            int chapterId = DatabaseHelper.ExecuteScalar<int>(query);

            string basePath = AppContext.BaseDirectory;
            string novelsFolder = Path.Combine(basePath, "Novels");

            string txtPath = Path.Combine(novelsFolder, $"{novelID}_{chapternumber}.txt");
            string pdfPath = Path.Combine(novelsFolder, $"{novelID}_{chapternumber}.pdf");

            string oldPath = null;

            if (File.Exists(txtPath))
                oldPath = txtPath;
            else if (File.Exists(pdfPath))
                oldPath = pdfPath;

            string extension = Path.GetExtension(oldPath);

            string newPath = Path.Combine(novelsFolder, $"{chapterId}{extension}");

            File.Move(oldPath, newPath, true);

            return new Chapter
            {
                ChapterId = chapterId,
                NovelId = novelID,
                ChapterNumber = chapternumber,
                ChapterName = title,
                DateAdded = DateTime.Now
            };
        }

        private void UpdateNovel(Novel novel, ObjectCollection tags, ListViewItemCollection chapters)
        {
            string query = $"UPDATE Novels SET NovelName = '{novel.NovelName}', AuthorName = '{novel.AuthorName}', Description = '{novel.Description}' WHERE NovelId = {novel.NovelId}";
            DatabaseHelper.ExecuteNonQuery(query);

            DatabaseHelper.ExecuteNonQuery(
                "DELETE FROM NovelTags WHERE NovelId = @NovelId",
                new SqlParameter("@NovelId", novel.NovelId)
            );

            foreach (Tag tag in tags)
            {
                DatabaseHelper.ExecuteNonQuery(
                    "INSERT INTO NovelTags (NovelId, TagId) VALUES (@NovelId, @TagId)",
                    new SqlParameter("@NovelId", novel.NovelId),
                    new SqlParameter("@TagId", tag.TagId)
                );
            }

            DatabaseHelper.ExecuteNonQuery(
                "UPDATE Chapters SET ChapterNumber = ChapterNumber + 10000 WHERE NovelId = @NovelId",
                new SqlParameter("@NovelId", novel.NovelId)
            );

            foreach (ListViewItem item in chapters)
            {
                if (item.Tag is Chapter chapter)
                {
                    query = @"
                            UPDATE Chapters
                            SET 
                                ChapterNumber = @ChapterNumber,
                                ChapterName = @ChapterName
                            WHERE ChapterId = @ChapterId;
                            ";

                    var parameters = new SqlParameter[]
                    {
                        new SqlParameter("@ChapterNumber", chapter.ChapterNumber),
                        new SqlParameter("@ChapterName", chapter.ChapterName),
                        new SqlParameter("@ChapterId", chapter.ChapterId),
                    };

                    DatabaseHelper.ExecuteNonQuery(query, parameters);
                }
            }

            DatabaseHelper.ExecuteNonQuery("Delete FROM Chapters WHERE ChapterNumber > 10000");
        }

        private void DeleteNovel(Novel novel)
        {
            DatabaseHelper.ExecuteNonQuery(
                "DELETE FROM Novels WHERE NovelId = @NovelId",
                new SqlParameter("@NovelId", novel.NovelId)
            );
        }
    }
}
