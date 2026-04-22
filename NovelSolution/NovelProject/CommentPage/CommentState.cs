using NovelProject.Models;
using System.Collections.Generic;

namespace NovelProject.CommentPage
{
    public enum CommentState
    {
        LoadComments,
        AddComment,
        GetChapterForBack,

        GotComments,
        CommentAdded,
        GotChapter,
        GotError
    }
}
