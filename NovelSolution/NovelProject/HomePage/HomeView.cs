using NovelProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NovelProject.ChapterPage;
using NovelProject.Navigation;

namespace NovelProject.HomePage
{
    public partial class HomeView : UserControl, INavigatable
    {
        public HomeHandler handler;
        private Action<UserControl> _navigate;
        private List<HistoryInfo> _history = new();

        public HomeView()
        {
            InitializeComponent();
            WelcomeLabel.Text = $"Welcome, {EnvironmentVars.username}!";

            UxLastReadListBox.DrawMode = DrawMode.OwnerDrawVariable;
            UxLastReadListBox.MeasureItem += UxLastReadListBox_MeasureItem;
            UxLastReadListBox.DrawItem += UxLastReadListBox_DrawItem;
            UxLastReadListBox.DoubleClick += UxLastReadListBox_DoubleClick;

            this.Load += LoadHistory;
        }

        public void SetNavigator(Action<UserControl> navigate)
        {
            _navigate = navigate;
        }

        public void SetHomeHandler(HomeHandler handler)
        {
            this.handler = handler;
        }

        public void DisplayState(HomePageState s, List<HistoryInfo> history)
        {
            switch (s)
            {
                case HomePageState.GotHistory:
                    LoadReadHistory(history);
                    break;
                default:
                    break;
            }
        }

        private void LoadHistory(object sender, EventArgs e)
        {
            handler(HomePageState.LoadRecentNovels);
        }

        private void LoadReadHistory(List<HistoryInfo> history)
        {
            _history = history;
            UxLastReadListBox.Items.Clear();
            foreach (HistoryInfo info in history)
            {
                UxLastReadListBox.Items.Add(
                    $"{info.NovelName} — Ch.{info.ChapterNumber}: {info.ChapterTitle}\nLast read on {info.LastReadDate}");
            }
        }

        private void UxLastReadListBox_DoubleClick(object sender, EventArgs e)
        {
            int index = UxLastReadListBox.SelectedIndex;
            if (index < 0 || _navigate == null) return;

            HistoryInfo info = _history[index];

            var novel = new Novel { NovelId = info.NovelId, NovelName = info.NovelName };
            var view = new ChapterView(novel, info.ChapterNumber);
            var controller = new ChapterController(view.DisplayState, info.NovelId.ToString());
            view.SetChapterHandler(controller.HandleEvents);
            view.SetMaxChapters(controller.MaxChapters);
            view.SetNavigator(_navigate);

            _navigate(view);
        }

        private void UxLastReadListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index < 0) return;

            string text = UxLastReadListBox.Items[e.Index].ToString();
            SizeF size = e.Graphics.MeasureString(text, UxLastReadListBox.Font,
                UxLastReadListBox.ClientSize.Width);

            e.ItemHeight = (int)Math.Ceiling(size.Height) + 4;
        }

        private void UxLastReadListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();

            string text = UxLastReadListBox.Items[e.Index].ToString();
            Rectangle bounds = new Rectangle(e.Bounds.X + 2, e.Bounds.Y + 2,
                e.Bounds.Width - 4, e.Bounds.Height - 4);

            using var brush = new SolidBrush(e.ForeColor);
            e.Graphics.DrawString(text, e.Font, brush, bounds);

            e.DrawFocusRectangle();
        }
    }
}
