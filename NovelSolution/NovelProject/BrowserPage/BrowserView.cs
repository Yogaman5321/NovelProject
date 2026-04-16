using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
public enum BrowserState
{
    Default,
    Popular,
    New, 
    Random,
    HigestRating,
    TagChanged, 
    Recommended
    
}
namespace NovelProject.BrowserPage
{
    public partial class BrowserView : UserControl
    {
        //some type of table to hold sql database for novels. 
        public BrowserView(BrowserStateHandler stateHandler)
        {
            handler = stateHandler;
            InitializeComponent();
            LoadNovels();
            UXSearchBarTB.KeyDown += Searchbox_Enter;

            
        }

        private BrowserStateHandler handler;

        private string Tag { get; set; } = "all tags";


        private void LoadNovels()
        {
            /* Logic to load novels from the database and display them in the view\
             * Foreach novel in database till count of novels is equal to 10
             * Create a novel card for each novel and add it to the listbox as a button that can be clicked on to open the novel page 
             */
        }

        private void Search()
        {
            //search button click
        }

        private void Searchbox_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //bool temp = Search();

                //if(!temp)
                //{
                //    MessageBox.Show("Invalid Entry.");
                //}
            }
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (FilterComboBox.SelectedItem.ToString())
            {
                case "Most Read":
                    handler(BrowserState.Popular);
                    break;
                case "Newest Releases":
                    handler(BrowserState.New);
                    break;
                case "Random Display":
                    handler(BrowserState.Random);
                    break;
                case "Highest Rating":
                    handler(BrowserState.HigestRating);
                    break;
                case "Recommended For You":
                    handler(BrowserState.Recommended);
                    break;
            }
        }

        private void TagComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sender is ComboBox comboBox)
            {
                Tag = comboBox.SelectedItem.ToString();
            }
        }

        private void UxIncludeTagCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox && checkBox.Checked)
            {
                UxSearchLabel.Text = "Including In Search: ";
            }
            else
            {
                UxSearchLabel.Text = "Excluding From Search: ";
            }
        }
    }
}
