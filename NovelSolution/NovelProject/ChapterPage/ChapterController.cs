using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelProject.ChapterPage
{
    public class ChapterController
    {

        public String NovelTitle { get; }
        public int CurrentChapter { get; private set; }

        public event ChapterDisplayHandler OnDisplayChapter;

        public ChapterController(string name)
        {
            NovelTitle = name;
        }

        public void SetChapter(int chapter)
        {
            CurrentChapter = chapter;
            UpdateText();
        }

        public void ChangeChapter(int chapterOffest)
        {
            CurrentChapter += chapterOffest;
            UpdateText();
        }

        public void UpdateText() 
        {

            string text = "";
            try
            {
                string path = $"Novels/{NovelTitle}_{CurrentChapter}.txt";
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
