using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public enum HomePageState
{
    Default, 
    LoadRecentNovels, 


}
namespace NovelProject.HomePage
{
    public class HomeController
    {
        public HomeController()
        {

        }

        public void handler(HomePageState state)
        {
            switch (state)
            {
                case HomePageState.Default:
                    //load most recent novels from database using read history of the user and add them to the view, up to 10 novels loaded at once. Include last read time and novel title in the view.
                    //load all tags from database using private method GenerateTags() and add them to the combo box in the view
                    break;
                case HomePageState.LoadRecentNovels:
                    //load most recent novels from database using read history of the user and add them to the view, up to 10 novels loaded at once. Include last read time and novel title in the view.
                    break;
            }
        }   
    }
}
