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
        private string description;

        public string Description
        {
            get { return description.ToUpper(); }
            set
            {
                if (description != value)
                {
                    description = value;
                    NotifyPropertyChanged("Description");
                }
            }
        }

        private SolidColorBrush background;

        public SolidColorBrush Background
        {
            get { return background; }
            set
            {
                if (background != value)
                {
                    background = value;
                    NotifyPropertyChanged("Background");
                }
            }
        }
    }
}
