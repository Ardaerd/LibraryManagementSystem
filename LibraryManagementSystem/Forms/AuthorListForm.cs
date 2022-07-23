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
    public partial class AuthorListForm : Form
    {
        public AuthorListForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Display authors list in the list box
        private void AuthorListForm_Load(object sender, EventArgs e)
        {
            Author author = new Author();
            listBox_authors.DataSource = author.authorList();
            listBox_authors.DisplayMember = "FullName";
            listBox_authors.ValueMember = "id";
        }

        // Button to set the selected author id into the manage book form
        // and close the window
        private void button_SelectAuthor_Click(object sender, EventArgs e)
        {

        }
    }
}
