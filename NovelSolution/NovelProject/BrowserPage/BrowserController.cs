using Microsoft.Data.SqlClient;
using NovelProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
