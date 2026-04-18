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
namespace NovelProject.HomePage
{
    public class HomeController
    {
        private List<ReadHistory> _readHistory;
        
        private string _username;
        public HomeController(List<ReadHistory> readHistory)
        {
            _readHistory = readHistory;

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
                    break;
            }
        }   

        public void LoadReadHistory()
        {
            //get user's ID from databsae, then get novelID and lastreaddate from read history from database using user ID, filter based on readdate to get the most recent novels and add them to the view, up to 10 novels loaded at once. Include last read time and novel title in the view.
            _readHistory.Clear();
            
            string sql = @"
                SELECT TOP 10 rh.NovelID, rh.LastReadDate, n.Title, n.Author, 
                FROM ReadHistory rh
                INNER JOIN Novels n ON rh.NovelID = n.ID
                WHERE rh.UserID = (SELECT ID FROM Users WHERE Username = @Username)
                ORDER BY rh.LastReadDate DESC";

            /*using (var reader = DatabaseHelper.ExecuteReader(sql, new SqlParameter("@UserID,  EnvironmentVars.UserID)))
             * {
             *  while (reader.READ())
             *  {
             *      int novelID = reader.GetInt32(0);
             *      DateTime lastReadDate = reader.GetDateTime(2);             
             *      _readHistory.Add(new ReadHistory { NovelID = novelID, LastReadDate = lastReadDate });
             * 
             * 
             **/
        }
    }
}
