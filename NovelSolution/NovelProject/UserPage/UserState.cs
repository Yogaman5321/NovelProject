using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovelProject.Models;

namespace NovelProject.UserPage
{
    public enum UserState
    {
        LoadUser,
        ChangePassword,

        GotUserData,
        PasswordChanged,
        GotError
    }

    public class UserPageData
    {
        public int NovelsPosted { get; set; }
        public int NovelsRead { get; set; }
        public int ReviewsPosted { get; set; }
        public Tuple<List<Novel>, List<decimal>, List<string>, List<int>> History { get; set; }
        public List<string> Uploads { get; set; }
        public List<string> Comments { get; set; }
    }
}
