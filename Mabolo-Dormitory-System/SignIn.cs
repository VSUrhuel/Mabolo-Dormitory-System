using Mabolo_Dormitory_System.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mabolo_Dormitory_System
{
    public partial class SignIn : Form
    {
        Main main;
        DatabaseManager db;
        public SignIn()
        {
            db = new DatabaseManager();
            main = new Main();
            main.Hide();
            InitializeComponent();
            hideViewBut.Visible = true;
            viewBut.Visible = false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void gunaPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void emailTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            emailTextBox.Text = "";
            emailTextBox.ForeColor = Color.Black;
            emailTextBox.LineColor = Color.FromArgb(46, 204, 113);
        }

        private void passwordTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            passwordTextBox.Text = "";
            passwordTextBox.ForeColor = Color.Black;
            passwordTextBox.LineColor = Color.FromArgb(46, 204, 113);
        }

        private void updateViewButton_Click(object sender, EventArgs e)
        {
            String email = emailTextBox.Text;
            String pass = passwordTextBox.Text;
            if(!ValidationClass.ValidateFieldsNotEmpty(new String[] { email, pass }) || (email.Equals("Email") && pass.Equals("Password")))
            {
                MessageBox.Show("Please fill up all fields");
                emailTextBox.LineColor = Color.Red;
                passwordTextBox.LineColor = Color.Red;
                return;
            }
            if (!ValidationClass.ValidateEmail(email))
            {
                emailReview.Text = "Invalid Email";
                emailReview.ForeColor = Color.Red;
                emailTextBox.LineColor = Color.Red;
                return;
            }
            if(db.AccountExist(email, pass))
            {
                MessageBox.Show("Login Successful");
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Email or Password");
                emailReview.ForeColor = Color.Red;
                emailTextBox.LineColor = Color.Red; 
                passwordTextBox.LineColor = Color.Red;
            }


            
        }

        private void hideViewBut_Click(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = true;
            hideViewBut.Visible = false;
            viewBut.Visible = true;
        }

        private void viewBut_Click(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = false;
            viewBut.Visible = false;
            hideViewBut.Visible = true;
        }
    }
}
