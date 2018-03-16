using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlDataServerAccess;
using System.Text.RegularExpressions;

namespace COMP2614Assign06
{
    public partial class MainForm : Form
    {
        private CustomerViewModel customerVM;
        private bool isNew;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            try
            {
                customerVM = new CustomerViewModel();
                customerVM.Customers = CustomerInfoRepository.GetAllCustomers();
                setBindings();
                isNew = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void setBindings()
        {
            textBoxCompanyCode.DataBindings.Add("Text", customerVM, "CustomerCode", false, DataSourceUpdateMode.OnValidation);
            textBoxName.DataBindings.Add("Text", customerVM, "CompanyName", false, DataSourceUpdateMode.OnValidation);
            textBoxFirstAddress.DataBindings.Add("Text", customerVM, "FirstAddress", false, DataSourceUpdateMode.OnValidation);
            textBoxSecondAddress.DataBindings.Add("Text", customerVM, "SecondAddress", false, DataSourceUpdateMode.OnValidation);
            textBoxCity.DataBindings.Add("Text", customerVM, "City", false, DataSourceUpdateMode.OnValidation);
            textBoxProvince.DataBindings.Add("Text", customerVM, "Province", false, DataSourceUpdateMode.OnValidation);
            textBoxPostalCode.DataBindings.Add("Text", customerVM, "PostalCode", false, DataSourceUpdateMode.OnValidation);
            textBoxYTDSales.DataBindings.Add("Text", customerVM, "YTDSales", true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;(#,##0.00);0.00");
            richTextBoxNotes.DataBindings.Add("Text", customerVM, "Notes", false, DataSourceUpdateMode.OnValidation);
            checkBoxCreditHold.DataBindings.Add("Checked", customerVM, "CreditHold");


            listBoxCustomers.DataSource = customerVM.Customers;
            listBoxCustomers.DisplayMember = "CustomerCode";
        }


        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = Math.Max(0, listBoxCustomers.SelectedIndex);
            Customer customer = customerVM.Customers[selectedIndex];
            customerVM.SetDisplayCustomer(customer);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
           try
            {
                Customer customer = customerVM.GetDisplayedCustomer();
                int rowsAffected;
                bool success;

            if (!isNew)
            {

                rowsAffected = CustomerValidation.UpdateCustomer(customer, out success);
            }
            else
            {

                rowsAffected = CustomerValidation.NewCustomer(customer, out success);
            }
           
            if (rowsAffected > 0)
            {
                customerVM.Customers = CustomerInfoRepository.GetAllCustomers();
                listBoxCustomers.DataSource = customerVM.Customers;
                listBoxCustomers.DisplayMember = "CustomerCode";
            }
            
            // Validation for ErrorProviders
            if (!success)
            {
                ErrorList errors = CustomerValidation.Errors;

                errorProvider.SetError(textBoxCompanyCode, errors.CompanyCodeErrorMessage);
                errorProvider.SetError(textBoxName, errors.CompanyNameErrorMessage);
                errorProvider.SetError(textBoxFirstAddress, errors.FirstAddressErrorMessage);
                errorProvider.SetError(textBoxProvince, errors.ProvinceErrorMessage);
                errorProvider.SetError(textBoxPostalCode, errors.PostalCodeErrorMessage);
                errorProvider.SetError(textBoxYTDSales, errors.YTDSalesErrorMessage);
            }
            else {

                isNew = false;
                errorProvider.SetError(textBoxCompanyCode, string.Empty);
                errorProvider.SetError(textBoxName, string.Empty);
                errorProvider.SetError(textBoxFirstAddress, string.Empty);
                errorProvider.SetError(textBoxProvince, string.Empty);
                errorProvider.SetError(textBoxPostalCode, string.Empty);
                errorProvider.SetError(textBoxYTDSales, string.Empty);

            }

        }

            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        
       }
   

        private void buttonNewCustomer_Click(object sender, EventArgs e)
        {
            isNew = true;
            customerVM.SetDisplayCustomer(new Customer());
            textBoxCompanyCode.Select();
            textBoxCompanyCode.SelectAll();

            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Customer customer = customerVM.GetDisplayedCustomer();
            CustomerInfoRepository.DeleteCustomer(customer);
            customerVM.Customers = CustomerInfoRepository.GetAllCustomers();
            listBoxCustomers.DataSource = customerVM.Customers;
            listBoxCustomers.DisplayMember = "CustomerCode";
        }
    }
}
