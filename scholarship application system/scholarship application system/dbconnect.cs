using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace scholarship_application_system
{
    internal class dbconnect
    {
        private string server = Properties.Settings.Default.server;
        private string port = Properties.Settings.Default.port;
        private string username = Properties.Settings.Default.username;
        private string password = Properties.Settings.Default.password;
        private string dbase = Properties.Settings.Default.dbase;
        public MySqlConnection dbcon = new MySqlConnection();

        public void Connect()
        {
            string constring = "server =" + server + ";port =" + port + ";username =" + username + "; Database=" + dbase + "; charset=utf8";
            dbcon = new MySqlConnection(constring);
            dbcon.Open();
        }

        public void Close()
        {
            dbcon.Close();
            dbcon.Dispose();
        }
    }
}
