using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Resources;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace WindowsFormsApp1
{
    public partial class LoginScreen : Form
    {
        
        string conString = @"Data Source=c868-bananas.mysql.database.azure.com;port=3306;Initial Catalog=db1;User Id=BenderC868;password=p33lBack!";
        public LoginScreen()
        {
            InitializeComponent();

            findLanguage();
        }


        private void findLanguage()
        {
            switch (CultureInfo.CurrentCulture.TwoLetterISOLanguageName)

            {
                case "en":
                    englishTexts();
                    break;

                case "fr":
                    frenchTexts();
                    break;

                default:
                    englishTexts();
                    break;
            }
        }


        private void englishTexts()
        {
            this.Text = "Login";
            please.Text = "Please enter your log in credentials.";
            userLabel.Text = "Username:";
            userPassLabel.Text = "Password:";
            loginBn.Text = "Log In";
            cancelBn.Text = "Cancel";
            invalidMessage.Text = "Username or Password not recognized! Please Try again!";
        }

        private void frenchTexts()
        {
            this.Text = "Se connecter";
            please.Text = "Veuillez saisir vos identifiants de connexion.";
            userLabel.Text = "Nom d'utillisateur:";
            userPassLabel.Text = "Mot de passe:";
            loginBn.Text = "Se connecter";
            cancelBn.Text = "Annuler";
            invalidMessage.Text = "Nom d'utillisateur ou mot de passe non reconnu! Veuillez réessayer!";
        }


        private void loginBn_Click(object sender, EventArgs e)
        {

            textfile data = new textfile();
            DBcheck dBcheck = new DBcheck();
            User userlogin = new User(userlogintext.Text, userpasswordtext.Text);
            userlogin.userId = dBcheck.findUserlogin(userlogin);


            //converts localtime to sever time to check for appointments
            DateTime localNow = DateTime.Now;
            DateTime utcNow = localNow.ToUniversalTime();
           
            data.logUserAttempts("Username: '" + userlogin.username + " '. Password: " + userlogin.password + ". Login Attempted at " + utcNow);

            if (userlogin.userId != -1)
            {

                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM appointment WHERE userId = @userId AND start BETWEEN @now AND DATE_ADD(@now, INTERVAL 15 MINUTE)", con))
                        
                    {
                        cmd.Parameters.AddWithValue("@now", utcNow);
                        cmd.Parameters.AddWithValue("@userId", userlogin.userId);
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable cdt = new DataTable())
                            {
                                
                                sda.Fill(cdt);


                                if (cdt.Rows.Count > 0)
                                {
                                    MessageBox.Show("Appointment starting within 15 minutes!");
                                }
                            }
                            
                        }
                    }
                }
                Form1 form1 = new Form1(userlogin);
                form1.Show();

                this.Hide();
            }
            else
            {
                //hidden unless triggered
                invalidMessage.Show();
              
            }
           
           
        }


        private void cancelBn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userpasswordtext_TextChanged(object sender, EventArgs e)
        {
            //hide text in textbox
            userpasswordtext.PasswordChar = '\u25CF';
        }
    }





}
