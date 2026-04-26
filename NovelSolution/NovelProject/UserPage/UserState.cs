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
}
