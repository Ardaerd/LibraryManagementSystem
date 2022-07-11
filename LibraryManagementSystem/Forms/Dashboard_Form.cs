using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
    public partial class Dashboard_Form : Form
    {
        public Dashboard_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Form_Shown(object sender, EventArgs e)
        {
            this.Enabled = false;
            // Show the login form
            Login_Form loginForm = new Login_Form(this);
            loginForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Show the login form
            ManageGenresForm manageGenresForm = new ManageGenresForm();
            manageGenresForm.Show();
        }
    }
}
