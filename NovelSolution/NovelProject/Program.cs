using Microsoft.Data.SqlClient;
using NovelProject.LoginPage;
using NovelProject.BrowserPage;
using NovelProject.AuthorPage;
using NovelProject.ChapterPage;
using NovelProject.HomePage;
using NovelProject.NovelEditPage;
using NovelProject.NovelPage;
using NovelProject.UserPage;
using NovelProject.Models;
using NovelProject.CommentPage;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NovelProject.ReviewControl;
using static System.Windows.Forms.ListView;
using static System.Windows.Forms.ListBox;


namespace NovelProject
{

    public delegate void LoginHandler(LoginState s, string username, string password);
    public delegate void LoginObserver(LoginState s);

    public delegate void BrowserHandler(BrowserState s, string query, List<SqlParameter> parameters);
    public delegate void BrowserObserver(BrowserState s, List<Novel> novels);

    public delegate void AuthorHandler(AuthorState s, string authorName, Novel novel);
    public delegate void AuthorObserver(AuthorState s, List<Novel> novels);

    public delegate void ChapterHandler(ChapterState s, int value);
    public delegate void ChapterObserver(ChapterState s, string text, int currentChapter);

    public delegate void HomeHandler(HomePageState s);
    public delegate void HomeObserver(HomePageState s, List<HistoryInfo> history);
    public delegate void HomeNovelsObserver(HomePageState s, List<Novel> novels);

    public delegate void NovelEditHandler(NovelEditState s, Novel novel, Chapter chapter, string title, ObjectCollection tags, ListViewItemCollection chapters);
    public delegate void NovelEditObserver(NovelEditState s, Novel novel, Chapter chapter);

    public delegate void NovelPageHandler(NovelPageState s, Novel novel);
    public delegate void NovelPageObserver(NovelPageState s, List<Chapter> chapters);

    public delegate void UserHandler(UserState s, string username, string newPassword);
    public delegate void UserObserver(UserState s, UserPageData data);

    public delegate void CommentHandler(CommentState s, int chapterId, string commentText);
    public delegate void CommentObserver(CommentState s, List<string> comments, Novel novel, int chapterNumber);

    public delegate void ReviewObserver(ReviewState s, Review r);
    public delegate void ReviewHandler(ReviewState s, string content, decimal rating, Novel novel, int reviewId);

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
