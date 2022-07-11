using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Database;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem.Forms
{
    public partial class Login_Form : Form
    {

        private Dashboard_Form dashboardForm = null;

        // Manipulate dashboard form from login form
        public Login_Form(Dashboard_Form sourceForm)
        {
            InitializeComponent();
            this.dashboardForm = sourceForm as Dashboard_Form;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(255, 183, 19);
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            MyDB db = new MyDB();

            string username = textBox_username.Text;
            string password = textBox_password.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM app_users WHERE username = @usn AND password = @pass",db.GetConnection());

            command.Parameters.Add("@usn",MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            // Check if this username is exist or not 
            if (table.Rows.Count > 0) // if exist
            {
                dashboardForm.Enabled = true;
                this.Close();
            }
            else // if not
            {
                // Check if the username is empty
                if (username.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username to Login", "Empty Username", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                // Check if the password is empty
                else if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password to Login", "Empty Password", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                // Check if the user doesn't exist
                else 
                {
                    MessageBox.Show("Wrong Username or Password", "Wrong Data", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

        }
    }
}
