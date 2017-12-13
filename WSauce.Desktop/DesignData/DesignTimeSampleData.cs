using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using WSauce.Desktop.ViewModels;

namespace WSauce.Desktop.DesignData
{
    public static class DesignTimeSampleData
    {

        public static HomeViewModel HomeSampleData
        {

            get
            {
                var maroonBrush = new SolidColorBrush(Color.FromRgb(119, 0, 0));
                var greenBrush = new SolidColorBrush(Color.FromRgb(0, 119, 42));
                var blueBrush = new SolidColorBrush(Color.FromRgb(0, 79, 210));
                var blackBrush = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                var redBrush = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                var purpleBrush = new SolidColorBrush(Color.FromRgb(121, 0, 178));

                return new HomeViewModel
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
}
