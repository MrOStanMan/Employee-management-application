using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataServerAccess
{
   public class Customer
    {

        public string CustomerCode
        { get; 
          set; 
        }

        public string Notes
        {
            get; 
            set;
        }

        public bool isCreditHeld
        {
            get;
            set;
        }

        public decimal YTDSales
        {
            get;
            set;
        }


        public string PostalCode
        {
            get;
            set;
        }

        public string Province
        {
            get;
            set;
        }

        public string City
        {
            get;
            set;
        }

        public string SecondAddress
        {
            get;
            set;
        }

        public string FirstAddress
        {
            get;
            set;
        }

        public string CompanyName
        {
            get;
            set;
        }

    }

}
