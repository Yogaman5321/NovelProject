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
        UpdateNovel,
        AddTag,
        SaveChapter,
        EditChapter,

        NovelCreated,
        ChapterSaved,
        ChapterEdited,
        GotError
    }
}
