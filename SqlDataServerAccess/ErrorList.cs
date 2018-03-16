using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataServerAccess
{
   public class ErrorList : List<string>
    {
        private string companyCodeErrorMessage;
        private string companyNameErrorMessage;
        private string firstAddressErrorMessage;
        private string provinceErrorMessage;
        private string postalCodeErrorMessage;
        private string yTDSalesErrorMessage;


        public string YTDSalesErrorMessage
        {
            get { return yTDSalesErrorMessage; }
            set { yTDSalesErrorMessage = value; }
        }


        public string PostalCodeErrorMessage
        {
            get { return postalCodeErrorMessage; }
            set { postalCodeErrorMessage = value; }
        }
        

        public string ProvinceErrorMessage
        {
            get { return provinceErrorMessage; }
            set { provinceErrorMessage = value; }
        }

        public string FirstAddressErrorMessage
        {
            get { return firstAddressErrorMessage; }
            set { firstAddressErrorMessage = value; }
        }

        public string CompanyNameErrorMessage
        {
            get { return companyNameErrorMessage; }
            set { companyNameErrorMessage = value; }
        }

        public string CompanyCodeErrorMessage
        {
            get { return companyCodeErrorMessage; }
            set { companyCodeErrorMessage = value; }
        }
      

    }
}
