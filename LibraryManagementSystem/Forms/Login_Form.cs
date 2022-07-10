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
            dashboardForm.Enabled = true;
            this.Close();
        }
    }
}
