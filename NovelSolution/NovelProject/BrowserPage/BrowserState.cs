using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelProject.BrowserPage
{
    public enum BrowserState
    {
        GetAllNovels,
        GetFilteredNovels,

        GotNovels,
        GotError,

        Default,
        Popular,
        New,
        Random,
        HigestRating,
        TagChanged,
        Recommended

    }
}
