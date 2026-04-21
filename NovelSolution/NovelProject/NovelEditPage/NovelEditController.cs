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
        internal Novel CreateNovel(Novel novel)
        {
            string query = $"INSERT INTO Novels (NovelName, UploadedByUserId, AuthorName, Description) VALUES ('{novel.NovelName}', 1, '{novel.AuthorName}', '{novel.Description}'); SELECT CAST(SCOPE_IDENTITY() AS INT)";
            int novelId = DatabaseHelper.ExecuteScalar<int>(query);

            novel.NovelId = novelId;

            return novel;
        }

        internal Chapter EditChapter(Chapter chapter, string title)
        {
            string query = $"UPDATE Chapters SET ChapterName = '{title}' WHERE ChapterId = {chapter.ChapterId}";
            DatabaseHelper.ExecuteNonQuery(query);

            return new Chapter
            {
                NovelId = chapter.NovelId,
                ChapterNumber = chapter.ChapterNumber,
                ChapterName = title,
                DateAdded = DateTime.Now
            };
        }

        internal Chapter SaveChapter(int novelID, string title, int chapternumber)
        {

            string query = $"INSERT INTO Chapters (NovelId, ChapterNumber, ChapterName) VALUES ({novelID}, {chapternumber}, '{title}'); SELECT CAST(SCOPE_IDENTITY() AS INT)";
            int chapterId = DatabaseHelper.ExecuteScalar<int>(query);

            string basePath = AppContext.BaseDirectory;

            string newPath = Path.Combine(basePath, "Novels", $"{chapterId}.txt");
            string oldPath = Path.Combine(basePath, "Novels", $"{novelID}_{chapternumber}.txt");

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

        internal void updateNovel(Novel novel, ObjectCollection tags, ListViewItemCollection chapters)
        {
            string query = $"UPDATE Novels SET NovelName = '{novel.NovelName}', AuthorName = '{novel.AuthorName}', Description = '{novel.Description}' WHERE NovelId = {novel.NovelId}";
            DatabaseHelper.ExecuteNonQuery(query);

            foreach (var tag in tags)
            {
                string getTagIdQuery = $"SELECT TagId FROM Tags WHERE TagName = '{tag}'";
                int tagId = DatabaseHelper.ExecuteScalar<int>(getTagIdQuery);
                try
                {
                    query = $"INSERT INTO NovelTags (NovelId, TagId) VALUES ({novel.NovelId}, {tagId})";
                    DatabaseHelper.ExecuteNonQuery(query);
                }
                catch (SqlException ex) when (ex.Number == 2627) // Unique constraint violation
                {
                    Debug.WriteLine($"Tag '{tag}' already exists for NovelId {novel.NovelId}, skipping.");
                }
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

        public void addTag(string name, string description) 
        {
            //TODO: make the thing passing to this funciton add a description of its own
            string query = @"
                IF NOT EXISTS (SELECT 1 FROM Tags WHERE TagName = @name)
                BEGIN
                    INSERT INTO Tags (TagName, TagDescription)
                    VALUES (@name, @description)
                END";


            var parameters = new SqlParameter[]
            {
                new SqlParameter("@name", name),
                new SqlParameter("@description", description),
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);

        }
    }
}
