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
using NovelProject.Models;
using NovelProject.Navigation;
using NovelProject.NovelPage;

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

            similarUsersPanel.SizeChanged += SimilarUsersPanel_SizeChanged;
            newestAdditionsPanel.SizeChanged += NewestAdditionsPanel_SizeChanged;

            this.Load += LoadHistory;
        }

        public void SetNavigator(Action<UserControl> navigate)
        {
            _navigate = navigate;

            foreach (Control control in similarUsersPanel.Controls)
            {
                if (control is NovelDisplayCard card)
                {
                    card.SetNavigator(_navigate);
                }
            }

            foreach (Control control in newestAdditionsPanel.Controls)
            {
                if (control is NovelDisplayCard card)
                {
                    card.SetNavigator(_navigate);
                }
            }
        }

        public void SetHomeHandler(HomeHandler handler)
        {
            this.handler = handler;
        }

        public void DisplayState(HomePageState s, List<HistoryInfo> history, List<Novel> novels)
        {
            switch (s)
            {
                case HomePageState.GotHistory:
                    LoadReadHistory(history);
                    break;
                case HomePageState.GotSimilarNovels:
                    DisplayNovelsInPanel(similarUsersPanel, novels);
                    break;
                case HomePageState.GotNewestNovels:
                    DisplayNovelsInPanel(newestAdditionsPanel, novels);
                    break;
                default:
                    break;
            }
        }

        public void DisplaySimilarNovelsState(HomePageState s, List<Novel> novels)
        {
            switch (s)
            {
                case HomePageState.GotSimilarNovels:
                    DisplayNovelsInPanel(similarUsersPanel, novels);
                    break;
                default:
                    break;
            }
        }

        public void DisplayNewestNovelsState(HomePageState s, List<Novel> novels)
        {
            switch (s)
            {
                case HomePageState.GotNewestNovels:
                    DisplayNovelsInPanel(newestAdditionsPanel, novels);
                    break;
                default:
                    break;
            }
        }

        private void LoadHistory(object sender, EventArgs e)
        {
            handler(HomePageState.LoadRecentNovels);
            handler(HomePageState.LoadSimilarNovels);
            handler(HomePageState.LoadNewestNovels);
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

        private void DisplayNovelsInPanel(FlowLayoutPanel panel, List<Novel> novels)
        {
            panel.Controls.Clear();

            int cardWidth = panel.Width - SystemInformation.VerticalScrollBarWidth;

            foreach (var novel in novels)
            {
                var card = new NovelDisplayCard();
                card.Populate(novel);
                card.SetNavigator(_navigate);
                card.Width = cardWidth;

                EventHandler navigateToNovel = (s, e) =>
                {
                    var view = new NovelView(novel);
                    var controller = new NovelController(view.DisplayState);
                    view.SetNovelHandler(controller.HandleEvents);
                    _navigate?.Invoke(view);
                };

                card.DoubleClick += navigateToNovel;

                foreach (Control child in card.Controls)
                {
                    child.DoubleClick += navigateToNovel;
                }

                panel.Controls.Add(card);
            }
        }

        private void SimilarUsersPanel_SizeChanged(object sender, EventArgs e)
        {
            int cardWidth = similarUsersPanel.Width - SystemInformation.VerticalScrollBarWidth;
            foreach (Control control in similarUsersPanel.Controls)
            {
                control.Width = cardWidth;
            }
        }

        private void NewestAdditionsPanel_SizeChanged(object sender, EventArgs e)
        {
            int cardWidth = newestAdditionsPanel.Width - SystemInformation.VerticalScrollBarWidth;
            foreach (Control control in newestAdditionsPanel.Controls)
            {
                control.Width = cardWidth;
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

            string[] lines = UxLastReadListBox.Items[e.Index].ToString().Split('\n');
            int width = UxLastReadListBox.ClientSize.Width - 4;
            int totalHeight = 4;

            foreach (string line in lines)
            {
                Size size = TextRenderer.MeasureText(line, UxLastReadListBox.Font,
                    new Size(width, int.MaxValue),
                    TextFormatFlags.WordBreak);
                totalHeight += size.Height;
            }

            e.ItemHeight = totalHeight;
        }

        private void UxLastReadListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();

            string[] lines = UxLastReadListBox.Items[e.Index].ToString().Split('\n');
            int width = e.Bounds.Width - 4;
            int y = e.Bounds.Y + 2;

            foreach (string line in lines)
            {
                Size size = TextRenderer.MeasureText(line, e.Font,
                    new Size(width, int.MaxValue),
                    TextFormatFlags.WordBreak);

                Rectangle lineBounds = new Rectangle(e.Bounds.X + 2, y, width, size.Height);
                TextRenderer.DrawText(e.Graphics, line, e.Font, lineBounds, e.ForeColor,
                    TextFormatFlags.WordBreak);

                y += size.Height;
            }

            e.DrawFocusRectangle();
        }

    }
}

