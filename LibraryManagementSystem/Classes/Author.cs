using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Database;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace LibraryManagementSystem.Classes
{
    internal class Author
    {
        MyDB db = new MyDB();

        // Create a function to add author
        public bool addAuthor(string fname,string lname, string education, string bio)
        {
            string query = "INSERT INTO authors(firstname,lastname,education,bio) VALUE(@fname,@lname,@education,@bio)";

            MySqlParameter[] parameters = new MySqlParameter[4];

            parameters[0] = new MySqlParameter("@fname", MySqlDbType.VarChar);
            parameters[0].Value = fname;

            parameters[1] = new MySqlParameter("@lname", MySqlDbType.VarChar);
            parameters[1].Value = lname;

            parameters[2] = new MySqlParameter("@education", MySqlDbType.VarChar);
            parameters[2].Value = education;

            parameters[3] = new MySqlParameter("@bio", MySqlDbType.Text);
            parameters[3].Value = bio;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool editAuthor(int id, string fname, string lname, string education, string bio)
        {
            string query = "UPDATE authors SET firstname = @firstname,lastname = @lastname,education = @education,bio = @bio WHERE id = @id";

            MySqlParameter[] parameters = new MySqlParameter[5];

            parameters[0] = new MySqlParameter("@firstname", MySqlDbType.VarChar);
            parameters[0].Value = fname;

            parameters[1] = new MySqlParameter("@lastname", MySqlDbType.VarChar);
            parameters[1].Value = lname;

            parameters[2] = new MySqlParameter("@education", MySqlDbType.VarChar);
            parameters[2].Value = education;

            parameters[3] = new MySqlParameter("@bio", MySqlDbType.Text);
            parameters[3].Value = bio;

            parameters[4] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameters[4].Value = id;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Create a function to remove genre
        public bool removeAuthor(int id)
        {
            string query = "DELETE FROM authors WHERE id = @author_id";

            MySqlParameter[] parameters = new MySqlParameter[1];

            parameters[0] = new MySqlParameter("@author_id", MySqlDbType.Int32);
            parameters[0].Value = id;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Create a function to return the table of author
        public DataTable authorList()
        {
            DataTable table = new DataTable();
            table = db.getData("SELECT id, concat(firstname, ' ', lastname) as FullName, education, bio FROM authors", null);

            return table;
        }
    }
}
