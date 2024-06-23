using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Resources;

namespace WindowsFormsApp1
{
    public partial class NewAppointment : Form
    {

        User currentUser;
        int modifyCustomer;
        bool checkAppt;


        public NewAppointment(User user, int modCustomer)
        {
            InitializeComponent();
            currentUser = new User();
            currentUser.username = user.username;
            modifyCustomer = modCustomer;
            currentUser.userId = user.userId;
            
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Value = DateTime.Now;

            DBConnection data = new DBConnection();

            grabCustomer customerdetails = data.customerdetails(modifyCustomer);

            cName.Text = customerdetails.customerName;
            cType.Text = customerdetails.CustType;


            cId.Text = modCustomer.ToString();
        }

        private void NewAppointment_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cancelBn_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void saveBn_Click(object sender, EventArgs e)
        {

            dateTimePicker1.Value.ToUniversalTime();

            DBConnection data = new DBConnection();
            bool checkdAppt = data.overlappingAppt(dateTimePicker1.Value.ToUniversalTime(), dateTimePicker1.Value.AddMinutes(45).ToUniversalTime());

            if (checkdAppt)
            {
                checkAppt = false;
                MessageBox.Show("Invalid Time, appointment already exists.");
                label6.Show();
            }
            else
            {
                checkAppt = true;
                label6.Hide();



                bool nemptyfields;
                bool businessHours = dateTimePicker1.Value.TimeOfDay >= new
                TimeSpan(8, 0, 0) && dateTimePicker1.Value.TimeOfDay <= new TimeSpan(20, 0, 0);

                if (cType.Text == "R")
                {

                    if (businessHours == true)
                    {
                        if (string.IsNullOrWhiteSpace(apptType.Text))
                        {
                            nemptyfields = false;
                            MessageBox.Show("All fields are required for submitting an appointment.");
                        }
                        else
                        {
                            nemptyfields = true;
                        }

                        if (nemptyfields && checkAppt)
                        {


                            Appointment appt = new Appointment();

                            appt.customerId = modifyCustomer;
                            appt.userId = currentUser.userId;
                            appt.type = apptType.Text;
                            appt.username = currentUser.username;
                            appt.custType = cType.Text;
                            appt.start = dateTimePicker1.Value.ToUniversalTime();
                            appt.end = dateTimePicker1.Value.AddMinutes(45).ToUniversalTime();




                            if (data.addAppointment(appt) != -1)
                            {
                                Form1 form1 = new Form1(currentUser);
                                this.Hide();
                                form1.Show();

                            }
                        }
                    }
                    else if (businessHours == false)
                    {
                        MessageBox.Show("Appointment cannot be made outside of Business Hours, please try again.");
                    }
                }
                else if (cType.Text == "C")
            {
                if (string.IsNullOrWhiteSpace(apptType.Text))
                {
                    nemptyfields = false;
                    MessageBox.Show("All fields are required for submitting an appointment.");
                }
                else
                {
                    nemptyfields = true;
                }

                if (nemptyfields && checkAppt)
                {


                    Appointment appt = new Appointment();

                    appt.customerId = modifyCustomer;
                    appt.userId = currentUser.userId;
                    appt.type = apptType.Text;
                    appt.username = currentUser.username;
                    appt.custType = cType.Text;
                    appt.start = dateTimePicker1.Value.ToUniversalTime();
                    appt.end = dateTimePicker1.Value.AddMinutes(45).ToUniversalTime();




                    if (data.addAppointment(appt) != -1)
                    {
                        Form1 form1 = new Form1(currentUser);
                        this.Hide();
                        form1.Show();

                    }
                }
            }

        }

    }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void NewAppointment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1(currentUser);
            form1.Show();
        }
    }
}
