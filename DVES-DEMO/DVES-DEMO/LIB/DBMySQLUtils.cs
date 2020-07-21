using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DVES_DEMO
{
    class DBMySQLUtils
    {
        public static MySqlConnection
                GetDBConnection(string host, int port, string database, string username, string password)
        {
            // Connection String.
            String connString = "Server=" + host + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password + ";charset= utf8";  // charset để đưa font tiếng việt lên mysql

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }
    }
}
