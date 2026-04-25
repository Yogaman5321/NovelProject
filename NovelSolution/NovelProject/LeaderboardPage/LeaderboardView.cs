using NovelProject.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovelProject.LeaderboardPage
{
    public partial class LeaderboardView : UserControl, INavigatable
    {
        public Action<LeaderboardState> handler;

        public LeaderboardView()
        {
            InitializeComponent();
            SetupLists();
            this.Load += LoadLeaderboard;
        }

        private Action<UserControl> _navigate;
        public void SetNavigator(Action<UserControl> navigate)
        {
            _navigate = navigate;
        }

        public void SetHandler(Action<LeaderboardState> handler)
        {
            this.handler = handler;
        }

        private void LoadLeaderboard(object sender, EventArgs e)
        {
            handler(LeaderboardState.LoadLeaderboard);
        }

        public void DisplayState(LeaderboardState state, LeaderboardData data)
        {
            if (state == LeaderboardState.GotLeaderboard)
            {
                PopulateUsers(uxNovelsReadList, data.TopNovelsRead);
                PopulateUsers(uxChaptersReadList, data.TopChaptersRead);
                PopulateUsers(uxNovelsPostedList, data.TopNovelsPosted);

                PopulateNovels(uxTopRatedList, data.TopRatedNovels, "Rating");
                PopulateNovels(uxTopReadList, data.TopReadNovels, "Reads");
            }
        }

        private void SetupLists()
        {
            SetupUserList(uxNovelsReadList);
            SetupUserList(uxChaptersReadList);
            SetupUserList(uxNovelsPostedList);

            SetupNovelList(uxTopRatedList);
            SetupNovelList(uxTopReadList);
        }

        private void SetupUserList(ListView lv)
        {
            lv.View = View.Details;
            lv.FullRowSelect = true;
            lv.Columns.Add("#", 50);
            lv.Columns.Add("Username", 150);
            lv.Columns.Add("Value", 75);
        }

        private void SetupNovelList(ListView lv)
        {
            lv.View = View.Details;
            lv.FullRowSelect = true;
            lv.Columns.Add("#", 50);
            lv.Columns.Add("Title", 200);
            lv.Columns.Add("Author", 150);
            lv.Columns.Add("Value", 75);
        }

        private void PopulateUsers(ListView lv, List<LeaderboardUser> users)
        {
            lv.Items.Clear();

            int rank = 0;
            int index = 0;
            int? lastValue = null;

            foreach (var u in users)
            {
                index++;

                // Only update rank if value changes
                if (lastValue == null || u.Value != lastValue)
                {
                    rank = index;
                    lastValue = u.Value;
                }

                var item = new ListViewItem(rank.ToString());
                item.SubItems.Add(u.Username);
                item.SubItems.Add(u.Value.ToString());

                lv.Items.Add(item);
            }
        }

        private void PopulateNovels(ListView lv, List<LeaderboardNovel> novels, string label)
        {
            lv.Items.Clear();

            int rank = 0;
            int index = 0;
            decimal? lastValue = null;

            foreach (var n in novels)
            {
                index++;

                // Round value (for ratings)
                decimal displayValue = Math.Round(n.Value, 2);

                if (lastValue == null || n.Value != lastValue)
                {
                    rank = index;
                    lastValue = n.Value;
                }

                var item = new ListViewItem(rank.ToString());
                item.SubItems.Add(n.Title);
                item.SubItems.Add(n.Author);

                // Optional: label-specific formatting
                if (label == "Rating")
                    item.SubItems.Add($"{displayValue:0.00} / 10");
                else
                    item.SubItems.Add(displayValue.ToString());

                lv.Items.Add(item);
            }
        }
    }
}