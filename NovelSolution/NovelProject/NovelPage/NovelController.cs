using Microsoft.Data.SqlClient;
using NovelProject.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelProject.NovelPage
{
    public class NovelController
    {
        public NovelPageObserver observer;

        public NovelController(NovelPageObserver observer)
        {
            this.observer = observer;
        }

        public void HandleEvents(NovelPageState state, Novel novel)
        {
            switch (state)
            {
                case NovelPageState.SetupPage:
                    var chapters = GetChapters(novel);
                    observer(chapters != null ? NovelPageState.GotChapters : NovelPageState.GotError, chapters);
                    break;
                default:
                    break;
            }
        }

        private List<Chapter> GetChapters(Novel novel)
        {
            string query = @"
            SELECT NovelId, ChapterId, ChapterNumber, ChapterName, DateAdded
            FROM Chapters
            WHERE NovelId = @NovelId
            ORDER BY ChapterNumber
            ";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@NovelId", novel.NovelId));

            return GetFilteredChapters(query, parameters.ToArray());
        }

        private static List<Chapter> GetFilteredChapters(string fullQuery, SqlParameter[] parameters)
        {
            try
            {
                var chapters = new List<Chapter>();
                using (var reader = DatabaseHelper.ExecuteReader(fullQuery, parameters))
                {
                    while (reader.Read())
                    {
                        var chapter = new Chapter
                        {
                            ChapterId = reader.GetInt32(1),
                            NovelId = reader.GetInt32(0),
                            ChapterNumber = reader.GetInt32(2),
                            ChapterName = reader.GetString(3),
                            DateAdded = reader.GetDateTime(4)
                        };
                        chapters.Add(chapter);
                        Debug.WriteLine($"Retrieved chapter: {chapter.ChapterName} by {chapter.ChapterId}");
                    }
                }
                return chapters;
            }
            catch
            {
                return null;
            }
        }
    }
}
