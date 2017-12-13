using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WSauce.Desktop.ViewModels
{
    public class MenuItemViewModel : ViewModelBase
    {
        private string title;

        public string Title
        {
            get { return title.ToUpper(); }
            set
            {
                if (title != value)
                {
                    title = value;
                    NotifyPropertyChanged("Title");
                }
            }
        }

        public SolidColorBrush Background { get; internal set; }
    }
}
