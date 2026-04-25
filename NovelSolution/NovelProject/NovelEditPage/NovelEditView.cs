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
        public NovelEditHandler handler;
        private Action<UserControl> _navagate;
        Novel _novel = null;
        private bool _isNew = false;
        private bool _saved = false;
        private readonly ToolTip _tagToolTip = new ToolTip();
        private int _lastHoveredTagIndex = -1;

        public NovelEditView()
        {
            InitializeComponent();
            SetupListView();
            SetupTagTooltips();
            WireValidationEvents();
            authorCheckBox.Checked = false;
            authorTextBox.Enabled = false;
            authorTextBox.Visible = false;
            _novel = new Novel()
            {
                AuthorName = EnvironmentVars.username,
                NovelName = "a2a9242b-8064-4f37-9d52-03d1b8710199_Test-Novel",
                Description = "6c743292-2e78-42f9-acb9-0ebf11395f33"
            };
            _isNew = true;
            ValidateSaveButton();
            this.Load += (s, e) => handler(NovelEditState.CreateNovel, _novel, null, null, null, null);
            this.ParentChanged += (s, e) =>
            {
                if (_isNew && !_saved && Parent == null && _novel?.NovelId > 0)
                    handler(NovelEditState.DeleteNovel, _novel, null, null, null, null);
            };
        }

        public NovelEditView(Novel novel)
        {
            InitializeComponent();
            SetupListView();
            SetupTagTooltips();
            WireValidationEvents();
            authorCheckBox.Checked = false;
            authorTextBox.Enabled = false;
            authorTextBox.Visible = false;
            _novel = novel;

            uxTitleTextBox.Text = novel.NovelName;
            uxDescriptionBox.Text = novel.Description;

            ValidateSaveButton();
            PopulateBoxes(novel.NovelId);
        }


        public void SetNavigator(Action<UserControl> navigate)
        {
            _navagate = navigate;
        }

        public void SetNovelEditHandler(NovelEditHandler handler)
        {
            this.handler = handler;
        }

        public void DisplayState(NovelEditState s, Novel novel, Chapter chapter)
        {
            switch (s)
            {
                case NovelEditState.NovelCreated:
                    _novel = novel;
                    PopulateAllTagsAsAvailable();
                    break;
                case NovelEditState.ChapterSaved:
                    var savedItem = new ListViewItem(chapter.ChapterNumber.ToString());
                    savedItem.SubItems.Add(chapter.ChapterName);
                    savedItem.SubItems.Add(chapter.DateAdded.ToString());
                    savedItem.Tag = chapter;
                    uxChapterList.Items.Add(savedItem);
                    break;
                case NovelEditState.ChapterEdited:
                    foreach (ListViewItem item in uxChapterList.Items)
                    {
                        if (item.Tag is Chapter c && c.ChapterId == chapter.ChapterId)
                        {
                            item.Tag = chapter;
                            item.SubItems[0].Text = chapter.ChapterNumber.ToString();
                            item.SubItems[1].Text = chapter.ChapterName;
                            item.SubItems[2].Text = chapter.DateAdded.ToString();
                            break;
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void WireValidationEvents()
        {
            uxTitleTextBox.TextChanged += (s, e) => ValidateSaveButton();
            uxDescriptionBox.TextChanged += (s, e) => ValidateSaveButton();
            authorTextBox.TextChanged += (s, e) => ValidateSaveButton();
        }

        private void ValidateSaveButton()
        {
            bool titleFilled = !string.IsNullOrWhiteSpace(uxTitleTextBox.Text);
            bool descriptionFilled = !string.IsNullOrWhiteSpace(uxDescriptionBox.Text);
            bool authorValid = !authorCheckBox.Checked || !string.IsNullOrWhiteSpace(authorTextBox.Text);

            uxSaveExitButton.Enabled = titleFilled && descriptionFilled && authorValid;
        }

        private void SetupTagTooltips()
        {
            _tagToolTip.InitialDelay = 400;
            _tagToolTip.ReshowDelay = 200;
            _tagToolTip.AutoPopDelay = 5000;

            uxTagsToAddBox.MouseMove += TagListBox_MouseMove;
            uxTagsToAddBox.MouseLeave += TagListBox_MouseLeave;
            uxTagsBox.MouseMove += TagListBox_MouseMove;
            uxTagsBox.MouseLeave += TagListBox_MouseLeave;
        }

        private void TagListBox_MouseMove(object sender, MouseEventArgs e)
        {
            var listBox = (ListBox)sender;
            int index = listBox.IndexFromPoint(e.Location);

            if (index == _lastHoveredTagIndex)
                return;

            _lastHoveredTagIndex = index;

            if (index != ListBox.NoMatches && listBox.Items[index] is Tag tag)
            {
                _tagToolTip.Show(tag.TagDescription ?? string.Empty, listBox, e.X + 15, e.Y + 10);
            }
            else
            {
                _tagToolTip.Hide(listBox);
            }
        }

        private void TagListBox_MouseLeave(object sender, EventArgs e)
        {
            _tagToolTip.Hide((ListBox)sender);
            _lastHoveredTagIndex = -1;
        }

        private Tag ReadTag(System.Data.Common.DbDataReader reader)
        {
            return new Tag
            {
                TagId = reader.GetInt32(0),
                TagName = reader.GetString(1),
                TagDescription = reader.IsDBNull(2) ? string.Empty : reader.GetString(2)
            };
        }

        private void PopulateBoxes(int novelId)
        {
            string currentTagsQuery = $@"
                SELECT Tags.TagId, TagName, TagDescription FROM Tags
                JOIN NovelTags ON Tags.TagId = NovelTags.TagId
                WHERE NovelTags.NovelId = {novelId}
                ORDER BY TagName ASC
            ";

            using (var reader = DatabaseHelper.ExecuteReader(currentTagsQuery))
            {
                while (reader.Read())
                {
                    uxTagsBox.Items.Add(ReadTag(reader));
                }
            }

            string availableTagsQuery = $@"
                SELECT TagId, TagName, TagDescription FROM Tags
                WHERE TagId NOT IN (
                    SELECT TagId FROM NovelTags WHERE NovelId = {novelId}
                )
                ORDER BY TagName ASC
            ";

            using (var reader = DatabaseHelper.ExecuteReader(availableTagsQuery))
            {
                while (reader.Read())
                {
                    uxTagsToAddBox.Items.Add(ReadTag(reader));
                }
            }

            string chaptersQuery = $@"
                SELECT ChapterId, NovelId, ChapterNumber, ChapterName, DateAdded FROM Chapters
                WHERE NovelId = {novelId}
                ORDER BY ChapterNumber
            ";

            using (var reader = DatabaseHelper.ExecuteReader(chaptersQuery))
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
                    item.Tag = chapter;
                    uxChapterList.Items.Add(item);
                }
            }
        }

        private void PopulateAllTagsAsAvailable()
        {
            uxTagsToAddBox.Items.Clear();

            using (var reader = DatabaseHelper.ExecuteReader("SELECT TagId, TagName, TagDescription FROM Tags"))
            {
                while (reader.Read())
                {
                    uxTagsToAddBox.Items.Add(ReadTag(reader));
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
            _saved = true;
            _novel.NovelName = uxTitleTextBox.Text;
            _novel.Description = uxDescriptionBox.Text;
            _novel.AuthorName = authorCheckBox.Checked ? authorTextBox.Text : EnvironmentVars.username;

            handler(NovelEditState.UpdateNovel, _novel, null, null, uxTagsBox.Items, uxChapterList.Items);

            var view = new AuthorPage.AuthorView();
            var authorController = new AuthorPage.AuthorController(view.DisplayState);
            view.SetAuthorHandler(authorController.HandleEvents);
            _navagate.Invoke(view);
        }

        private void AddTagButtonClick(object sender, EventArgs e)
        {
            if (uxTagsToAddBox.SelectedItem is not Tag tag)
                return;

            uxTagsToAddBox.Items.Remove(tag);
            uxTagsBox.Items.Add(tag);
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            if (uxTagsBox.SelectedItem is not Tag tag)
                return;

            uxTagsBox.Items.Remove(tag);
            uxTagsToAddBox.Items.Add(tag);
        }

        private void AddChapterButtonClick(object sender, EventArgs e)
        {
            var dialog = new ChapterInputDialog(_novel.NovelId, uxChapterList.Items.Count + 1, needsFile: true);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string title = dialog.TitleText;
                handler(NovelEditState.SaveChapter, _novel, null, title, null, uxChapterList.Items);
            }
        }

        private void EditChapterButtonClick(object sender, EventArgs e)
        {
            var dialog = new ChapterInputDialog(_novel.NovelId, uxChapterList.Items.Count + 1, needsFile: false);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string title = dialog.TitleText;
                Chapter selectedChapter = (Chapter)uxChapterList.SelectedItems[0].Tag;
                handler(NovelEditState.EditChapter, null, selectedChapter, title, null, null);
            }
        }

        private void UpButtonClick(object sender, EventArgs e)
        {
            if (uxChapterList.SelectedIndices.Count == 0)
                return;

            int index = uxChapterList.SelectedIndices[0];

            if (index <= 0)
                return;

            SwapChapters(index, index - 1);

            uxChapterList.Items[index - 1].Selected = true;
            uxChapterList.Focus();
        }

        private void DownButtonClick(object sender, EventArgs e)
        {
            if (uxChapterList.SelectedIndices.Count == 0)
                return;

            int index = uxChapterList.SelectedIndices[0];

            if (index >= uxChapterList.Items.Count - 1)
                return;

            SwapChapters(index, index + 1);

            uxChapterList.Items[index + 1].Selected = true;
            uxChapterList.Focus();
        }

        private void SwapChapters(int indexA, int indexB)
        {
            var itemA = uxChapterList.Items[indexA];
            var itemB = uxChapterList.Items[indexB];

            var tempTag = itemA.Tag;
            itemA.Tag = itemB.Tag;
            itemB.Tag = tempTag;

            Chapter chaptera = (Chapter)itemA.Tag;
            Chapter chapterb = (Chapter)itemB.Tag;

            int tempNumber = chaptera.ChapterNumber;
            chaptera.ChapterNumber = chapterb.ChapterNumber;
            chapterb.ChapterNumber = tempNumber;

            itemA.Tag = chaptera;
            itemB.Tag = chapterb;

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
                    item.SubItems[0].Text = number.ToString();
                    number++;
                }
            }
        }

        private void ChapterDeleteClick(object sender, EventArgs e)
        {
            if (uxChapterList.SelectedIndices.Count == 0)
                return;

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

        private void authorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            authorTextBox.Enabled = authorCheckBox.Checked;
            authorTextBox.Visible = authorCheckBox.Checked;
            ValidateSaveButton();
        }
    }
}
