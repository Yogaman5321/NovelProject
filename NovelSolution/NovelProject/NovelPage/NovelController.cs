using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelProject.NovelPage
{
    public class NovelController
    {

        private string _novel;

        public event Action<string, string, string> OnNovelInfoLoaded;
        public event Action<List<string>> OnChaptersLoaded;

        public NovelController(string novel)
        {
            _novel = novel;
        }

        public void SetUpPage() 
        {

            // TODO: replace with DB call later that gets the novel info from the title.
            string title = _novel;
            string author = "Author Name";
            string description = "This is a description of the novel.";

            OnNovelInfoLoaded?.Invoke(title, author, description);

            //TODO: Get chapterTitles from database
            List<string> chapters = new List<string>
            {
                "Chapter 1",
                "Chapter 2",
                "Chapter 3"
            };

            OnChaptersLoaded?.Invoke(chapters);
        }

    }
}
