using MySql.Data.MySqlClient;
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
    public partial class editAppt : Form
    {

        User currentUser;
        int apptId;
        int custId;
        bool checkAppt;
        public editAppt(User user, int modCustomer)
        {
            InitializeComponent();
            currentUser = new User();
            currentUser.username = user.username;

            
            apptId = modCustomer;
            
            currentUser.userId = user.userId;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            DBConnection data = new DBConnection();

            Appointment appt = data.apptDetails(apptId);

            cName.Text = appt.customerName;
            apptType.Text = appt.type;
            cId.Text = apptId.ToString();
           
            custIdText.Text = appt.customerId.ToString();
            //cType.Text = appt.custType;
        }

        private void cancelBn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editAppt_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1(currentUser);
            form1.Show();
        }

       

        private void saveBn_Click(object sender, EventArgs e)
        {
            bool noWhiteSpace;
            bool businessHours = dateTimePicker1.Value.TimeOfDay >= new
                TimeSpan(8, 0, 0) && dateTimePicker1.Value.TimeOfDay <= new TimeSpan(20, 0, 0);


            //if (cType.Text == "R")
            //{

                if (businessHours == true)
                {

                    if (string.IsNullOrEmpty(apptType.Text))
                    {
                        noWhiteSpace = false;
                        MessageBox.Show("All fields are required for submitting an appointment.");
                    }
                    else
                    {
                        noWhiteSpace = true;
                    }

                    if (noWhiteSpace)
                    {
                        string str = custIdText.Text;
                        int num;

                        bool success = int.TryParse(str, out num);
                        if (success) { }
                        else
                        {

                        }
                        Appointment apptInfo = new Appointment();
                        apptInfo.appointmentId = apptId;
                        apptInfo.customerId = num;
                        apptInfo.userId = currentUser.userId;
                        apptInfo.username = currentUser.username;
                        apptInfo.type = apptType.Text;
                        apptInfo.start = dateTimePicker1.Value.ToUniversalTime();
                        apptInfo.end = dateTimePicker1.Value.AddMinutes(45).ToUniversalTime();


                        DBConnection data = new DBConnection();

                        if (data.updateAppointment(apptInfo))
                        {

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Appointment could not be updated.");
                        }

                    }
                }
                else if (businessHours == false)
                {
                    MessageBox.Show("Appointment cannot be made outside of Business Hours, please try again.");
                }
            //}
            //else if (cType.Text == "C")
            //{

            //    if (string.IsNullOrEmpty(apptType.Text))
            //    {
            //        noWhiteSpace = false;
            //        MessageBox.Show("All fields are required for submitting an appointment.");
            //    }
            //    else
            //    {
            //        noWhiteSpace = true;
            //    }

            //    if (noWhiteSpace)
            //    {
            //        string str = custIdText.Text;
            //        int num;

            //        bool success = int.TryParse(str, out num);
            //        if (success) { }
            //        else
            //        {

            //        }
            //        Appointment apptInfo = new Appointment();
            //        apptInfo.appointmentId = apptId;
            //        apptInfo.customerId = num;
            //        apptInfo.userId = currentUser.userId;
            //        apptInfo.username = currentUser.username;
            //        apptInfo.type = apptType.Text;
            //        apptInfo.custType = cType.Text;
            //        apptInfo.start = dateTimePicker1.Value.ToUniversalTime();
            //        apptInfo.end = dateTimePicker1.Value.AddMinutes(45).ToUniversalTime();


            //        DBConnection data = new DBConnection();

            //        if (data.updateAppointment(apptInfo))
            //        {

            //            this.Close();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Appointment could not be updated.");
            //        }

            //    }
            //}

            }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
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
            }

        }
    }
}

