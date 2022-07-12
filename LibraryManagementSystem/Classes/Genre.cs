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

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Create a function to edit genre
        public bool editGenre(int id, string name)
        {

            string query = "UPDATE genres SET name = @genre_name WHERE id = @genre_id";

            MySqlParameter[] parameters = new MySqlParameter[2];

            parameters[0] = new MySqlParameter("@genre_name", MySqlDbType.VarChar);
            parameters[0].Value = name;

            parameters[1] = new MySqlParameter("@genre_id", MySqlDbType.Int32);
            parameters[1].Value = id;

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
        public bool removeGenre(int id)
        {
            string query = "DELETE FROM genres WHERE id = @genre_id";

            MySqlParameter[] parameters = new MySqlParameter[1];

            parameters[0] = new MySqlParameter("@genre_id", MySqlDbType.Int32);
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

        // Create a function to return the table of genre
        public DataTable genreList()
        {
            DataTable table = new DataTable();
            table = db.getData("SELECT * FROM genres", null);

            return table;
        }


    }
}
