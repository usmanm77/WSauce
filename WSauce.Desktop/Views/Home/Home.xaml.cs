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
        private HomeViewModel homeViewModel;

        public Home()
        {
            InitializeComponent();

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

            DataContext = homeViewModel = new HomeViewModel
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
                        new CartItemViewModel {ProductName = "Shawarma with Extra Chicken Strips", Description = "Shawarma with Extra Chicken Strips", Quantity = 2, UnitPrice = 350 },
                        new CartItemViewModel {ProductName = "Extra Chicken Strips", Description = "Shawarma with Extra Chicken Strips", Quantity = 1, UnitPrice = 150 },
                        new CartItemViewModel {ProductName = "Extra Strips", Description = "Shawarma with Extra Chicken Strips", Quantity = 5, UnitPrice = 250 },
                        new CartItemViewModel {ProductName = "Shawarma Chicken Strips", Description = "Shawarma with Extra Chicken Strips", Quantity = 5, UnitPrice = 550 },
                        new CartItemViewModel {ProductName = "Shawarma with Chicken Strips", Description = "Shawarma with Extra Chicken Strips", Quantity = 1, UnitPrice = 250 },
                        new CartItemViewModel {ProductName = "Shawarma with Extra Chicken Strips", Description = "Shawarma with Extra Chicken Strips", Quantity = 1, UnitPrice = 550 },
                        new CartItemViewModel {ProductName = "Shawar Extra Chicken ", Description = "Shawarma with Extra Chicken Strips", Quantity = 4, UnitPrice = 150 }
                    }
            };
        }

        private void btnCategories_Click(object sender, RoutedEventArgs e)
        {
            var selectedCategory = homeViewModel.Categories
                .FirstOrDefault(f => f.Description == ((Button)sender).Content.ToString());

            foreach (var menuItem in homeViewModel.Categories.Where(f => f.Description != selectedCategory.Description))
                menuItem.Background = App.Current.Resources["PrimaryHueDarkBrush"] as SolidColorBrush;

            selectedCategory.Background = App.Current.Resources["PrimaryHueDarkBrush"] as SolidColorBrush;

            foreach (var menuItem in homeViewModel.MenuItems)
                menuItem.Background = selectedCategory.Background;
        }
    }
}
