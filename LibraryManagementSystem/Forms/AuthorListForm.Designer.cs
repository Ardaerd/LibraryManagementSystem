namespace LibraryManagementSystem.Forms
{
    partial class AuthorListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_login = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_authors = new System.Windows.Forms.ListBox();
            this.button_SelectAuthor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_login
            // 
            this.label_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.label_login.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login.Location = new System.Drawing.Point(-7, -3);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(427, 83);
            this.label_login.TabIndex = 1;
            this.label_login.Text = "List Of Authors";
            this.label_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 54);
            this.label1.TabIndex = 8;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox_authors
            // 
            this.listBox_authors.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_authors.FormattingEnabled = true;
            this.listBox_authors.ItemHeight = 29;
            this.listBox_authors.Location = new System.Drawing.Point(12, 103);
            this.listBox_authors.Name = "listBox_authors";
            this.listBox_authors.Size = new System.Drawing.Size(395, 352);
            this.listBox_authors.TabIndex = 9;
            // 
            // button_SelectAuthor
            // 
            this.button_SelectAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(91)))));
            this.button_SelectAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SelectAuthor.ForeColor = System.Drawing.Color.White;
            this.button_SelectAuthor.Location = new System.Drawing.Point(67, 461);
            this.button_SelectAuthor.Name = "button_SelectAuthor";
            this.button_SelectAuthor.Size = new System.Drawing.Size(271, 53);
            this.button_SelectAuthor.TabIndex = 46;
            this.button_SelectAuthor.Text = "Select Author";
            this.button_SelectAuthor.UseVisualStyleBackColor = false;
            this.button_SelectAuthor.Click += new System.EventHandler(this.button_SelectAuthor_Click);
            // 
            // AuthorListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(163)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(419, 523);
            this.Controls.Add(this.button_SelectAuthor);
            this.Controls.Add(this.listBox_authors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthorListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorListForm";
            this.Load += new System.EventHandler(this.AuthorListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_authors;
        private System.Windows.Forms.Button button_SelectAuthor;
    }
}