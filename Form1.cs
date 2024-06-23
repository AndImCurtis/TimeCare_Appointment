using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Resources;

namespace WindowsFormsApp1
{
    
    
    public partial class Form1 : Form
    {
        private static int idxSelectedCustomer;
        private static int idxSelectedAppt;
        private static int modCustomer;
        private static int apptId;


        User currentUser;

        string conString = @"Data Source=c868-bananas.mysql.database.azure.com;port=3306;Initial Catalog=db1;User Id=BenderC868;password=p33lBack!";
        DateTime currentDate;

        public object customerId { get; private set; }
        public object userId { get; private set; }

        public Form1(User user)
        {
            InitializeComponent();
            currentDate = DateTime.Now;
            currentUser = new User();
            currentUser = user;
            userId = user.userId;
            modCustomer = -1;
            dgvMain.Refresh();
            dgvMain.ClearSelection();

            //Lamdba for defining the event handler method for the Customer radiobutton 
            custRB.CheckedChanged += (sender, e) => custRB_CheckedChanged(sender, e);
            //Lamdba for defining the event handler method for the appointment radiobutton
            apptRB.CheckedChanged += (sender, e) => apptRB_CheckedChanged(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            custRB.Checked = true;
            
            
        }


        private void closeBn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //buttons to open other forms
        private void reportsBn_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
        }
        private void newCustbn_Click(object sender, EventArgs e)
        {
            NewCustomer newCustomer = new NewCustomer(currentUser);
            this.Hide();
            newCustomer.Show();
            
        }
        private void editCustbn_Click(object sender, EventArgs e)
        {

                modCustomer = -1;
                modCustomer = Convert.ToInt32(dgvMain.Rows[dgvMain.CurrentCell.RowIndex].Cells[0].Value);

                if (modCustomer != -1)
                {
                    this.Hide();
                    EditCustomer editCustomer = new EditCustomer(currentUser, modCustomer);
                    editCustomer.Show();
                    
                }
                else
                {
                    MessageBox.Show("Please select a customer.");
                }
            
        }




        //closes connection with Red X 'exit' button
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void monthRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void allBn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT customerId, customerName, addressId, createDate FROM customer", con))

                {


                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable cdt = new DataTable())
                        {

                            sda.Fill(cdt);
                            dgvMain.DataSource = cdt;

                            dgvMain.Columns["customerId"].HeaderText = "Customer ID";
                            dgvMain.Columns["customerName"].HeaderText = "Customer Name";
                            dgvMain.Columns["addressId"].HeaderText = "Address ID";
                            dgvMain.Columns["createDate"].HeaderText = "Created Date";

                        }
                    }
                }
            }
            
            
        }

        private void monthBn_Click(object sender, EventArgs e)
        {
            int month = monthCalendar1.SelectionRange.Start.Month;
            dgvMain.Columns.Clear();
            int year = monthCalendar1.SelectionRange.Start.Year;





            dgvMain.Columns.Add("appointment.appointmentId", "Appointment ID");
            dgvMain.Columns.Add("appointment.type", "Appointment Type");
            dgvMain.Columns.Add("customer.customerName", "Customer Name");
            dgvMain.Columns.Add("appointment.start", "Start Time");
            dgvMain.Columns.Add("appointment.createdBy", "Consultant");
           

            dgvMain.AutoGenerateColumns = false;

            dgvMain.Columns["appointment.appointmentId"].DataPropertyName = "appointmentId";
            dgvMain.Columns["appointment.type"].DataPropertyName = "type";
            dgvMain.Columns["customer.customerName"].DataPropertyName = "customerName";
            dgvMain.Columns["appointment.start"].DataPropertyName = "start";
            dgvMain.Columns["appointment.createdBy"].DataPropertyName = "createdBy";
            

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT appointment.appointmentId, appointment.type, appointment.start, appointment.end, appointment.createdBy, customer.customerName FROM appointment " + "LEFT JOIN customer ON appointment.customerId = customer.customerId" + " WHERE MONTH(appointment.start) = @month AND YEAR(appointment.start) = @year ", con))

                {
                    cmd.Parameters.AddWithValue("@month", month);
                    cmd.Parameters.AddWithValue("@year", year);

                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable cdt = new DataTable())
                        {

                            sda.Fill(cdt);
                            dgvMain.DataSource = cdt;

                            for (int idx = 0; idx < cdt.Rows.Count; idx++)
                            {
                                cdt.Rows[idx]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)cdt.Rows[idx]["start"], TimeZoneInfo.Local).ToString();
                            }

                        }
                    }
                }
            }
           //dgvMain.ClearSelection();
           
        }
        private void weekBn_Click(object sender, EventArgs e)
        {
            // DateTime startDate = monthCalendar1.SelectionRange.Start;
            //DateTime endDate = monthCalendar1.SelectionRange.End;
            //while (endDate.DayOfWeek != DayOfWeek.Saturday)
            //{
            //    endDate = endDate.AddDays(1);
            //}
            //DateTime sundayDate = startDate.AddDays(-(int)startDate.DayOfWeek);

            DateTime startDate = monthCalendar1.SelectionRange.Start;
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            Calendar cal = ciCurr.Calendar;
            int weekNum = cal.GetWeekOfYear(startDate, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            
            dgvMain.Columns.Clear();



            dgvMain.Columns.Add("appointment.appointmentId", "Appointment ID");
            dgvMain.Columns.Add("appointment.type", "Appointment Type");
            dgvMain.Columns.Add("customer.customerName", "Customer Name");
            dgvMain.Columns.Add("appointment.start", "Start Time");
            dgvMain.Columns.Add("appointment.createdBy", "Consultant");
            

            dgvMain.AutoGenerateColumns = false;

            dgvMain.Columns["appointment.appointmentId"].DataPropertyName = "appointmentId";
            dgvMain.Columns["appointment.type"].DataPropertyName = "type";
            dgvMain.Columns["customer.customerName"].DataPropertyName = "customerName";
            dgvMain.Columns["appointment.start"].DataPropertyName = "start";
            dgvMain.Columns["appointment.createdBy"].DataPropertyName = "createdBy";
           
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT appointment.appointmentId, appointment.type, appointment.start, appointment.createdBy, customer.customerName FROM appointment " + "LEFT JOIN customer ON appointment.customerId = customer.customerId" + " WHERE WEEK(appointment.start, 1) = @week_number ", con))
                   
                {
                    
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@week_number", weekNum);

                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable cdt = new DataTable())
                        {

                            sda.Fill(cdt);
                            dgvMain.DataSource = cdt;

                            for (int idx = 0; idx < cdt.Rows.Count; idx++)
                            {
                                cdt.Rows[idx]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)cdt.Rows[idx]["start"], TimeZoneInfo.Local).ToString();
                            }

                        }
                    }
                }
            }
             //dgvMain.ClearSelection();
            
        }

        private void dgvMain_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
          
            modCustomer = -1;
            apptId = -1;
            
        }

        //delete customer and addres table record
        private void CustDelBn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete? This cannot be undone.",  "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) { 
            int selCustomer = Convert.ToInt32(dgvMain.SelectedRows[0].Cells["customerId"].Value);
            int custAddress = Convert.ToInt32(dgvMain.SelectedRows[0].Cells["addressId"].Value);

                if (selCustomer != -1)
                {



                    using (MySqlConnection con = new MySqlConnection(conString))
                    {
                        con.Open();

                        using (MySqlTransaction transaction = con.BeginTransaction())
                        {
                            try
                            {
                                using (MySqlCommand command = con.CreateCommand())
                                {
                                    command.Transaction = transaction;

                                    command.CommandText = "DELETE FROM customer WHERE customerId = @customerId";
                                    command.Parameters.AddWithValue("@customerId", selCustomer);
                                    command.ExecuteNonQuery();

                                    command.CommandText = "DELETE FROM address WHERE addressId = @addressId";
                                    command.Parameters.AddWithValue("@addressId", custAddress);
                                    command.ExecuteNonQuery();

                                    transaction.Commit();

                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error when deleting customer: " + ex);
                                MessageBox.Show("Error: Customer has pending appointments, cannot delete!");
                                transaction.Rollback();

                            }


                        }



                        using (MySqlCommand cmd = new MySqlCommand("SELECT customerId, customerName, addressId, createDate FROM customer", con))

                        {


                            using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                            {
                                using (DataTable cdt = new DataTable())
                                {

                                    sda.Fill(cdt);
                                    dgvMain.DataSource = cdt;

                                    dgvMain.Columns["customerId"].HeaderText = "Customer ID";
                                    dgvMain.Columns["customerName"].HeaderText = "Customer Name";
                                    dgvMain.Columns["addressId"].HeaderText = "Address ID";
                                    dgvMain.Columns["createDate"].HeaderText = "Created Date";

                                }
                            }
                        }
                    }
                }
                else return;
                
                
            }
            else  
            {
                MessageBox.Show("Please select a customer to delete!");
            }
            
        }


        //radio buttons
        private void custRB_CheckedChanged(object sender, EventArgs e)
        {

            
            if (custRB.Checked)
            {


                newApptbn.Enabled = true;
                editApptbn.Enabled = false;
                delApptbn.Enabled = false;
                monthCalendar1.Enabled = false;
                monthBn.Enabled = false;
                weekBn.Enabled = false;
                apptAllBn.Enabled = false;
                newCustbn.Enabled = true;
                editCustbn.Enabled = true;
                CustDelBn.Enabled = true;
                allBn.Enabled = true;
            }
            else
            {
                newApptbn.Enabled = false;
                editApptbn.Enabled = true;
                delApptbn.Enabled = true;
                monthCalendar1.Enabled = true;
                monthBn.Enabled = true;
                weekBn.Enabled = true;
                newCustbn.Enabled = false;
                editCustbn.Enabled = false;
                CustDelBn.Enabled = false;
                allBn.Enabled = false;

            }
            

            dgvMain.Columns.Clear();
           

            dgvMain.AutoGenerateColumns = true;
            modCustomer = -1;
            

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT customerId, customerName, addressId, createDate FROM customer", con))

                {


                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable cdt = new DataTable())
                        {

                            sda.Fill(cdt);
                            dgvMain.DataSource = cdt;

                            dgvMain.Columns["customerId"].HeaderText = "Customer ID";
                            dgvMain.Columns["customerName"].HeaderText = "Customer Name";
                            dgvMain.Columns["addressId"].HeaderText = "Address ID";
                            dgvMain.Columns["createDate"].HeaderText = "Created Date";

                        }
                    }
                }
            }
             
            
        }

        
        private void apptRB_CheckedChanged(object sender, EventArgs e)
        {
            if (apptRB.Checked)
            {


                
                if (apptRB.Checked)
                {

                
                newCustbn.Enabled = false;
                editCustbn.Enabled = false;
                CustDelBn.Enabled = false;
                allBn.Enabled = false;
                }

                
                newApptbn.Enabled = false;
                editApptbn.Enabled = true;
                delApptbn.Enabled = true;
                monthCalendar1.Enabled = true;
                monthBn.Enabled = true;
                weekBn.Enabled = true;
                apptAllBn.Enabled = true;

                dgvMain.Columns.Clear();




                dgvMain.Columns.Add("appointment.appointmentId", "Appointment ID");
                dgvMain.Columns.Add("appointment.type", "Appointment Type");
                dgvMain.Columns.Add("customer.customerName", "Customer Name");
                dgvMain.Columns.Add("appointment.start", "Start Time");
                dgvMain.Columns.Add("appointment.createdBy", "Consultant");
                

                dgvMain.AutoGenerateColumns = false;

                dgvMain.Columns["appointment.appointmentId"].DataPropertyName = "appointmentId";
                dgvMain.Columns["appointment.type"].DataPropertyName = "type";
                dgvMain.Columns["customer.customerName"].DataPropertyName = "customerName";
                dgvMain.Columns["appointment.start"].DataPropertyName = "start";
                dgvMain.Columns["appointment.createdBy"].DataPropertyName = "createdBy";
             

                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT appointment.appointmentId, appointment.type, appointment.start, appointment.end, appointment.createdBy, customer.customerName FROM appointment " + "LEFT JOIN customer ON appointment.customerId = customer.customerId", con))

                    {


                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable cdt = new DataTable())
                            {

                                sda.Fill(cdt);
                                dgvMain.DataSource = cdt;

                                for (int idx = 0; idx < cdt.Rows.Count; idx++)
                                {
                                    cdt.Rows[idx]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)cdt.Rows[idx]["start"], TimeZoneInfo.Local).ToString();
                                }

                            }
                        }
                    }
                }
               
                
            }
        }

        public void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        //new appointment button, gets current selected customer
        private void newApptbn_Click(object sender, EventArgs e)
        {
            modCustomer = -1;
            modCustomer = Convert.ToInt32(dgvMain.Rows[dgvMain.CurrentCell.RowIndex].Cells[0].Value);

            if (modCustomer != -1)
            {
                this.Hide();
                NewAppointment newAppointment = new NewAppointment(currentUser, modCustomer);
                newAppointment.Show();
               
            }
            else
            {
                MessageBox.Show("Please select a customer.");
            }
            

        }

        //shows all appointments 
        private void apptAllBn_Click(object sender, EventArgs e)
        {
            dgvMain.Columns.Clear();


            dgvMain.Columns.Add("appointment.appointmentId", "Appointment ID");
            dgvMain.Columns.Add("appointment.type", "Appointment Type");
            dgvMain.Columns.Add("customer.customerName", "Customer Name");
            dgvMain.Columns.Add("appointment.start", "Start Time");
            dgvMain.Columns.Add("appointment.createdBy", "Consultant");
            

            dgvMain.AutoGenerateColumns = false;

            dgvMain.Columns["appointment.appointmentId"].DataPropertyName = "appointmentId";
            dgvMain.Columns["appointment.type"].DataPropertyName = "type";
            dgvMain.Columns["customer.customerName"].DataPropertyName = "customerName";
            dgvMain.Columns["appointment.start"].DataPropertyName = "start";
            dgvMain.Columns["appointment.createdBy"].DataPropertyName = "createdBy";
            
            DateTime currentUtc = DateTime.Now;

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT appointment.appointmentId, appointment.type, appointment.start, appointment.end, appointment.createdBy, customer.customerName FROM appointment " + "LEFT JOIN customer ON appointment.customerId = customer.customerId", con))

                {
                    

                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable cdt = new DataTable())
                        {

                            sda.Fill(cdt);
                            dgvMain.DataSource = cdt;

                            for(int idx = 0; idx < cdt.Rows.Count; idx++)
                            {
                                cdt.Rows[idx]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)cdt.Rows[idx]["start"], TimeZoneInfo.Local).ToString();
                            }
                        }
                    }
                }
            }
            
        }

        private void delApptbn_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Are you sure you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
            //if (result == DialogResult.Yes)
            //{
                int selAppt = Convert.ToInt32(dgvMain.Rows[dgvMain.CurrentCell.RowIndex].Cells[0].Value);

                if (selAppt != -1)
                {
                DialogResult result = MessageBox.Show("Are you sure you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    using (MySqlConnection con = new MySqlConnection(conString))
                    {
                        con.Open();

                        using (MySqlTransaction transaction = con.BeginTransaction())
                        {
                            try
                            {
                                using (MySqlCommand command = con.CreateCommand())
                                {
                                    command.Transaction = transaction;

                                    command.CommandText = "DELETE FROM appointment WHERE appointmentId = @appointmentId";
                                    command.Parameters.AddWithValue("@appointmentId", selAppt);
                                    command.ExecuteNonQuery();



                                    transaction.Commit();

                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error when deleting appointment: " + ex);

                                transaction.Rollback();

                            }
                        }
                    }
                    dgvMain.Columns.Clear();


                    dgvMain.Columns.Add("appointment.appointmentId", "Appointment ID");
                    dgvMain.Columns.Add("appointment.type", "Appointment Type");
                    dgvMain.Columns.Add("customer.customerName", "Customer Name");
                    dgvMain.Columns.Add("appointment.start", "Start Time");
                    dgvMain.Columns.Add("appointment.createdBy", "Consultant");
                    

                    dgvMain.AutoGenerateColumns = false;

                    dgvMain.Columns["appointment.appointmentId"].DataPropertyName = "appointmentId";
                    dgvMain.Columns["appointment.type"].DataPropertyName = "type";
                    dgvMain.Columns["customer.customerName"].DataPropertyName = "customerName";
                    dgvMain.Columns["appointment.start"].DataPropertyName = "start";
                    dgvMain.Columns["appointment.createdBy"].DataPropertyName = "createdBy";
                    

                    using (MySqlConnection con = new MySqlConnection(conString))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("SELECT appointment.appointmentId, appointment.type, appointment.start, appointment.end, appointment.createdBy, customer.customerName FROM appointment " + "LEFT JOIN customer ON appointment.customerId = customer.customerId", con))

                        {


                            using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                            {
                                using (DataTable cdt = new DataTable())
                                {

                                    sda.Fill(cdt);
                                    dgvMain.DataSource = cdt;

                                    for (int idx = 0; idx < cdt.Rows.Count; idx++)
                                    {
                                        cdt.Rows[idx]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)cdt.Rows[idx]["start"], TimeZoneInfo.Local).ToString();
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No appointment selected.");
                }
            }
        }

        private void editApptbn_Click(object sender, EventArgs e)
        {
            modCustomer = -1;
            modCustomer = Convert.ToInt32(dgvMain.Rows[dgvMain.CurrentCell.RowIndex].Cells[0].Value);

            if (modCustomer != -1)
            {
                this.Hide();
                editAppt editAppt = new editAppt(currentUser, modCustomer);
                editAppt.Show();
                
            }
            else
            {
                MessageBox.Show("Please select an appointment.");
            }

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            
            string match = searchTxt.Text;
            if (string.IsNullOrEmpty(searchTxt.Text))
            {
                foreach (DataGridViewRow row in dgvMain.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                   
                }
            }
            if (match != "")
            {
                foreach (DataGridViewRow row in dgvMain.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().IndexOf(match, StringComparison.CurrentCultureIgnoreCase) >= 0)
                        {
                            row.DefaultCellStyle.BackColor = Color.Red;
                            break;
                        }
                    }
                }
            }

           
        }
    }
}
