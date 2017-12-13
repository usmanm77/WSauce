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
                    Categories = new ObservableCollection<CategoriesViewModel>
                {
                    new CategoriesViewModel { Categories = "Food", Background = maroonBrush },
                    new CategoriesViewModel { Categories = "Swallow", Background = greenBrush },
                    new CategoriesViewModel { Categories = "Drinks", Background = blackBrush },
                    new CategoriesViewModel { Categories = "Cocktails", Background = blueBrush },
                    new CategoriesViewModel { Categories = "Chips", Background = redBrush },
                    new CategoriesViewModel { Categories = "Shawarma", Background = purpleBrush },
                }
                };
            }
        }
    }
}
