using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WSauce.Desktop.ViewModels
{
    public class CategoriesViewModel : ViewModelBase
    {
        private string catrgories;

        public string Categories
        {
            get { return catrgories.ToUpper(); }
            set
            {
                if (catrgories != value)
                {
                    catrgories = value;
                    NotifyPropertyChanged("Categories");
                }
            }
        }

        public SolidColorBrush Background { get; internal set; }
    }
}
