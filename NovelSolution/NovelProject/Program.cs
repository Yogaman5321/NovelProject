using Microsoft.Data.SqlClient;
using NovelProject.LoginPage;
using NovelProject.BrowserPage;
using NovelProject.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NovelProject
{

 
    
    public delegate void HomePageStateHandler(HomePageState state);

    public delegate void ChapterDisplayHandler(string text);

    public delegate void LoginHandler(LoginState s, string username, string password);
    public delegate void LoginObserver(LoginState s);

    public delegate void BrowserHandler(BrowserState s, string query, List<SqlParameter> parameters);
    public delegate void BrowserObserver(BrowserState s, List<Novel> novels);

    public delegate void NovelHandler();
    public delegate void NovelObserver(List<Novel> novels);

    internal static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            try
            {
                InitializeDatabase();
                DatabaseTestingSeeder.SeedDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to initialize/seed database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            
            Application.Run(new MainAppContext());
        }

        private static void InitializeDatabase()
        {
            string sqlFile;

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            DirectoryInfo directory = new DirectoryInfo(baseDirectory);

            while (directory != null && !File.Exists(Path.Combine(directory.FullName, "NovelProject.csproj")))
            {
                directory = directory.Parent;
            }

            if (directory != null)
            {
                sqlFile = Path.Combine(directory.FullName, "CreateDatabase.sql");
            }
            else
            {
                sqlFile = Path.Combine(baseDirectory, "CreateDatabase.sql");
            }

            if (!File.Exists(sqlFile))
            {
                throw new FileNotFoundException("SQL file not found: " + sqlFile);
            }

            string sqlScript = File.ReadAllText(sqlFile);
            DatabaseHelper.ExecuteSqlScript(sqlScript);
        }
    }
}
