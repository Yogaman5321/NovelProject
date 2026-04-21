using NovelProject.AuthorPage;
using NovelProject.Models;
using NovelProject.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NovelProject.NovelEditPage
{
    public partial class NovelEditView : UserControl, INavigatable
    {

        NovelEditController controller = new NovelEditController();
        public NovelEditView()
        {
            InitializeComponent();
            SetupListView();
            _novel = new Novel()
            {
                AuthorName = EnvironmentVars.username,
                NovelName = "a2a9242b-8064-4f37-9d52-03d1b8710199_Test-Novel",
                Description = "6c743292-2e78-42f9-acb9-0ebf11395f33"
            };
            _novel = controller.CreateNovel(_novel);
        }

        Novel _novel = null;
        public NovelEditView(Novel novel)
        {
            InitializeComponent();
            SetupListView();
            _novel = novel;

            uxTitleTextBox.Text = novel.NovelName;
            uxDescriptionBox.Text = novel.Description;

            PopulateBoxes(novel.NovelId);
        }

        private void PopulateBoxes(int novelId)
        {

            string query = $@"
                    SELECT TagName FROM Tags
                    join NovelTags on Tags.TagId = NovelTags.TagId
                    WHERE NovelTags.NovelId = {novelId}
                    ";

            using (var reader = DatabaseHelper.ExecuteReader(query))
            {
                while (reader.Read())
                {

                    string TagName = reader.GetString(0);
                    uxTagsBox.Items.Add(TagName);

                }
            }

            query = $@"
                    SELECT ChapterId, NovelId, ChapterNumber, ChapterName, DateAdded FROM Chapters
                    WHERE NovelId = {novelId}
                    ORDER BY ChapterNumber
                    ";

            using (var reader = DatabaseHelper.ExecuteReader(query))
            {
                while (reader.Read())
                {
                    var chapter = new Chapter
                    {
                        ChapterId = reader.GetInt32(0),
                        NovelId = reader.GetInt32(1),
                        ChapterNumber = reader.GetInt32(2),
                        ChapterName = reader.GetString(3),
                        DateAdded = reader.GetDateTime(4)
                    };

                    Debug.WriteLine($"Retrieved chapter: {chapter.ChapterName} by {chapter.ChapterId}");


                    var item = new ListViewItem(chapter.ChapterNumber.ToString());

                    item.SubItems.Add(chapter.ChapterName);
                    item.SubItems.Add(chapter.DateAdded.ToString());

                    item.Tag = chapter; // for later retrieval

                    uxChapterList.Items.Add(item);
                }
            }
        }


        private void SetupListView()
        {
            uxChapterList.View = View.Details;
            uxChapterList.FullRowSelect = true;

            uxChapterList.Columns.Add("Chapter Number", 50);
            uxChapterList.Columns.Add("Chapter Title", 200);
            uxChapterList.Columns.Add("Date Added", 100);
        }

        private void SaveExitButtonClick(object sender, EventArgs e)
        {

            _novel.NovelName = uxTitleTextBox.Text;
            _novel.Description = uxDescriptionBox.Text;

            controller.updateNovel(_novel, uxTagsBox.Items, uxChapterList.Items);

            _navagate.Invoke(new AuthorView());
        }

        private void AddTagButtonClick(object sender, EventArgs e)
        {
            string text = uxTagTexbox.Text;
            if (!uxTagsBox.Items.Contains(text))
            {
                uxTagTexbox.Text = "";
                controller.addTag(text, "change me");
                uxTagsBox.Items.Add(text);
            }
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            string text = uxTagsBox.SelectedItem.ToString();
            uxTagsBox.Items.Remove(text);

            DatabaseHelper.ExecuteNonQuery($"DELETE FROM NovelTags WHERE NovelId = {_novel.NovelId} AND TagId = (SELECT TagId FROM Tags WHERE TagName = '{text}')");
        }

        private void AddChapterButtonClick(object sender, EventArgs e)
        {
            var dialog = new ChapterInputDialog(_novel.NovelId, uxChapterList.Items.Count + 1, needsFile: true);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string title = dialog.TitleText;
                Chapter chapter = controller.SaveChapter(_novel.NovelId, title, uxChapterList.Items.Count + 1);

                var item = new ListViewItem(chapter.ChapterNumber.ToString());

                item.SubItems.Add(chapter.ChapterName);
                item.SubItems.Add(chapter.DateAdded.ToString());

                item.Tag = chapter; // for later retrieval

                uxChapterList.Items.Add(item);
            }
        }

        private void EditChapterButtonClick(object sender, EventArgs e)
        {
            var dialog = new ChapterInputDialog(_novel.NovelId, uxChapterList.Items.Count + 1, needsFile: false);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string title = dialog.TitleText;
                Chapter selectedChapter = (Chapter)uxChapterList.SelectedItems[0].Tag;
                Chapter chapter = controller.EditChapter(selectedChapter, title);

                foreach (ListViewItem item in uxChapterList.Items)
                {
                    if (item.Tag is Chapter c && c.ChapterId == chapter.ChapterId)
                    {
                        // update tag
                        item.Tag = chapter;

                        // update visible columns
                        item.SubItems[0].Text = chapter.ChapterNumber.ToString();
                        item.SubItems[1].Text = chapter.ChapterName;
                        item.SubItems[2].Text = chapter.DateAdded.ToString();

                        break;
                    }
                }
            }
        }

        private Action<UserControl> _navagate;
        public void SetNavigator(Action<UserControl> navigate)
        {
            _navagate = navigate;
        }

        private void UpButtonClick(object sender, EventArgs e)
        {
            if (uxChapterList.SelectedIndices.Count == 0)
            {
                return;
            }

            int index = uxChapterList.SelectedIndices[0];

            if (index <= 0)
            {
                return;
            }

            SwapChapters(index, index - 1);

            uxChapterList.Items[index - 1].Selected = true;
            uxChapterList.Focus();
        }

        private void DownButtonClick(object sender, EventArgs e)
        {
            if (uxChapterList.SelectedIndices.Count == 0)
            {
                return;
            }

            int index = uxChapterList.SelectedIndices[0];

            if (index >= uxChapterList.Items.Count - 1)
            {
                return;
            }

            SwapChapters(index, index + 1);

            uxChapterList.Items[index + 1].Selected = true;
            uxChapterList.Focus();
        }

        private void SwapChapters(int indexA, int indexB)
        {
            var itemA = uxChapterList.Items[indexA];
            var itemB = uxChapterList.Items[indexB];

            // swap Tag data first (important)
            var tempTag = itemA.Tag;
            itemA.Tag = itemB.Tag;
            itemB.Tag = tempTag;

            Chapter chaptera = (Chapter)itemA.Tag;
            Chapter chapterb = (Chapter)itemB.Tag;

            // swap chapter numbers to reflect new order
            int tempNumber = chaptera.ChapterNumber;
            chaptera.ChapterNumber = chapterb.ChapterNumber;
            chapterb.ChapterNumber = tempNumber;

            itemA.Tag = chaptera;
            itemB.Tag = chapterb;

            // swap displayed values
            for (int i = 0; i < itemA.SubItems.Count; i++)
            {
                var temp = itemA.SubItems[i].Text;
                itemA.SubItems[i].Text = itemB.SubItems[i].Text;
                itemB.SubItems[i].Text = temp;
            }

            RenumberChapters();
        }

        private void RenumberChapters()
        {
            int number = 1;

            foreach (ListViewItem item in uxChapterList.Items)
            {
                if (item.Tag is Chapter chapter)
                {
                    chapter.ChapterNumber = number;

                    // update UI column
                    item.SubItems[0].Text = number.ToString();

                    number++;
                }
            }
        }

        private void ChapterDeleteClick(object sender, EventArgs e)
        {
            if (uxChapterList.SelectedIndices.Count == 0)
            {
                return;
            }

            var result = MessageBox.Show(
                "Are you sure you want to delete this item?",
                "Confirm Delete",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.OK)
            {
                int index = uxChapterList.SelectedIndices[0];
                uxChapterList.Items.RemoveAt(index);

                RenumberChapters();
            }
        }
    }
}
