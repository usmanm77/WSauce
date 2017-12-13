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

        public SolidColorBrush Background { get; internal set; }
    }
}
