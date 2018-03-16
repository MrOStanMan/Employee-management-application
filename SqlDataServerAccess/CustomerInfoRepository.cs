using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataServerAccess
{
   public class CustomerInfoRepository
    {
        private static string connString = "Server=tcp:s08.winhost.com;Database=DB_15202_2614;User ID=DB_15202_2614_user;Password=93nu5#S67;Integrated Security=False;";

        public static CustomerCollection GetAllCustomers()
        {

            CustomerCollection customers;

                using (SqlConnection conn = new SqlConnection(connString))
                {

                    string query = string.Format("​{0} {1} {2}"
                                      , "SELECT CustomerCode, CompanyName, Address1, Address2, City, Province, PostalCode, YTDSales, CreditHold, Notes"
                                      , "FROM Customers944927"
                                      , "ORDER BY CustomerCode");



                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;


                    conn.Open();

                    customers = new CustomerCollection();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        string customerCode;
                        string companyName;
                        string firstAddress;
                        string secondAddress;
                        string city;
                        string province;
                        string postalCode;
                        decimal yTDSales;
                        byte creditHold;
                        string notes;

                        while (reader.Read())
                        {
                            customerCode = reader["CustomerCode"] as string;
                            companyName = reader["CompanyName"] as string;
                            firstAddress = reader["Address1"] as string;

                            if (!reader.IsDBNull(3))
                            {
                                secondAddress = reader["Address2"] as string;


                            }
                            else
                            {
                                secondAddress = string.Empty;

                            }

                            if (!reader.IsDBNull(4))
                            {
                                city = reader["City"] as string;


                            }
                            else
                            {
                                city = string.Empty;

                            }

                            province = reader["Province"] as string;

                            if (!reader.IsDBNull(6))
                            {
                                postalCode = reader["PostalCode"] as string;


                            }

                            else
                            {
                                postalCode = string.Empty;

                            }
                            yTDSales = (decimal)reader["YTDSales"];

                            creditHold = (byte)reader["CreditHold"];
                            bool isCreditHeld = creditHold == 1;

                            if (!reader.IsDBNull(9))
                            {
                                notes = reader["Notes"] as string;


                            }

                            else
                            {
                                notes = string.Empty;

                            }

                            customers.Add(new Customer
                            {   CustomerCode = customerCode,
                                CompanyName = companyName,
                                FirstAddress =firstAddress,
                                SecondAddress=secondAddress,
                                City = city,
                                Province = province,
                                PostalCode= postalCode,
                                YTDSales = yTDSales,
                                isCreditHeld = isCreditHeld,
                                Notes = notes
                            });

                        }
                    }

                    return customers;

                }
            }

        

        public static int NewCustomer(Customer customer)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                // embedded SQL
                string query = string.Format("{0} {1} {2}"
                                        , "INSERT INTO Customers944927"
                                        , "(CustomerCode, CompanyName, Address1, Address2, City, Province, PostalCode, YTDSales, CreditHold, Notes)"
                                        , "VALUES (@customerCode, @companyName, @address1, @address2, @city, @province, @postalCode, @yTDSales, @creditHold, @notes)");


                byte taxable = customer.isCreditHeld ? (byte)1 : (byte)0;

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@customerCode", customer.CustomerCode);
                    cmd.Parameters.AddWithValue("@companyName", customer.CompanyName);
                    cmd.Parameters.AddWithValue("@address1", customer.FirstAddress);
                   
                    if (customer.SecondAddress != null)
                    {
                        cmd.Parameters.AddWithValue("@address2", customer.SecondAddress);
                    }
                    else {
                        cmd.Parameters.AddWithValue("@address2", DBNull.Value);
                    
                    }

                    if (customer.City != null)
                    {
                        cmd.Parameters.AddWithValue("@city", customer.City);
                    }
                    else {

                        cmd.Parameters.AddWithValue("@city", DBNull.Value);
                    
                    }

                    cmd.Parameters.AddWithValue("@province", customer.Province);

                    if (customer.PostalCode != null)
                    {
                        cmd.Parameters.AddWithValue("@postalCode", customer.PostalCode);

                    }
                    else {

                        cmd.Parameters.AddWithValue("@postalCode", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@yTDSales", customer.YTDSales);
                    cmd.Parameters.AddWithValue("@creditHold", customer.isCreditHeld);

                    if (customer.Notes != null)
                    {
                        cmd.Parameters.AddWithValue("@notes", customer.Notes);
                    }

                    else 
                    {
                        cmd.Parameters.AddWithValue("@notes", DBNull.Value);
                    
                    }

                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }

        public static int UpdateCustomer(Customer customer)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                // embedded SQL
                string query = string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10}"
                                        , "UPDATE Customers944927"
                                        , "SET CompanyName = @companyName"  
                                        , ", Address1 = @address1"
                                        , ", Address2 = @address2"
                                        , ", City = @city"
                                        , ", Province = @province"
                                        , ", PostalCode = @postalCode"
                                        ," , YTDSales =@yTDSales"
                                        , ", CreditHold = @creditHold"
                                        , ", Notes = @notes"
                                        , "WHERE CustomerCode = @customerCode");

                byte taxable = customer.isCreditHeld ? (byte)1 : (byte)0;

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@customerCode", customer.CustomerCode);
                    cmd.Parameters.AddWithValue("@companyName", customer.CompanyName);
                    cmd.Parameters.AddWithValue("@address1", customer.FirstAddress);

                    if (customer.SecondAddress != null)
                    {
                        cmd.Parameters.AddWithValue("@address2", customer.SecondAddress);
                    }
                    else 
                    {
                        cmd.Parameters.AddWithValue("@address2", DBNull.Value);
                    
                    }

                    if (customer.City != null)
                    { 
                       
                        cmd.Parameters.AddWithValue("@city", customer.City);

                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@city", DBNull.Value);    
                    }

                   
                    cmd.Parameters.AddWithValue("@province", customer.Province);

                    if (customer.PostalCode != null)
                    {
                        cmd.Parameters.AddWithValue("@postalCode", customer.PostalCode);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@postalCode", DBNull.Value);
                    
                    }
                    cmd.Parameters.AddWithValue("@yTDSales", customer.YTDSales);
                    cmd.Parameters.AddWithValue("@creditHold", customer.isCreditHeld);
                    if (customer.Notes != null)
                    {
                        cmd.Parameters.AddWithValue("@notes", customer.Notes);
                    }
                    else 
                    {
                        cmd.Parameters.AddWithValue("@notes", DBNull.Value);
                    
                    }

                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }

        public static int DeleteCustomer(Customer customer)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                // embedded SQL
                string query = string.Format("{0} {1}"
                                        , "DELETE Customers944927"
                                        , "WHERE CustomerCode = @customerCode");

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@customerCode", customer.CustomerCode);

                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }

    }
}
