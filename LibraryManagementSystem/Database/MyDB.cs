using System;
using System.Collections.Generic;
using System.Data;
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

        // function to return a table of data
        // parameters = the parameters of the query
        public DataTable getData(string query, MySqlParameter[] parameters)
        {
            MySqlCommand command = new MySqlCommand(query, GetConnection());

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        // Function to set data and execute query
        public void setData(string query, MySqlParameter[] parameters)
        {
            MySqlCommand command = new MySqlCommand(query, GetConnection());

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }
            openConnection();

            command.ExecuteNonQuery();

            closeConnection();
        }
    }
}
