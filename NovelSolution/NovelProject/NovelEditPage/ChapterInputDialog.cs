using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovelProject.NovelEditPage
{
    public partial class ChapterInputDialog : Form
    {

        public string TitleText => uxTitleTextBox.Text;
        public string FilePath => uxFileTextBox.Text;


        private int _novelID;
        private int _chapterNum;
        private bool _needsFile;
        public ChapterInputDialog(int novelID, int chapterNum, string prefilledTitle = "", bool needsFile = true)
        {
            InitializeComponent();
            _novelID = novelID;
            _chapterNum = chapterNum;
            _needsFile = needsFile;
            uxTitleTextBox.Text = prefilledTitle;
        }

        private void BrowseButtonClick(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            openFileDialog1.Title = "Select a text file";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                uxFileTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(uxTitleTextBox.Text))
            {
                MessageBox.Show("Please enter a title");
                return;
            }

            if (_needsFile && string.IsNullOrWhiteSpace(uxFileTextBox.Text))
            {
                MessageBox.Show("Please select a file");
                return;
            }

            string baseDir = AppContext.BaseDirectory;
            string novelsFolder = Path.Combine(baseDir, "Novels");

            Directory.CreateDirectory(novelsFolder);

            string sourcePath = uxFileTextBox.Text;

            string destPath = Path.Combine(novelsFolder, _novelID + "_" + _chapterNum + ".txt");

            File.Copy(sourcePath, destPath, true);


            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
