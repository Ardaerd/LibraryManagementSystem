using LibraryManagementSystem.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Classes
{
    internal class Books
    {
        MyDB db = new MyDB();

        // Create a function to add author
        public bool addAuthor(string isbn, string title, int author_id, int genre_id,int quantity,double price, string publisher, DateTime date_received,string description,byte cover)
        {
            string query = "INSERT INTO books(isbn,title,author,genre,quantity,price,publisher,date_received,description,cover) VALUE(@isbn,@title,@author,@genre,@quantity,@price,@publisher,@date_received,@description,@cover)";

            MySqlParameter[] parameters = new MySqlParameter[10];

            parameters[0] = new MySqlParameter("@isbn", MySqlDbType.VarChar);
            parameters[0].Value = isbn;

            parameters[1] = new MySqlParameter("@title", MySqlDbType.VarChar);
            parameters[1].Value = title;

            parameters[2] = new MySqlParameter("@author", MySqlDbType.Int32);
            parameters[2].Value = author_id;

            parameters[3] = new MySqlParameter("@genre", MySqlDbType.Int32);
            parameters[3].Value = genre_id;

            parameters[4] = new MySqlParameter("@quantity", MySqlDbType.Int32);
            parameters[4].Value = quantity;

            parameters[5] = new MySqlParameter("@price", MySqlDbType.Double);
            parameters[5].Value = price;

            parameters[6] = new MySqlParameter("@publisher", MySqlDbType.VarChar);
            parameters[6].Value = publisher;

            parameters[7] = new MySqlParameter("@date_received", MySqlDbType.Date);
            parameters[7].Value = date_received;

            parameters[8] = new MySqlParameter("@description", MySqlDbType.VarChar);
            parameters[8].Value = description;

            parameters[9] = new MySqlParameter("@cover", MySqlDbType.Blob);
            parameters[9].Value = cover;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
