using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelProject.LoginPage
{
    public enum LoginState
    {
        LoginAsGuest,        
        SucceedLogin,
        SucceedCreate,
        FailLogin,
        FailCreate,

        TryLoginAccount,
        TryCreateAccount,
    }
}
