using Microsoft.Data.SqlClient;
using NovelProject.LoginPage;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovelProject
{
    public delegate void LoginHandler(LoginState s, string username, string password);
    public delegate void LoginObserver(LoginState s);

    public delegate void ChapterDisplayHandler(string text);

    public delegate void NovelInfoHandler(string title, string author, string description);
    public delegate void NovelChapterHandler(ArrayList chapters);

    internal static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Ensure database is created and optionally seed it
            using (var context = new ProjectDatabaseContext())
            {
                // Create database if it doesn't exist
                context.Database.EnsureCreated();

                // Seed database with test data
                DatabaseTestingSeeder.SeedDatabase(context);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginView loginView = new LoginView();
            LoginController loginController = new LoginController(loginView.DisplayState);
            loginView.SetLoginHandler(loginController.HandleEvents);


            
            Application.Run(loginView);

        }
    }
}
