using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace DataGridDemo
{
    class OrderInfoRepository : NotificationObject
    {

        private ObservableCollection<OrderInfo> orderInfo;
        private int _pageSize;
        public ObservableCollection<OrderInfo> OrderInfoCollection
        {
            get { return orderInfo; }
            set { this.orderInfo = value; }
        }

        public int PageSize
        {
            get { return _pageSize; }
            set { this._pageSize = value; }
        }
        public OrderInfoRepository()
        {
            orderInfo = new ObservableCollection<OrderInfo>();
            PageSize = 20;
            this.GenerateOrders();
        }

        public void AddOrder()
        {
            orderInfo.Add(new OrderInfo(1001, "Maria Anders", "Mexico", "ANATR", "Mexico D.F.", true, new CustomerInfo() { FirstName = "Lin", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1002, "Ana Trujillo", "Mexico", "ANTON", "Mexico D.F.", true, new CustomerInfo() { FirstName = "Gina", LastName = "Robert" }));
        }

        private void GenerateOrders()
        {
            orderInfo.Add(new OrderInfo(1001, "Maria Anders", "Mexico", "ANATR", "Mexico D.F.", true, new CustomerInfo() { FirstName = "Lin", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1002, "Ana Trujillo", "Mexico", "ANTON", "Mexico D.F.", true, new CustomerInfo() { FirstName = "Gina", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1003, "Ant Fuller", "UK", "AROUT", "London", true, new CustomerInfo() { FirstName = "Torrey", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1004, "Thomas Hardy", "Sweden", "BERGS", "Berlin", true, new CustomerInfo() { FirstName = "Frank", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1005, "Lenny Lin", "Germany", "BLAUS", "Mannheim", true, new CustomerInfo() { FirstName = "Jennifer", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1006, "John Carter", "France", "BLONP", "Strasbourg", true, new CustomerInfo() { FirstName = "Fiona", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1007, "Laura King", "Spain", "BOLID", "Madrid", true, new CustomerInfo() { FirstName = "Vince", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1008, "Hanna Moos", "France", "BONAP", "Marseille", false, new CustomerInfo() { FirstName = "Kyle", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1009, "Lenny Lin", "Canada", "BOTTM", "Tsawassen", false, new CustomerInfo() { FirstName = "Gina", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1011, "John Carter", "Germany", "BLAUS", "Mannheim", false, new CustomerInfo() { FirstName = "Katie", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1012, "Tim Adams", "France", "BLONP", "Strasbourg", true, new CustomerInfo() { FirstName = "Michael", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1013, "Hanna Moos", "UK", "AROUT", "London", false, new CustomerInfo() { FirstName = "Oscar", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1014, "John Carter", "Germany", "ALFKI", "Berlin", true, new CustomerInfo() { FirstName = "Ralph", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1016, "Laura King", "Mexico", "ANTON", "Mexico D.F.", false, new CustomerInfo() { FirstName = "William", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1017, "Lenny Lin", "UK", "AROUT", "London", false, new CustomerInfo() { FirstName = "Bill", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1018, "Thomas Hardy", "Sweden", "BERGS", "Berlin", true, new CustomerInfo() { FirstName = "Daniel", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1019, "Lenny Lin", "Germany", "BLAUS", "Mannheim", true, new CustomerInfo() { FirstName = "Frank", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1020, "Gina Irene", "France", "BLONP", "Strasbourg", true, new CustomerInfo() { FirstName = "Danielle", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1021, "Laura King", "Spain", "BOLID", "Madrid", false, new CustomerInfo() { FirstName = "Fiona", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1022, "Anne Wilson", "France", "BONAP", "Marseille", true, new CustomerInfo() { FirstName = "Howard", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1023, "Lenny Lin", "Canada", "BOTTM", "Tsawassen", false, new CustomerInfo() { FirstName = "Jack", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1024, "Gina Irene", "UK", "AROUT", "London", true, new CustomerInfo() { FirstName = "Larry", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1025, "Thomas Hardy", "Germany", "BLAUS", "Mannheim", true, new CustomerInfo() { FirstName = "Holly", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1026, "Anne Wilson", "France", "BLONP", "Strasbourg", false, new CustomerInfo() { FirstName = "Jennifer", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1027, "Laura King", "UK", "AROUT", "London", true, new CustomerInfo() { FirstName = "Liz", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1028, "Anne Wilson", "France", "BLONP", "Strasbourg", true, new CustomerInfo() { FirstName = "Pete", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1029, "Gina Irene", "UK", "AROUT", "London", false, new CustomerInfo() { FirstName = "Steve", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1030, "Anne Wilson", "Germany", "ALFKI", "Berlin", false, new CustomerInfo() { FirstName = "Vince", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1031, "Tim Adams", "Mexico", "ANATR", "Mexico D.F.", true, new CustomerInfo() { FirstName = "Zeke", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1032, "Anne Wilson", "Mexico", "ANTON", "Mexico D.F.", true, new CustomerInfo() { FirstName = "William", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1033, "Gina Irene", "UK", "AROUT", "London", false, new CustomerInfo() { FirstName = "Daniel", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1034, "Ant Fuller", "Sweden", "BERGS", "Berlin", true, new CustomerInfo() { FirstName = "Katie", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1035, "Thomas Hardy", "Germany", "BLAUS", "Mannheim", false, new CustomerInfo() { FirstName = "Oscar", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1036, "Gina Irene", "France", "BLONP", "Strasbourg", true, new CustomerInfo() { FirstName = "Larry", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1037, "Hanna Moos", "Spain", "BOLID", "Madrid", false, new CustomerInfo() { FirstName = "Pete", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1038, "Anne Wilson", "France", "BONAP", "Marseille", false, new CustomerInfo() { FirstName = "Gina", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1039, "Thomas Hardy", "Canada", "BOTTM", "Tsawassen", true, new CustomerInfo() { FirstName = "Vince", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1040, "Tim Adams", "UK", "AROUT", "London", true, new CustomerInfo() { FirstName = "Liz", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1041, "Anne Wilson", "Germany", "BLAUS", "Mannheim", true, new CustomerInfo() { FirstName = "Daniel", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1042, "Thomas Hardy", "France", "BLONP", "Strasbourg", false, new CustomerInfo() { FirstName = "Torrey", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1043, "Hanna Moos", "UK", "AROUT", "London", true, new CustomerInfo() { FirstName = "Irene", LastName = "Robert" }));
            orderInfo.Add(new OrderInfo(1044, "John Carter", "Germany", "ALFKI", "Berlin", false, new CustomerInfo() { FirstName = "Bill", LastName = "Robert" }));
        }
    }

    public class NotificationObject : INotifyPropertyChanged
    {
        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    public class DisplayBindingConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
                return "Customer:" + value.ToString();
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
