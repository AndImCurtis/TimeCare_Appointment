using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Resources;
using System.Drawing;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1.Resources
{
    class DBConnection
    {
        
        private const string server = "c868-bananas.mysql.database.azure.com";
        private const string database = "db1";
        private const string DBusername = "BenderC868";
        private const string DBpassword = "p33lBack!";
        private const string port = "3306";
        private const string connectionString = "SERVER=" + server + ";" + "Port=" + port + ";" + "DATABASE=" + database + ";" + "Username=" + DBusername + ";" + "Password=" + DBpassword;
        //make connection
        public static MySqlConnection conn { get; set; }
        public static void startConnection()
        {

            try
            {
                //get connection string
                string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
                conn = new MySqlConnection(constr);

                //open connection
                conn.Open();

               //MessageBox.Show("Connection is Open!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //close connection
        public static void stopConnection() 
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                }
                conn = null;
            }
            catch (MySqlException ex)
            {
               Console.WriteLine(ex.Message);   
            }
        }


        public bool addCustomer(Customer customer)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy, type) VALUES (@customerName, @addressId, @active, @createDate, @createdBy, @lastUpdate, @lastUpdateBy, @cType)";
                cmd.Parameters.AddWithValue("@customerName", customer.customerName);
                cmd.Parameters.AddWithValue("@addressId", customer.addressId);
                cmd.Parameters.AddWithValue("@active", 1);
                cmd.Parameters.AddWithValue("@createDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@createdBy", customer.createdBy);
                cmd.Parameters.AddWithValue("@lastUpdate", DateTime.Now);
                cmd.Parameters.AddWithValue("@lastUpdateBy", customer.createdBy);
                cmd.Parameters.AddWithValue("@cType", customer.custType);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception when adding customer: " + ex);
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
        public int addCountry(Country country)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            int countryId = -1;

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO country (country, createDate, createdBy, lastUpdate,lastUpdateBy) VALUES (@country, @createDate, @createdBy, @lastUpdate, @lastUpdateBy);" + "SELECT countryId FROM country ORDER BY countryId DESC LIMIT 1";
                cmd.Parameters.AddWithValue("@country", country.country);
                cmd.Parameters.AddWithValue("@createDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@createdBy", country.createdBy);
                cmd.Parameters.AddWithValue("@lastUpdate", DateTime.Now); 
                cmd.Parameters.AddWithValue("@lastUpdateBy", country.createdBy);
                countryId = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception when adding country: " + ex);
                countryId = -1;
            }
            finally
            {
                conn.Close();
            }
            return countryId;
        }
        public int addCity(City city)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            int cityId = -1;

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO city (city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@city, @countryId, @createDate, @createdBy, @lastUpdate, @lastUpdateBy);" + "SELECT cityId FROM city ORDER BY cityId DESC LIMIT 1";
                cmd.Parameters.AddWithValue("@city", city.city);
                cmd.Parameters.AddWithValue("@countryId", city.countryId);
                cmd.Parameters.AddWithValue("@createDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@createdBy", city.createdBy);
                cmd.Parameters.AddWithValue("@lastUpdate", DateTime.Now);
                cmd.Parameters.AddWithValue("@lastUpdateBy", city.createdBy);
                cityId = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception when adding country: " + ex);
                cityId = -1;
            }
            finally
            {
                conn.Close();
            }
            return cityId;
        }
        public int addAddress(Address address)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            int addressId = 1;

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                    "VALUES (@address, @address2, @cityId, @postalCode, @phone, @createDate, @createdBy, @lastUpdate, @lastUpdateBy);" + 
                    "SELECT addressId FROM address ORDER BY addressId DESC LIMIT 1";
                cmd.Parameters.AddWithValue("@address", address.address);
                cmd.Parameters.AddWithValue("@address2", address.address2);
                cmd.Parameters.AddWithValue("@cityId", address.cityId);
                cmd.Parameters.AddWithValue("@postalCode", address.postalCode);
                cmd.Parameters.AddWithValue("@phone", address.phone);
                cmd.Parameters.AddWithValue("@createDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@countryId", address.phone);
                cmd.Parameters.AddWithValue("@createdBy", address.createdBy);
                cmd.Parameters.AddWithValue("@lastUpdate", DateTime.Now);
                cmd.Parameters.AddWithValue("@lastupdateBy", address.createdBy);
                addressId = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception when adding country: " + ex);
                addressId = 1;
            }
            finally
            {
                conn.Close();
            }
            return addressId;
        }

        public bool deleteCustomer(int customerId)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM customer WHERE customerId = @customerId";
                cmd.Parameters.AddWithValue("@customerId", customerId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error when deleting Customer: " + ex);
                MessageBox.Show("Error: Customer has pending appointments, cannot delete!");
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }


        public grabCustomer customerdetails(int customerId)
        {
            MySqlConnection con = new MySqlConnection(connectionString);


            grabCustomer customerdetails = new grabCustomer();

            try
            {
                con.Open();
                string query = "SELECT customer.customerName, address.phone, address.address, address.address2, address.postalCode, city.city, country.country, customer.type FROM customer " +
                    "LEFT JOIN address ON customer.addressId = address.addressId " +
                    "LEFT JOIN city on address.cityId = city.cityId " +
                    "LEFT JOIN country ON city.countryId = country.countryId " +
                    "WHERE customer.customerId = @custId";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@custId", customerId);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customerdetails.customerName = reader["customerName"].ToString();
                        customerdetails.phoneNumber = reader["phone"].ToString();
                        customerdetails.address = reader["address"].ToString();
                        customerdetails.address2 = reader["address2"].ToString();
                        customerdetails.postalCode = reader["postalCode"].ToString();
                        customerdetails.city = reader["city"].ToString();
                        customerdetails.country = reader["country"].ToString();
                        customerdetails.CustType = reader["type"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error when gathering customer details: " + ex);
            }
            finally
            {
                con.Close();
            }
            return customerdetails;

        }

        public bool saveCustomerdetails(grabCustomer customerdetails)
        {
            MySqlConnection con = new MySqlConnection(connectionString);

            bool success = false;

            try
            {
                con.Open();
                //active, createDate, createdBy, lastUpdateBy
                string updateCmd = "UPDATE customer SET customerName = @customerName WHERE customerId = @customerId; " +
                    "UPDATE address SET address = @address, address2 = @address2, postalCode = @postalCode, phone = @phone " +
                    "WHERE addressId = (SELECT addressId FROM customer WHERE customerId = @customerId); " +
                    "UPDATE city SET city = @city " +
                    "WHERE cityId = (SELECT cityId FROM address WHERE addressId = (SELECT addressId FROM customer WHERE customerId = @customerId)); " +
                    "UPDATE country SET country = @country " +
                    "WHERE countryId = (SELECT countryId FROM city WHERE cityId = (SELECT cityId FROM address WHERE addressId = (SELECT addressId FROM customer WHERE customerId = @customerId)))";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = updateCmd;
                cmd.Parameters.AddWithValue("@customerId", customerdetails.customerId);
                //cmd.Parameters.AddWithValue("@lastUpdateBy", customerdetails.currentUser);
                cmd.Parameters.AddWithValue("@customerName", customerdetails.customerName);
                cmd.Parameters.AddWithValue("@address", customerdetails.address);
                cmd.Parameters.AddWithValue("@address2", customerdetails.address2);
                cmd.Parameters.AddWithValue("@city", customerdetails.city);
                cmd.Parameters.AddWithValue("@postalCode", customerdetails.postalCode);
                cmd.Parameters.AddWithValue("@phone", customerdetails.phoneNumber);
                cmd.Parameters.AddWithValue("@country", customerdetails.country);
                cmd.ExecuteNonQuery();

                success = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error when updating customer: " + ex);
                success = false;
            }
            finally
            {
                con.Close();
            }
            return success;
        }



        public int addAppointment(Appointment appt)
        {
            MySqlConnection con = new MySqlConnection(connectionString);

            int apptId = 1;

            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO appointment(customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES(@customerId, @userId, @title, @description, @Location, @contact, @type, @url, @start, @end, @createDate, @createdBy, @lastUpdate, @lastUpdateBy);" +
                "SELECT appointmentId FROM appointment  ORDER BY appointmentId DESC LIMIT 1";
                cmd.Parameters.AddWithValue("@customerId", appt.customerId);
                cmd.Parameters.AddWithValue("@userId", appt.userId);
                cmd.Parameters.AddWithValue("@title", "not needed");
                cmd.Parameters.AddWithValue("@description", "not needed");
                cmd.Parameters.AddWithValue("@location", "not needed");
                cmd.Parameters.AddWithValue("@contact", "not needed");
                cmd.Parameters.AddWithValue("@type", appt.type);
                cmd.Parameters.AddWithValue("@url", "not needed");
                cmd.Parameters.AddWithValue("@start", appt.start);
                cmd.Parameters.AddWithValue("@end", appt.end);
                cmd.Parameters.AddWithValue("@createDate", DateTime.UtcNow);
                cmd.Parameters.AddWithValue("@createdBy", appt.username);
                cmd.Parameters.AddWithValue("@lastUpdate", DateTime.Now);
                cmd.Parameters.AddWithValue("@lastUpdateBy", appt.username);
                apptId = (int)cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error when creating appointment: " + ex);
            }
            finally
            {
                con.Close();
            }
            return apptId;
        }


        public bool deleteAppointment(int apptId)
        {
            MySqlConnection con = new MySqlConnection(connectionString);

            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM appointment WHERE appointmentId = @appointmentId";
                cmd.Parameters.AddWithValue("@appointmentId", apptId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error when deleting appointment: " + ex);
                return false;
            }
            finally
            {
                con.Close();
            }
            return true;
        }

        public Appointment apptDetails(int apptId)
        {
            MySqlConnection con = new MySqlConnection(connectionString);

            Appointment apptInfo = new Appointment();

            try
            {
                con.Open();
                string query = "SELECT appointment.customerId, appointment.userId, appointment.title, appointment.description, appointment.location, appointment.contact, appointment.type, appointment.url, appointment.start, appointment.end, customer.customerName FROM appointment JOIN customer ON appointment.customerId = customer.customerId WHERE appointmentId = @apptId";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@apptId", apptId);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        apptInfo.customerId = (int)reader["customerId"];
                        apptInfo.customerName = reader["customerName"].ToString();
                        apptInfo.userId = (int)reader["userId"];
                        apptInfo.title = reader["title"].ToString();
                        apptInfo.description = reader["description"].ToString();
                        apptInfo.location = reader["location"].ToString();
                        apptInfo.contact = reader["contact"].ToString();
                        apptInfo.type = reader["type"].ToString();
                        apptInfo.url = reader["url"].ToString();
                        apptInfo.start = Convert.ToDateTime(reader["start"]);
                        apptInfo.start = Convert.ToDateTime(reader["end"]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error when gathering appointment info: " + ex);
            }
            finally
            {
                con.Close();
            }
            return apptInfo;
        }

        public bool updateAppointment (Appointment apptInfo)
        {
            MySqlConnection con = new MySqlConnection(connectionString);

            bool success = false;

            try
            {
                con.Open();
                string updateCmd = "UPDATE appointment SET customerId = @customerId, userId = @userId, title = @title, description = @description, location = @location, contact = @contact, type = @type, url = @url, start = @start, end = @end, createDate = @createDate, createdBy = @createdBy, lastUpdate = @lastUpdate, lastUpdateBy = @lastUpdateBy WHERE appointmentId = @appointmentId;";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = updateCmd;
                cmd.Parameters.AddWithValue("@appointmentId", apptInfo.appointmentId);
                cmd.Parameters.AddWithValue("@customerId", apptInfo.customerId);
                cmd.Parameters.AddWithValue("@userId", apptInfo.userId);
                cmd.Parameters.AddWithValue("@title", "not needed");
                cmd.Parameters.AddWithValue("@description", "not needed");
                cmd.Parameters.AddWithValue("@location", "not needed");
                cmd.Parameters.AddWithValue("@contact", "not needed");
                cmd.Parameters.AddWithValue("@type", apptInfo.type);
                cmd.Parameters.AddWithValue("@url", "not needed");
                cmd.Parameters.AddWithValue("@start", apptInfo.start);
                cmd.Parameters.AddWithValue("@end", apptInfo.end);
                cmd.Parameters.AddWithValue("@createDate", DateTime.UtcNow);
                cmd.Parameters.AddWithValue("@createdBy", apptInfo.username);
                cmd.Parameters.AddWithValue("@lastUpdate", DateTime.Now);
                cmd.Parameters.AddWithValue("@lastUpdateBy", apptInfo.username);
                cmd.ExecuteNonQuery();

                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error when updating appointment: " + ex);
                success = false;
            }
            finally
            {
                con.Close();
            }
            return success;
        }


        public bool overlappingAppt(DateTime apptStart, DateTime apptEnd)
        {
            MySqlConnection con = new MySqlConnection(connectionString);

            bool apptExists = false;

            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT EXISTS(SELECT * FROM appointment WHERE start <= @end AND end >= @start)";
                cmd.Parameters.AddWithValue("@start", apptStart);
                cmd.Parameters.AddWithValue("@end", apptEnd);

                if (cmd.ExecuteScalar().ToString() == "1")
                {
                    apptExists = true;
                }
            }
            catch (Exception ex) 
            { Console.WriteLine("Error when checking for appointments: " + ex);
            }
            finally
            {
                con.Close();
            }
            return apptExists;
        }


    }








    class DBcheck
    {
        private const string server = "c868-bananas.mysql.database.azure.com";
        private const string database = "db1";
        private const string DBusername = "BenderC868";
        private const string DBpassword = "p33lBack!";
        private const string port = "3306";
        private const string connectionString = "SERVER=" + server + ";" + "Port=" + port + ";" + "DATABASE=" + database + ";" + "Username=" + DBusername + ";" + "Password=" + DBpassword;
        
        public int findUserlogin(User userlogin)
        {
            MySqlConnection conn = new MySqlConnection(connectionString); 
            int userId = -1;

            string checkedUser;
            string checkedPassword;

            try
            {
                conn.Open();

                MySqlCommand checkUserName= conn.CreateCommand();
                checkUserName.CommandText = "SELECT EXISTS(SELECT userName FROM user WHERE userName = @username)";
                checkUserName.Parameters.AddWithValue("@username", userlogin.username);
                checkedUser = checkUserName.ExecuteScalar().ToString();


                MySqlCommand checkUserPass = conn.CreateCommand();
                checkUserPass.CommandText = "SELECT EXISTS(SELECT password FROM user WHERE BINARY password = @password AND userName =@username)";
                checkUserPass.Parameters.AddWithValue("@password", userlogin.password);
                checkUserPass.Parameters.AddWithValue("@username", userlogin.username);
                checkedPassword = checkUserPass.ExecuteScalar().ToString();


                if (checkedUser == "1" && checkedPassword == "1")
                {
                    MySqlCommand checkUserId = conn.CreateCommand();
                    checkUserId.CommandText = "SELECT userId FROM user WHERE BINARY password = @password AND userName =@username";
                    checkUserId.Parameters.AddWithValue("@password", userlogin.password);
                    checkUserId.Parameters.AddWithValue("@username", userlogin.username);
                    userId = (int)checkUserId.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid username or password" + ex);
            }


            return userId;
        }

     

       
    }

    
}
