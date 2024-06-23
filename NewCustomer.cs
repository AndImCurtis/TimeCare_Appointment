using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Resources;


namespace WindowsFormsApp1
{
    public partial class NewCustomer : Form
    {
        User currentUser;
        
        public string cType { get; set; }
        public NewCustomer(User user)
        {
            InitializeComponent();
            currentUser = new User();
            currentUser.username = user.username;
            currentUser.userId = user.userId;

            commercialRbn.Checked = true;

        }

        private void cancelBn_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void saveBn_Click(object sender, EventArgs e)
        {
           

            bool nemptyfields;

            if (string.IsNullOrWhiteSpace(firstText.Text) || string.IsNullOrWhiteSpace(phoneText.Text) || string.IsNullOrWhiteSpace(cityText.Text) || string.IsNullOrWhiteSpace(countryText.Text) || string.IsNullOrWhiteSpace(cityText.Text) || string.IsNullOrWhiteSpace(addressText.Text) || string.IsNullOrWhiteSpace(address2.Text) || string.IsNullOrWhiteSpace(postalCodeText.Text))
            {
                nemptyfields = false;
                MessageBox.Show("All fields are required.");
            }
            else
            {
                nemptyfields = true;
            }

            if (nemptyfields)
            {
                DBConnection data = new DBConnection();

                Customer customer = new Customer();
                Address address = new Address();
                City city = new City();
                Country country = new Country();

                

                country.createdBy = currentUser.username;
                country.country = countryText.Text;

                city.createdBy = currentUser.username;
                city.city = cityText.Text;

                city.countryId = data.addCountry(country);

                

                address.createdBy = currentUser.username;
                address.address = addressText.Text;
                address.address2 = address2.Text;
                address.postalCode = postalCodeText.Text;
                address.phone = phoneText.Text;
                address.cityId = data.addCity(city);



                customer.customerName = firstText.Text;
                customer.createdBy = currentUser.username;
                customer.addressId = data.addAddress(address);
                customer.custType = cType;

                if (data.addCustomer(customer))
               {
                    
                    this.Close();
                    
               }
            }
        }


        //ensure only numbers can be entered into specific textboxes (phone number and Zip Code)
        private void phoneText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void postalCodeText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NewCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1(currentUser);
            form1.Show();
        }

        private void residentialRbn_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Full Name";
            label6.Text = "Address 2";
            cType = "R";

        }

        private void commercialRbn_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Company Name";
            label6.Text = "Point of Contact";
            cType = "C";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
