using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelProject.NovelEditPage
{
    public enum NovelEditState
    {
        CreateNovel,
        DeleteNovel,
        UpdateNovel,
        SaveChapter,
        EditChapter,

        NovelCreated,
        ChapterSaved,
        ChapterEdited,
        GotError
    }
}
