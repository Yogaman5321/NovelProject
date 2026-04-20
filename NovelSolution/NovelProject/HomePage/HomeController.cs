using NovelProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
public enum HomePageState
{
    Default,
    LoadRecentNovels,


}
public class HistoryInfo()
{
    public string ChapterTitle { get; set; }
    public DateTime LastReadDate { get; set; }



}
namespace NovelProject.HomePage
{
    public class HomeController
    {
        private List<HistoryInfo> _readHistory;

        private HomePageStateHandler _viewHandle;

        public HomeController(List<HistoryInfo> readHistory, HomePageStateHandler handler)
        {
            _readHistory = readHistory;
            _viewHandle = handler;

        }

        public void handler(HomePageState state)
        {
            switch (state)
            {
                case HomePageState.Default:
                    //load most recent novels from database using read history of the user and add them to the view, up to 10 novels loaded at once. Include last read time and novel title in the view.
                    //load all tags from database using private method GenerateTags() and add them to the combo box in the view
                    break;
                case HomePageState.LoadRecentNovels:
                    //load most recent novels from database using read history of the user and add them to the view, up to 10 novels loaded at once. Include last read time and novel title in the view.
                    LoadReadHistory();
                    _viewHandle(HomePageState.LoadRecentNovels);

                    break;
            }
        }

        public void LoadReadHistory()
        {
            //get user's ID from databsae, then get novelID and lastreaddate from read history from database using user ID, filter based on readdate to get the most recent novels and add them to the view, up to 10 novels loaded at once. Include last read time and novel title in the view.
            _readHistory.Clear();

            int userID = DatabaseHelper.ExecuteScalar<int>("SELECT ID FROM Users WHERE Username = @Username", new SqlParameter("@Username", Environment.UserName));

            string sql = @"
                SELECT TOP 10 C.ChapterName, RH.LastReadDate
                FROM ReadHistory RH
                INNER JOIN Chapters C ON RH.ChapterID = C.ID
                WHERE RH.UserID = @UserID   
                
                ORDER BY RH.LastReadDate DESC;";

            using (var reader = DatabaseHelper.ExecuteReader(sql, new SqlParameter("@UserID", userID)))
            {
                while (reader.Read())
                {
                    int chapterID = reader.GetInt32(0);
                    DateTime lastReadDate = reader.GetDateTime(1);
                    _readHistory.Add(new HistoryInfo { ChapterTitle = chapterID.ToString(), LastReadDate = lastReadDate });



                }
            }


        }
    }
}
