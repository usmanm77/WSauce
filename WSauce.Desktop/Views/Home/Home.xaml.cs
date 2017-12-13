using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WSauce.Desktop.ViewModels;

namespace WSauce.Desktop.Views.Home
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();

            var maroonBrush = new SolidColorBrush(Color.FromRgb(119, 0, 0));
            var greenBrush = new SolidColorBrush(Color.FromRgb(0, 119, 42));
            var blueBrush = new SolidColorBrush(Color.FromRgb(0, 79, 210));
            var blackBrush = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            var redBrush = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            var purpleBrush = new SolidColorBrush(Color.FromRgb(121, 0, 178));

            DataContext = new HomeViewModel
            {
                MenuItems = new ObservableCollection<MenuItemViewModel>
                {
                    new MenuItemViewModel { Title = "Food", Background = maroonBrush },
                    new MenuItemViewModel { Title = "Swallow", Background = greenBrush },
                    new MenuItemViewModel { Title = "Drinks", Background = blackBrush },
                    new MenuItemViewModel { Title = "Cocktails", Background = blueBrush },
                    new MenuItemViewModel { Title = "Chips", Background = redBrush },
                    new MenuItemViewModel { Title = "Shawarma", Background = purpleBrush },
                }
            };
        }
    }
}
