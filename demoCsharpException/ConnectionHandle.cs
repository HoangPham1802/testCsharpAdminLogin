using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace demoCsharpException
{
    public static class ConnectionHandle
    {
        private static string host = "localhost";
        private static string db = "c1608l";
        private static string username = "root";
        private static string password = "";

        public static MySqlConnection getConnection()
        {
            string url = "SERVER = " + host + "; DATABASE = " + db + "; UID = " + username + "; PASSWORD = " + password + ";";
            MySqlConnection connect = new MySqlConnection(url);
            return connect;
        }
    }
}
