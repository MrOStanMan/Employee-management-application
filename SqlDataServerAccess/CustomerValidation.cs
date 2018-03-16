using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SqlDataServerAccess
{
   public class CustomerValidation
    {
     private static ErrorList errors;

       static CustomerValidation()
        {
            errors = new ErrorList();
        }

        public static int NewCustomer(Customer customer, out bool success)
        {
            if (validate(customer))
            {
                success = true;
                return CustomerInfoRepository.NewCustomer(customer);

            }
            else
            {
                success = false;
                return 0;
            }
        }

        public static int UpdateCustomer(Customer customer, out bool success)
        {
            if (validate(customer))
            {
                success = true;
                return CustomerInfoRepository.UpdateCustomer(customer);
            }
            else
            {
                success = false;
                return 0;
            }
        }

        private static bool validate(Customer customer)
        {
            string regexCustomerCode = "^[A-Z]{5,5}$";
            bool success = true;
            errors.Clear();

            // Emptying error message properties 
            errors.CompanyCodeErrorMessage = string.Empty;
            errors.CompanyNameErrorMessage = string.Empty;
            errors.FirstAddressErrorMessage = string.Empty;
            errors.ProvinceErrorMessage = string.Empty;
            errors.PostalCodeErrorMessage = string.Empty;
            errors.YTDSalesErrorMessage = string.Empty;

            
            if (!Regex.IsMatch(customer.CustomerCode,regexCustomerCode))
            {
                errors.Add(Errors.CompanyCodeErrorMessage="Customer Code must be exactly five alpha characters");
                success = false;
            }

            if (string.IsNullOrEmpty(customer.CompanyName))
            {
                errors.Add(Errors.CompanyNameErrorMessage= "Company Name cannot Be empty");
                success = false;
            }

            if (string.IsNullOrEmpty(customer.FirstAddress))
            {
                errors.Add(Errors.FirstAddressErrorMessage="First Address cannot be empty");
                success = false;
            }

            if (string.IsNullOrEmpty(customer.Province))
            {
                errors.Add(Errors.ProvinceErrorMessage="Province cannot be empty");
                success = false;
            }

            string regexCustomerPostalCode = "^[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ] ?[0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]$";
            if (!Regex.IsMatch(customer.PostalCode, regexCustomerPostalCode))
            {
                errors.Add(Errors.PostalCodeErrorMessage = "Postal Code Must be in standard Canadian postal code format");
                success = false;
            }

            if(customer.YTDSales < 0.00m){
                errors.Add(Errors.YTDSalesErrorMessage="YTD Sales cannot be less than $0.00");
                success = false;
            
            }

            return success;
        }

        public static ErrorList Errors
        {
            get
            {
                return errors;
            }
        }
    }
}


 
