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
    public partial class ManageAuthorForm : Form
    {
        private Author author = new Author();
        public ManageAuthorForm()
        {
            InitializeComponent();
        }

        // Add a new author
        private void button_add_Click(object sender, EventArgs e)
        {
            string first_name = textBox_firstname.Text;
            string last_name = textBox_lastname.Text;
            string education = textBox_education.Text;
            string bio = richTextBox_bio.Text;

            if (first_name.Trim().Equals("") || last_name.Trim().Equals(""))
            {
                MessageBox.Show("You need To Enter First Name & Last Name", "Empty Field", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                if (author.addAuthor(first_name, last_name, education, bio))
                {
                    MessageBox.Show("Author added successfully", "Adding Author", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    dataGridView_author.DataSource = author.authorList();
                }
                else
                {
                    MessageBox.Show("Author couldn't added!", "Adding Author Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageAuthorForm_Load(object sender, EventArgs e)
        {
            // show table in datagridView
            dataGridView_author.DataSource = author.authorList();

            // customize datagridView header
            dataGridView_author.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_author.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Calibri", 14, FontStyle.Bold);
            dataGridView_author.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_author.Font = new System.Drawing.Font("Calibri", 10, FontStyle.Bold);


            dataGridView_author.EnableHeadersVisualStyles = false;
        }

        private void label_close_MouseEnter(object sender, EventArgs e)
        {
            label_close.BackColor = Color.Red;
        }

        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            Color.FromArgb(255, 183, 19);
        }

        private void dataGridView_author_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = dataGridView_author.CurrentRow.Cells[0].Value.ToString();
            textBox_firstname.Text = dataGridView_author.CurrentRow.Cells[1].Value.ToString();
            textBox_lastname.Text = dataGridView_author.CurrentRow.Cells[2].Value.ToString();
            textBox_education.Text = dataGridView_author.CurrentRow.Cells[3].Value.ToString();
            richTextBox_bio.Text = dataGridView_author.CurrentRow.Cells[4].Value.ToString();

        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_id.Text);
                string firstName = textBox_firstname.Text;
                string lastName = textBox_lastname.Text;
                string education = textBox_education.Text;
                string bio = richTextBox_bio.Text;

                if (firstName.Trim().Equals("") || lastName.Trim().Equals("") || education.Trim().Equals("") || bio.Trim().Equals(""))
                {
                    MessageBox.Show("Fill the fields", "Empty author fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (author.editAuthor(id, firstName,lastName,education,bio))
                    {
                        MessageBox.Show("Author is edited successfully", "Edit Author", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        // populate datagridView with genres
                        dataGridView_author.DataSource = author.authorList();
                    }
                    else
                    {
                        MessageBox.Show("Author is not edited", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Invalid ID");
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_id.Text);

                
                    if (author.removeAuthor(id))
                    {
                        MessageBox.Show("Author is removed successfully", "Remove Author", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        // populate datagridView with genres
                        dataGridView_author.DataSource = author.authorList();
                    }
                    else
                    {
                        MessageBox.Show("Author is not removed", "Remove Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Invalid ID");
            }
        }
    }
}
