using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp1.Resources
{
    public class User
    {
        public int userId {  get; set; }
        public string username { get; set; }
        public string password { get; set; }   
        public bool active { get; set; }

        public User()
        {
            username = string.Empty;
        }

        public User(string _username, string _password)
        {
            username = _username;
            password = _password;
            active = true;
        }
    }

    class textfile
    { 
     public void logUserAttempts(string logText)
        {
            string fileName = "loginRecord.txt";
            string logPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, fileName);
    
        if (!File.Exists(logPath))
        {
            var file = File.Create(logPath);
            file.Close();
            TextWriter textWriter = new StreamWriter(logPath);
            textWriter.WriteLine(logText);
            textWriter.Close();
        }
        else if (File.Exists(logPath))
        {
            using (var textWriter = new StreamWriter(logPath, true))
            {
                textWriter.WriteLine(logText);
            }
        }
       }
    }
}
