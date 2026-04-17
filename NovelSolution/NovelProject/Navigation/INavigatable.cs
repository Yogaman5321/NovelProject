using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovelProject.Navigation
{
    public interface INavigatable
    {
        void SetNavigator(Action<UserControl> navigate);
    }
}
