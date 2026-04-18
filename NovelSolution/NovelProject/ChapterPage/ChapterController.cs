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

        public ChapterController(string id)
        {
            NovelId = id;
        }

        public void SetChapter(int chapter)
        {
            CurrentChapter = chapter;
            UpdateText();
        }

        public void ChangeChapter(int chapterOffest)
        {
            if (CurrentChapter + chapterOffest > 0)
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
                string path = Path.Combine(basePath, "Novels", $"{NovelId}_{CurrentChapter}.txt");

                text = File.ReadAllText(path);
            } 
            catch (Exception ex)
            {
                text = "No more chapters.";
                CurrentChapter = Math.Max(0, CurrentChapter - 1);
            }

            OnDisplayChapter?.Invoke(text);

        }
    }
}
