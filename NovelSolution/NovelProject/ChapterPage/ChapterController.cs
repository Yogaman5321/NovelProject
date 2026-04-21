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
        public ChapterObserver observer;

        public string NovelId { get; }
        public int CurrentChapter { get; private set; }

        private int _maxChapters;

        public ChapterController(ChapterObserver observer, string id)
        {
            this.observer = observer;
            NovelId = id;
            string query = $"SELECT COUNT(*) FROM Chapters WHERE NovelId = {NovelId}";
            _maxChapters = DatabaseHelper.ExecuteScalar<int>(query);
        }

        public void HandleEvents(ChapterState state, int value)
        {
            switch (state)
            {
                case ChapterState.SetChapter:
                    CurrentChapter = value;
                    UpdateText();
                    break;
                case ChapterState.ChangeChapter:
                    if (CurrentChapter + value > 0 && CurrentChapter + value <= _maxChapters + 1)
                    {
                        CurrentChapter += value;
                        UpdateText();
                    }
                    break;
                case ChapterState.UpdateReadHistory:
                    UpdateReadHistory();
                    break;
                default:
                    break;
            }
        }

        private void UpdateText()
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
            observer(ChapterState.GotChapter, text, CurrentChapter);
        }

        private void UpdateReadHistory()
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
