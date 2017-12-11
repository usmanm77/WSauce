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
        private ObservableCollection<MenuItemViewModel> menuItems;

        public ObservableCollection<MenuItemViewModel> MenuItems
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
