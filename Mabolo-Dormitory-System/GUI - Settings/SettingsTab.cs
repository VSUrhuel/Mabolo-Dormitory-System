using Mabolo_Dormitory_System.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace Mabolo_Dormitory_System.GUI___Settings
{
    public partial class SettingsTab : UserControl
    {
        private Main main;
        private DatabaseManager db;
        private String email;
        private Account account;

        public SettingsTab(Main main, String email)
        {
            this.email = email;
            this.db = new DatabaseManager();
            this.main = main;
            this.account = db.GetAccount(email);
            InitializeComponent();
            gunaLineTextBox1.Text = account.FirstName;
            gunaLineTextBox2.Text = account.LastName;
            gunaLineTextBox3.Text = account.UserName;
            label6.Text = account.UserName;
            vieeNewPassBut.Visible = false;
            hideNewPassBut.Visible = true;
            hideConfirmPassBut.Visible = true;
            viewConfirmPassBut.Visible = false;
            byte[] imageData = db.GetAccount(email).ImageData;
            pictureUser.Image = Image.FromStream(new MemoryStream(imageData));
        }

        private void changePicButton_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog()
            {
                InitialDirectory = "C:\\Users\\LENOVO\\Pictures",
                Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png;*.gif)|*.bmp;*.jpg;*.jpeg;*.png;*.gif",
                RestoreDirectory = true
            };

            //User didn't select a file so return a default value  
            if (dlg.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("No files selected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string filePath = dlg.FileName;
                // Read the image file into a byte array
                byte[] imageData;
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    imageData = new byte[fs.Length];
                    fs.Read(imageData, 0, imageData.Length);
                    fs.Close();
                }
                if (imageData.Length > (5 * 1024 * 1024))
                {
                    MessageBox.Show("Image size is too large.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!db.UpdateAccount(email, account.UserName, account.Password, account.Birthday, account.FirstName, account.LastName, imageData))
                    return;
                // Load the image from byte array into pictureUser
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pictureUser.Image = Image.FromStream(ms);
                }
               
                main.UpdateInformation(); 
            }
        }

        private void updateInfoBut_Click(object sender, EventArgs e)
        {
            if (account == null)
            {
                MessageBox.Show("Account not found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(gunaLineTextBox1.Text == "" || gunaLineTextBox2.Text == "" || gunaLineTextBox3.Text == "")
            {
                MessageBox.Show("Please fill up the fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(db.UpdateAccount(email, gunaLineTextBox3.Text, account.Password, account.Birthday, gunaLineTextBox1.Text, gunaLineTextBox2.Text, account.ImageData))
                MessageBox.Show("Information updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Information not updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if(gunaLineTextBox5.Text == "" && gunaLineTextBox6.Text == "" && gunaLineTextBox4.Text == "")
            {
                MessageBox.Show("Please fill up the fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(gunaLineTextBox4.Text != account.Password)
            {
                MessageBox.Show("Incorrect previous password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(ValidationClass.ValidatePassword(gunaLineTextBox5.Text) == false)
            {
                MessageBox.Show("Invalid new password. Password Should include an uppercase, symbol, numbers, and at least 8 letters.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(gunaLineTextBox5.Text != gunaLineTextBox6.Text)
            {
                MessageBox.Show("Passwords do not match", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(db.UpdateAccount(email, account.UserName, gunaLineTextBox5.Text, account.Birthday, account.FirstName, account.LastName, account.ImageData))
                MessageBox.Show("Password updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Password not updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void viewNewPassBut_Click(object sender, EventArgs e)
        {
            gunaLineTextBox5.PasswordChar = '\0';
            gunaLineTextBox5.UseSystemPasswordChar = false;
            hideNewPassBut.Visible = false;
            vieeNewPassBut.Visible = true;
        }

        private void hideNewPassBut_Click(object sender, EventArgs e)
        {
            gunaLineTextBox5.UseSystemPasswordChar = true;
            vieeNewPassBut.Visible = false;
            hideNewPassBut.Visible = true;
        }

        private void viewConfirmPassBut_Click(object sender, EventArgs e)
        {
            gunaLineTextBox6.PasswordChar = '\0';
            gunaLineTextBox6.UseSystemPasswordChar = false;
            

            viewConfirmPassBut.Visible = true;
            hideConfirmPassBut.Visible = false;
        }

        private void hideConfirmPassBut_Click(object sender, EventArgs e)
        {
            gunaLineTextBox6.UseSystemPasswordChar = true;
            viewConfirmPassBut.Visible = false;
            hideConfirmPassBut.Visible = true;
        }
    }
}
