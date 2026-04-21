using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovelProject
{
    public static class EnvironmentVars
    {
        public static string username { get; set; }

        public static bool IsLoggedIn => !string.IsNullOrEmpty(username) && username != "Guest";
    }
}
