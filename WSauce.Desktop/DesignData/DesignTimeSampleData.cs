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
                var maroonBrush = new SolidColorBrush(Colors.Maroon);
                var greenBrush = new SolidColorBrush(Colors.DarkGreen);
                var blueBrush = new SolidColorBrush(Colors.DarkBlue);
                var blackBrush = new SolidColorBrush(Colors.Black);
                var redBrush = new SolidColorBrush(Colors.Red);
                var purpleBrush = new SolidColorBrush(Colors.MediumPurple);

                //var maroonBrush = App.Current.Resources["PrimaryHueDarkBrush"] as SolidColorBrush;
                //var greenBrush = App.Current.Resources["PrimaryHueDarkBrush"] as SolidColorBrush;
                //var blueBrush = App.Current.Resources["PrimaryHueDarkBrush"] as SolidColorBrush;
                //var blackBrush = App.Current.Resources["PrimaryHueDarkBrush"] as SolidColorBrush;
                //var redBrush = App.Current.Resources["PrimaryHueDarkBrush"] as SolidColorBrush;
                //var purpleBrush = App.Current.Resources["PrimaryHueDarkBrush"] as SolidColorBrush;

                return new HomeViewModel
                {
                    Categories = new ObservableCollection<CategoriesViewModel>
                    {
                        new CategoriesViewModel { Description = "Main Course", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Sauces", Background = greenBrush },
                        new CategoriesViewModel { Description = "Bites", Background = blackBrush },
                        new CategoriesViewModel { Description = "Snarks", Background = blueBrush },
                        new CategoriesViewModel { Description = "Extra Dips", Background = redBrush },
                        new CategoriesViewModel { Description = "Sides", Background = purpleBrush },
                        new CategoriesViewModel { Description = "Drinks", Background = purpleBrush },
                    },
                    MenuItems = new ObservableCollection<CategoriesViewModel>
                    {
                        new CategoriesViewModel { Description = "Fried Rice", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Jollof Rice", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Breans Porridge", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Boiled Yam", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Grilled Potatoes", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Meat Balls in Tomato & Curry Sauce", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Beef Steak", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Grilled Cube Chicken Sauce", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Chicken Steak", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Kebab", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Crispy Chicken", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Hot & Spicy Chicken", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Crispy Wings", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Hot & Spicy Wings", Background = maroonBrush },
                        new CategoriesViewModel { Description = "BBQ Wings", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Seseme Wings", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Chicken Nugget", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Pizza", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Scotch Egg", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Sausage Roll", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Chicken Fingers", Background = maroonBrush },
                        new CategoriesViewModel { Description = "G-M", Background = maroonBrush },
                        new CategoriesViewModel { Description = "K-P", Background = maroonBrush },
                        new CategoriesViewModel { Description = "BBQ", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Vallo", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Cole Slaw", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Kebab", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Plantain", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Sprite", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Fanta", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Coke", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Chapman", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Rabina", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Lemonade", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Zobbo", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Ginger", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Youghurt", Background = maroonBrush },
                        new CategoriesViewModel { Description = "Fura", Background = maroonBrush },
                    },
                    CartItems = new ObservableCollection<CartItemViewModel>
                    {
                        new CartItemViewModel { ProductName = "Shawarma with Extra Chicken Strips", Description = "Shawarma with Extra Chicken Strips", Quantity = 2, UnitPrice = 350 }
                    }
                };
            }
        }
    }
}
