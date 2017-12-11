using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WSauce.Desktop.Helpers;
using WSauce.Desktop.Views.Settings;
using WSauce.Desktop.Views.Home;
using WSauce.Desktop.Views.Account;

namespace WSauce.Desktop.ViewModels
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            DemoItems = new[]
            {
                new DemoItem("Home", new Home(), "Home"),
                new DemoItem("Settings", new Settings(), "Settings"),
                new DemoItem("Logout", new Account(), "Power")
            };
        }

        public DemoItem[] DemoItems { get; }
    }

    public class DemoItem : INotifyPropertyChanged
    {
        private string _name;
        private string _iconKind;
        private object _content;
        private ScrollBarVisibility _horizontalScrollBarVisibilityRequirement;
        private ScrollBarVisibility _verticalScrollBarVisibilityRequirement;
        private Thickness _marginRequirement = new Thickness(16);

        public DemoItem(string name, object content, string iconKind)
        {
            _name = name;
            _iconKind = iconKind;
            Content = content;
        }

        public string Name
        {
            get { return _name; }
            set { this.MutateVerbose(ref _name, value, RaisePropertyChanged()); }
        }

        public string IconKind
        {
            get { return _iconKind; }
            set { this.MutateVerbose(ref _iconKind, value, RaisePropertyChanged()); }
        }

        public object Content
        {
            get { return _content; }
            set { this.MutateVerbose(ref _content, value, RaisePropertyChanged()); }
        }

        public ScrollBarVisibility HorizontalScrollBarVisibilityRequirement
        {
            get { return _horizontalScrollBarVisibilityRequirement; }
            set { this.MutateVerbose(ref _horizontalScrollBarVisibilityRequirement, value, RaisePropertyChanged()); }
        }

        public ScrollBarVisibility VerticalScrollBarVisibilityRequirement
        {
            get { return _verticalScrollBarVisibilityRequirement; }
            set { this.MutateVerbose(ref _verticalScrollBarVisibilityRequirement, value, RaisePropertyChanged()); }
        }

        public Thickness MarginRequirement
        {
            get { return _marginRequirement; }
            set { this.MutateVerbose(ref _marginRequirement, value, RaisePropertyChanged()); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private Action<PropertyChangedEventArgs> RaisePropertyChanged()
        {
            return args => PropertyChanged?.Invoke(this, args);
        }
    }

}
