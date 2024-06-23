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

namespace WindowsFormsApp1
{
    public partial class Reports : Form
    {
        string conString = @"Data Source=c868-bananas.mysql.database.azure.com;port=3306;Initial Catalog=db1;User Id=BenderC868;password=p33lBack!";
        public Reports()
        {
             InitializeComponent();
            comboBox1.Enabled = false;
            label2.Enabled = false;

            //Lamdba expression for defining the event handler method for the multiple radiobuttons
            consulRbn.CheckedChanged += (sender, e) => consulRbn_CheckedChanged(sender, e);
            cRbn.CheckedChanged += (sender, e) => cRbn_CheckedChanged(sender, e);
            apptRbn.CheckedChanged += (sender, e) => apptRbn_CheckedChanged(sender, e);
        }

        //radio buttons
        private void consulRbn_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            label2.Enabled = false;
        }

        private void apptRbn_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            label2.Enabled = true;
        }
        private void cRbn_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            label2.Enabled = false;
        }

        //Generate button checking which report to generate based on radio button checked
        private void genBn_Click(object sender, EventArgs e)
        {
            if (consulRbn.Checked)
            {
                dgvReport.Columns.Clear();

                using (MySqlConnection con = new MySqlConnection(conString)) 

                {

                    using (MySqlCommand cmd = new MySqlCommand("SELECT createdBy, type, start FROM appointment GROUP BY createdBy, type ORDER BY createdBy, start", con))
                    {
                        using(MySqlDataAdapter rda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable  dt = new DataTable())
                            {
                                rda.Fill(dt);
                                dgvReport.DataSource = dt;

                                dgvReport.Columns["createdBy"].HeaderText = "Consultant";
                                dgvReport.Columns["type"].HeaderText = "Appointment Type";
                                dgvReport.Columns["start"].HeaderText = "Start Time";
                            }
                        }
                    }
                }

            }

            if (apptRbn.Checked)
            {
                dgvReport.Columns.Clear();

                int selMonth = comboBox1.SelectedIndex + 1;
                
                using (MySqlConnection con = new MySqlConnection(conString))

                {

                    using (MySqlCommand cmd = new MySqlCommand("SELECT type, COUNT(*) AS count FROM appointment  WHERE MONTH(start) = @start GROUP BY type", con))


                    {
                        cmd.Parameters.AddWithValue("@start", selMonth);
                        using (MySqlDataAdapter rda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                rda.Fill(dt);
                                dgvReport.DataSource = dt;

                                
                                dgvReport.Columns["type"].HeaderText = "Appointment Type";
                                dgvReport.Columns["count"].HeaderText = "Count";
                            }
                        }
                    }
                }


            }
            if (cRbn.Checked)
            {
                dgvReport.Columns.Clear();

                

                using (MySqlConnection con = new MySqlConnection(conString))

                {

                    using (MySqlCommand cmd = new MySqlCommand("SELECT createdBy, COUNT(*) AS count FROM appointment GROUP BY createdBy", con))


                    {
                       
                        using (MySqlDataAdapter rda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                rda.Fill(dt);
                                dgvReport.DataSource = dt;


                                dgvReport.Columns["createdBy"].HeaderText = "Consultant";
                                dgvReport.Columns["count"].HeaderText = "Appointments Created";
                            }
                        }
                    }
                }


            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //cancel button
        private void cancelBn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
