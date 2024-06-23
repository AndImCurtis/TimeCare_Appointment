using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp1.Resources;

namespace WindowsFormsApp1
{
    public partial class EditCustomer : Form
    {
       
            User currentUser;
            int modifyCustomer;

        
            public EditCustomer(User user, int modCustomer)
            {
                InitializeComponent();
                currentUser = new User();
                currentUser.username = user.username;
                modifyCustomer = modCustomer;
            

            DBConnection data = new DBConnection();

            grabCustomer customerdetails = data.customerdetails(modifyCustomer);

            firstText.Text = customerdetails.customerName;
            phoneText.Text = customerdetails.phoneNumber;
            addressText.Text = customerdetails.address;
            address2.Text = customerdetails.address2;
            cityText.Text = customerdetails.city;
            countryText.Text = customerdetails.country;
            postalCodeText.Text = customerdetails.postalCode;
           

            custId.Text = modCustomer.ToString();
            cType.Text = customerdetails.CustType;

            if (cType.Text == "R")
            {
                residentialRbn.Checked = true;
            }
            if (cType.Text == "C")
            {
                commercialRbn.Checked = true;
            }

        }

     


            //ensure only numbers can be entered into specific textboxes (phone number and Zip Code)
        private void phoneText_KeyPress(object sender, KeyPressEventArgs e)
            {

            }

        private void postalCodeText_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void EditCustomer_Load(object sender, EventArgs e)
            {
              
            }

        //cancel and exit buttons
        private void cancelBn_Click_1(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void EditCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {

            Form1 form1 = new Form1(currentUser);
            form1.Show();
        }

        private void saveBn_Click_1(object sender, EventArgs e)
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

                grabCustomer customerdetails = new grabCustomer();

                customerdetails.customerId = modifyCustomer;
                customerdetails.customerName = firstText.Text;
                customerdetails.phoneNumber = phoneText.Text;
                customerdetails.address = addressText.Text;
                customerdetails.address2 = address2.Text;
                customerdetails.city = cityText.Text;
                customerdetails.postalCode = postalCodeText.Text;
                customerdetails.country = countryText.Text;

                bool insertCustomerInfo = data.saveCustomerdetails(customerdetails);

                if (insertCustomerInfo)
                {
                    Form1 form1 = new Form1(currentUser);
                    this.Hide();
                    form1.Show();
                }
            }
        }

        private void residentialRbn_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Full Name";
            label6.Text = "Address 2";
        }

        private void commercialRbn_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Company Name";
            label6.Text = "Point of Contact";
        }
    }

    }
