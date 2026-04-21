using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelProject.ChapterPage
{
    public class ChapterController
    {

        public String NovelId { get; }
        public int CurrentChapter { get; private set; }

        public event ChapterDisplayHandler OnDisplayChapter;

        private int _maxChapters;
        public ChapterController(string id)
        {
            NovelId = id;
            string query = $"SELECT COUNT(*) FROM Chapters WHERE NovelId = {NovelId}";
            _maxChapters = DatabaseHelper.ExecuteScalar<int>(query);
        }

        public void SetChapter(int chapter)
        {
            CurrentChapter = chapter;
            UpdateText();
        }

        public void ChangeChapter(int chapterOffest)
        {
            if (CurrentChapter + chapterOffest > 0 &&  CurrentChapter + chapterOffest <= _maxChapters + 1)
            {
                CurrentChapter += chapterOffest;
                UpdateText();
            }
        }

        public void UpdateText() 
        {

            string text = "";
            try
            {
                string basePath = AppContext.BaseDirectory;

                string query = $"SELECT ChapterId FROM Chapters WHERE NovelId = {NovelId} AND ChapterNumber = {CurrentChapter}";
                int chapterId = DatabaseHelper.ExecuteScalar<int>(query);

                string path = Path.Combine(basePath, "Novels", $"{chapterId}.txt");

                text = File.ReadAllText(path);
            } 
            catch
            {
                text = "No more chapters.";
            }

            OnDisplayChapter?.Invoke(text);

        }

        public void UpdateReadHistory()
        {
            string query = $@"
                IF EXISTS (SELECT 1 FROM ReadHistories WHERE UserId = (SELECT UserId FROM Users WHERE Username = '{EnvironmentVars.username}') AND NovelId = {NovelId})
                BEGIN
                    UPDATE ReadHistories 
                    SET LastChapterRead = {CurrentChapter}, LastReadDate = GETDATE() 
                    WHERE UserId = (SELECT UserId FROM Users WHERE Username = '{EnvironmentVars.username}') AND NovelId = {NovelId}
                END
                ELSE
                BEGIN
                    INSERT INTO ReadHistories (UserId, NovelId, LastChapterRead) 
                    VALUES ((SELECT UserId FROM Users WHERE Username = '{EnvironmentVars.username}'), {NovelId}, {CurrentChapter})
                END
            ";
            DatabaseHelper.ExecuteNonQuery(query);
        }
    }
}
