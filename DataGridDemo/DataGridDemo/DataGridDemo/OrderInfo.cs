using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace DataGridDemo
{
    public class OrderInfo : INotifyPropertyChanged
    {
        private int? orderID;
        private string customerID;
        private string customer;
        private string shipCity;
        private string shipCountry;
        private bool isChecked;
        private CustomerInfo customersinfo;

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(String Name)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(Name));
        }

        public int? OrderID
        {
            get { return orderID; }
            set { this.orderID = value; RaisePropertyChanged("OrderID"); }
        }

        public string CustomerID
        {
            get { return customerID; }
            set { this.customerID = value; RaisePropertyChanged("CustomerID"); }
        }

        public string ShipCountry
        {
            get { return shipCountry; }
            set { this.shipCountry = value; RaisePropertyChanged("ShipCountry"); }
        }

        public string Customer
        {
            get { return this.customer; }
            set { this.customer = value; RaisePropertyChanged("Customer"); }
        }

        public string ShipCity
        {
            get { return shipCity; }
            set { this.shipCity = value; RaisePropertyChanged("ShipCity"); }
        }

        public bool IsChecked
        {
            get { return isChecked; }
            set { this.isChecked = value; RaisePropertyChanged("IsChecked"); }
        }

        public ImageSource GetImage
        {
            get { return ImageSource.FromResource("SfGridSample.Image2.png"); }
        }

        public CustomerInfo CustomersInfo
        {
            get { return customersinfo; }
            set { this.customersinfo = value;
                
                this.CustomersInfo.PropertyChanged += CustomersInfo_PropertyChanged;
            }
        }

        private void CustomersInfo_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            RaisePropertyChanged("CustomersInfo." + e.PropertyName);
        }

        public OrderInfo(int? orderId, string customerId, string country, string customer, string shipCity, bool isChecked, CustomerInfo customersinfo)
        {
            this.OrderID = orderId;
            this.CustomerID = customerId;
            this.Customer = customer;
            this.ShipCountry = country;
            this.ShipCity = shipCity;
            this.IsChecked = isChecked;
            this.CustomersInfo = customersinfo;
        }

        public OrderInfo()
        {
        }
    }

    public class CustomerInfo : NotificationObject
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get { return firstName; }
            set { this.firstName = value;
                RaisePropertyChanged("FirstName"); }
        }

        public string LastName
        {
            get { return lastName; }
            set { this.lastName = value; RaisePropertyChanged("LastName"); }
        }

    }
}





































































