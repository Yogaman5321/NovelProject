using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovelProject
{
    public delegate void LoginHandler(State s, string username);
    public delegate void LoginObserver(State s);
    public delegate void BrowserStateHandler(BrowserState state);
    public delegate void HomePageStateHandler(HomePageState state);
    internal static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginView());
        }
    }
}
