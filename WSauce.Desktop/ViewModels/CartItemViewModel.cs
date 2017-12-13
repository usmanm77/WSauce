namespace WSauce.Desktop.ViewModels
{
    public class CartItemViewModel : ViewModelBase
    {
        private string productName;

        public string ProductName
        {
            get { return productName; }
            set
            {
                if (productName != value)
                {
                    productName = value;
                    NotifyPropertyChanged("ProductName");
                }
            }
        }


        private string description;

        public string Description
        {
            get { return description; }
            set
            {
                if (description != value)
                {
                    description = value;
                    NotifyPropertyChanged("Description");
                }
            }
        }

        private decimal unitPrice;

        public decimal UnitPrice
        {
            get { return unitPrice; }
            set
            {
                if (unitPrice != value)
                {
                    unitPrice = value;
                    NotifyPropertyChanged("UnitPrice");
                }
            }
        }

        public decimal TotalPrice
        {
            get { return unitPrice * quantity; }
        }

        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (quantity != value)
                {
                    quantity = value;
                    NotifyPropertyChanged("Quantity");
                }
            }
        }

    }
}