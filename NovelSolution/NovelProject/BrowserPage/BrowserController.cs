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

        public List<Novel> Search(string search, string searchType)
        {
            List<Novel> results = new List<Novel>();

            string column;

            switch (searchType)
            {
                case "Title":
                    column = "Title";
                    break;
                case "Author":
                    column = "Author";
                    break;
                case "Tag":
                    column = "Tag";
                    break;
                default:
                    column = "Title";
                    break;
            }

            //TODO: replace by reading in query results to Novel list
            // also consider async calling depending on fetch speed of db
            results = new List<Novel>
            {
                new Novel { NovelName = "Title 1", AuthorName = "Alice" },
                new Novel { NovelName = "Title 2", AuthorName = "Bob" },
                new Novel { NovelName = "Title 3", AuthorName = "Clara" }
            };

            return results;
        }

        public void StateHandler(BrowserState state)
        {
            switch (state)
            {
                case BrowserState.Default:
                    //load all novel cards from database using private method GenerateNovelCards() and order them by random and add them to the listbox in the view
                    //load all tags from database using private method GenerateTags() and add them to the combo box in the view
                    break;
                case BrowserState.Popular:
                    //filter novel cards based on popularity and order them by popularity and add them to the listbox in the view
                    break;
                case BrowserState.New:
                    //filter novel cards based on release date and order them by release date and add them to the listbox in the view
                    break;
                case BrowserState.Random:
                    //filter novel cards based on random selection of novelID's where they are all unique and order them by random and add them to the listbox in the view
                    break;
                case BrowserState.HigestRating:
                    //filter novel cards based on rating and order them by rating and add them to the listbox in the view
                    break;
                case BrowserState.TagChanged:
                    //filter novel cards based on the selected tag in the combo box and order them by random and add them to the listbox in the view
                    break;
                case BrowserState.Recommended:
                    //filter novel cards based on user preferences and recommendations and order them by relevance and add them to the listbox in the view
                    break;

            }
        }

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
