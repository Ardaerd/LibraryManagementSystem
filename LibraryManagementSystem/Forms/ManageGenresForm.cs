using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
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
                if (genre.addGenre(name))
                {
                    MessageBox.Show("New genre is added successfully", "New Genre", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // populate datagridView with genres
                    dataGridView_genres.DataSource = genre.genreList();
                }
                else
                {
                    MessageBox.Show("Genre is not added", "Adding Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            try
            {
                string newName = textBox_name.Text;
                int id = Convert.ToInt32(textBox_id.Text);

                if (newName.Trim().Equals(""))
                {
                    MessageBox.Show("Enter the genre name", "Empty Genre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (genre.editGenre(id, newName))
                    {
                        MessageBox.Show("Genre is edited successfully", "Edit Genre", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        // populate datagridView with genres
                        dataGridView_genres.DataSource = genre.genreList();
                    }
                    else
                    {
                        MessageBox.Show("Genre is not edited", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,"Invalid ID");
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_id.Text);

                    if (genre.removeGenre(id))
                    {
                        MessageBox.Show("Genre is removed successfully", "Remove Genre", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        // populate datagridView with genres
                        dataGridView_genres.DataSource = genre.genreList();

                        // clear the textBoxes after removing
                        textBox_name.Text = "";
                        textBox_id.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Genre is not removed", "Remove Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Invalid ID");
            }
        }

        private void ManageGenresForm_Load(object sender, EventArgs e)
        {
            // populate datagridView with genres
            dataGridView_genres.DataSource = genre.genreList();

            // customize datagridView header
            dataGridView_genres.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_genres.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Calibri", 14, FontStyle.Bold);
            dataGridView_genres.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_genres.Font = new System.Drawing.Font("Calibri", 10, FontStyle.Bold);


            dataGridView_genres.EnableHeadersVisualStyles = false;

        }

        private void dataGridView_genres_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = dataGridView_genres.CurrentRow.Cells[0].Value.ToString();
            textBox_name.Text = dataGridView_genres.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
