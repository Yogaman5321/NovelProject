using Microsoft.Data.SqlClient;
using NovelProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NovelProject.BrowserPage
{
    

    public class BrowserController
    {
        public BrowserObserver observer;


        public BrowserController(BrowserObserver observer)
        {
            this.observer = observer;
        }

        public void HandleEvents(BrowserState state, string fullQuery, List<SqlParameter> parameters)
        {
            switch (state)
            {
                case BrowserState.GetAllNovels:
                    var novels = GetAllNovels(fullQuery);
                    if(novels != null)
                    {
                        observer(BrowserState.GotNovels, novels);
                    }
                    else
                    {
                        observer(BrowserState.GotError, null);
                    }
                    break;
                case BrowserState.GetFilteredNovels:
                    var filteredNovels = GetFilteredNovels(fullQuery, parameters.ToArray());
                    if (filteredNovels != null)
                    {
                        observer(BrowserState.GotNovels, filteredNovels);
                    }
                    else
                    {
                        observer(BrowserState.GotError, null);
                    }
                    break;
                default:
                    break;

            }
        }

        public List<Novel> GetAllNovels(string fullQuery)
        {            
            try
            {
                var novels = new List<Novel>();
                using (var reader = DatabaseHelper.ExecuteReader(fullQuery))
                {
                    while (reader.Read())
                    {
                        var novel = new Novel
                        {
                            NovelId = reader.GetInt32(0),
                            NovelName = reader.GetString(1),
                            AuthorName = reader.GetString(2),
                            Description = reader.GetString(3),
                            DatePosted = reader.GetDateTime(4),
                            UploadedByUserId = reader.GetInt32(5)
                        };
                        novels.Add(novel);
                    }
                }
                return novels;
            }
            catch
            {
                return null;
            }
        }

        public List<Novel> GetFilteredNovels(string fullQuery, SqlParameter[] parameters)
        {
            try
            {
                var novels = new List<Novel>();
                using (var reader = DatabaseHelper.ExecuteReader(fullQuery, parameters))
                {
                    while (reader.Read())
                    {
                        var novel = new Novel
                        {
                            NovelId = reader.GetInt32(0),
                            NovelName = reader.GetString(1),
                            AuthorName = reader.GetString(2),
                            Description = reader.GetString(3),
                            DatePosted = reader.GetDateTime(4),
                            UploadedByUserId = reader.GetInt32(5)
                        };
                        novels.Add(novel);
                    }
                }
                return novels;
            }
            catch
            {
                return null;
            }
        }


        // This belongs in the BrowserView. I'll move it over there once I have the search functionality working.
        private void GenerateNovelCards()
        {
            // Logic to generate novel cards based on the current state of the browser and the novels loaded from the database
            //get top 20 results from novel databasebased on the state of the browser and generate novel cards for each novel and add them to the listbox


        }

        private void GenerateTags()
        {
            //logic to add tags to the combo box based on all unique tags in the novel database 

        }
    }
}
