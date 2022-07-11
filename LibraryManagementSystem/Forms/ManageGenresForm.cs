using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Classes;

namespace LibraryManagementSystem.Forms
{
    public partial class ManageGenresForm : Form
    {
        Genre genre = new Genre();
        public ManageGenresForm()
        {
            InitializeComponent();
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_close_MouseEnter(object sender, EventArgs e)
        {
            label_close.BackColor = Color.Red;
        }

        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            Color.FromArgb(255, 183, 19);
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;

            if (name.Trim().Equals(""))
            {
                MessageBox.Show("Enter the genre name", "Empty Genre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                genre.addGenre(name);
            }
        }
    }
}
