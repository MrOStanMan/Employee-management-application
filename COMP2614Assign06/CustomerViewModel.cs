using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlDataServerAccess;
namespace COMP2614Assign06
{
    class CustomerViewModel : INotifyPropertyChanged
    {
        private string customerCode;
        private string companyName;
        private string firstAddress;
        private string secondAddress;
        private string city;
        private string province;
        private string postalCode;
        private decimal yTDSales;
        private bool creditHold;
        private string notes;


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string CustomerCode
        {
            get { return customerCode; }
            set { customerCode = value;
                  OnPropertyChanged();            
            }
        }

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value;
                  OnPropertyChanged();
            
            }
        }

        public string FirstAddress
        {
            get { return firstAddress; }
            set { firstAddress = value;
                  OnPropertyChanged();
            }
        }


        public string SecondAddress
        {
            get { return secondAddress; }
            set { secondAddress = value;
                 OnPropertyChanged();
            }
        }

        public string City
        {
            get { return city; }
            set { city = value;
            OnPropertyChanged();
            }
        }

        public string Province
        {
            get { return province; }
            set { province = value;
            OnPropertyChanged();
            }
        }


        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value;
            OnPropertyChanged();
            }
        }

        public decimal YTDSales
        {
            get { return yTDSales; }
            set { yTDSales = value;
            OnPropertyChanged();
            }
        }


        public bool CreditHold
        {
            get { return creditHold; }
            set { creditHold = value;
            OnPropertyChanged();
            }
        }

        public string Notes
        {
            get { return notes; }
            set { notes = value;
            OnPropertyChanged();
            }
        }

        public CustomerCollection Customers { get; set; }

        public void SetDisplayCustomer(Customer customer) {
            
            CustomerCode = customer.CustomerCode;
            CompanyName = customer.CompanyName;
            FirstAddress= customer.FirstAddress;
            SecondAddress = customer.SecondAddress;
            City = customer.City;
            Province = customer.Province;
            PostalCode= customer.PostalCode;
            YTDSales = customer.YTDSales;
            CreditHold = customer.isCreditHeld;
            Notes = customer.Notes;
        
        
        }

        public Customer GetDisplayedCustomer() {
 
            return new Customer{CustomerCode = this.customerCode,CompanyName = this.companyName, FirstAddress = this.firstAddress, SecondAddress = this.secondAddress, City = this.city, Province = this.province, PostalCode = this.postalCode, YTDSales = this.yTDSales, isCreditHeld = this.creditHold, Notes = this.notes };
        }
    }
}
