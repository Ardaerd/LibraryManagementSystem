using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Database;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem.Classes
{
    internal class Genre
    {
        MyDB db = new MyDB();

        // Create a function to add genre
        public bool addGenre(string name)
        {
            string query = "INSERT INTO genres(name) VALUE(@genre_name)";

            MySqlParameter[] parameters = new MySqlParameter[1];
            parameters[0] = new MySqlParameter("@genre_name", MySqlDbType.VarChar); 
            parameters[0].Value = name;

            db.setData(query,parameters);

            return true;
        }
        // Create a function to edit genre
        public bool editGenre(int id, string name)
        {

            return true;
        }
        // Create a function to remove genre
        public bool removeGenre(string name)
        {

            return true;
        }
        // Create a function to return the table of genre
        public DataTable genreList()
        {

            return new DataTable();
        }


    }
}
