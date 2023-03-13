using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WPFStars.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private Button button;

        public Button MyButton
        {
            get { return button; }
            set { button = value; }
        }       
    }
}
