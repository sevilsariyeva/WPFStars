using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using WPFStars.Commands;

namespace WPFStars.ViewModels
{
    public class MainViewModel:BaseViewModel
    {
        private Button button;

        public Button MyButton
        {
            get { return button; }
            set { button = value; }
        }

        public RelayCommand ClickCommand { get; set; }

        public MainViewModel()
        {
            ClickCommand = new RelayCommand((obj) =>
            {
                var item = obj as Button;
                
                    MyButton = item;
                    //var temp = item.Content as System.Windows.Shapes.Path;
                    SolidColorBrush brush = new SolidColorBrush();
                    brush.Color = Color.FromRgb(229, 222, 0);
                    MyButton.Content = brush;
               
                //temp.Fill = brush;
                //item.Content = brush;
            });
        }
    }
}
