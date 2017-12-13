using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSauce.Desktop.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private ObservableCollection<CategoriesViewModel> categories;

        public ObservableCollection<CategoriesViewModel> Categories
        {
            get { return categories; }
            set
            {
                if (categories != value)
                {
                    categories = value;
                    NotifyPropertyChanged("Categories");
                }
            }
        }

        private ObservableCollection<CartItemViewModel> cartItems;

        public ObservableCollection<CartItemViewModel> CartItems
        {
            get { return cartItems; }
            set
            {
                if (cartItems != value)
                {
                    cartItems = value;
                    NotifyPropertyChanged("CartItems");
                }
            }
        }

        private ObservableCollection<CategoriesViewModel> menuItems;

        public ObservableCollection<CategoriesViewModel> MenuItems
        {
            get { return menuItems; }
            set
            {
                if (menuItems != value)
                {
                    menuItems = value;
                    NotifyPropertyChanged("MenuItems");
                }
            }
        }
    }
}
