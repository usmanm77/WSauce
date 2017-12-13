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
    }
}
