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
                //var maroonBrush = new SolidColorBrush(Colors.Maroon);
                //var greenBrush = new SolidColorBrush(Colors.DarkGreen);
                //var blueBrush = new SolidColorBrush(Colors.DarkBlue);
                //var blackBrush = new SolidColorBrush(Colors.Black);
                //var redBrush = new SolidColorBrush(Colors.Red);
                //var purpleBrush = new SolidColorBrush(Colors.MediumPurple);

                var maroonBrush = App.Current.Resources["PrimaryHueDarkBrush"] as SolidColorBrush;
                var greenBrush = App.Current.Resources["PrimaryHueDarkBrush"] as SolidColorBrush;
                var blueBrush = App.Current.Resources["PrimaryHueDarkBrush"] as SolidColorBrush;
                var blackBrush = App.Current.Resources["PrimaryHueDarkBrush"] as SolidColorBrush;
                var redBrush = App.Current.Resources["PrimaryHueDarkBrush"] as SolidColorBrush;
                var purpleBrush = App.Current.Resources["PrimaryHueDarkBrush"] as SolidColorBrush;

                return new HomeViewModel
                {
                    Categories = new ObservableCollection<CategoriesViewModel>
                    {
                        new CategoriesViewModel { Description = "Food", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Swallow", Background = greenBrush },
                        new CategoriesViewModel { Description = "Drinks", Background = blackBrush },
                        new CategoriesViewModel { Description = "Cocktails", Background = blueBrush },
                        new CategoriesViewModel { Description = "Chips", Background = redBrush },
                        new CategoriesViewModel { Description = "Shawarma", Background = purpleBrush },
                    },
                    MenuItems = new ObservableCollection<CategoriesViewModel>
                    {
                        new CategoriesViewModel { Description = "Food & Drinks and Food", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Swallow", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Drinks", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Cocktails", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Chips", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Shawarma", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Food", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Swallow", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Drinks", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Cocktails", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Chips", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Shawarma", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Food", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Swallow", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Drinks", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Cocktails", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Chips", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Shawarma", Background = maroonBrush },
                    },
                    CartItems = new ObservableCollection<CartItemViewModel>
                    {
                        new CartItemViewModel {ProductName = "Shawarma with Extra Chicken Strips", Description = "Shawarma with Extra Chicken Strips", Quantity = 2, UnitPrice = 350 }
                    }
                };
            }
        }
    }
}
