using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem.Database
{
    internal class MyDB
    {
        // The connection
        private MySqlConnection connection = new MySqlConnection("server=localhost;Port=3306;username=root;password=ArEr.2000;database=lms");

        // Create function to open the connection
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // Create function to close the connection
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        // function to return connection
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
