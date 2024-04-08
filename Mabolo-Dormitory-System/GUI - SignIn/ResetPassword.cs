using Mabolo_Dormitory_System.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mabolo_Dormitory_System
{
    public partial class ResetPassword : Form
    {
        private DatabaseManager db;
        private String email;
        private Point lastLocation;
        private bool mouseDown;
        public ResetPassword(String email)
        {
            this.email = email;
            this.db = new DatabaseManager();
            InitializeComponent();
        }

        private void updatePassButton_Click(object sender, EventArgs e)
        {
            if(!ValidationClass.ValidateFieldsNotEmpty(new String[] { passwordText.Text, confirmPassword.Text }))
            {
                passReview.Text = "Please fill up all fields.";
                passwordText.LineColor = Color.Red;
                confirmPassword.LineColor = Color.Red;
                return;
            }
            else if (!ValidationClass.ValidatePassword(passwordText.Text))
            {
                
                passReview.Text = "Must contain an uppercase, number, special character";
                passReview2.Text = " and at least 8 characters long.";
                passwordText.LineColor = Color.Red;
                return;
            }
            else if(passwordText.Text != confirmPassword.Text)
            {
                confirmPassText.Text = "Password does not match.";
                confirmPassword.LineColor = Color.Red;
                return;
            }
            else
            {
                passReview.Text = "";
                passReview2.Text = "";
                confirmPassText.Text = "";
                passwordText.LineColor = Color.FromArgb(46, 204, 113);
                confirmPassword.LineColor = Color.FromArgb(46, 204, 113);
                if (db.AdminPassReset(email, passwordText.Text))
                    MessageBox.Show("Password has been reset.");
                else
                    MessageBox.Show("Password reset failed.");
            }
        }

        private void closeViewButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void passwordText_MouseClick(object sender, MouseEventArgs e)
        {
            passwordText.LineColor = Color.FromArgb(46, 204, 113);
            passReview.Text = "";
            passReview2.Text = "";
        }

        private void confirmPassword_MouseClick(object sender, MouseEventArgs e)
        {
            confirmPassword.LineColor = Color.FromArgb(46, 204, 113);
            confirmPassText.Text = "";
        }

        private void UpdateForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void UpdateForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void UpdateForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void passwordText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                updatePassButton_Click(sender, e);
            }
            if(ValidationClass.ValidatePassword(passwordText.Text))
            {
                passReview.Text = "Password is strong.";
                passReview2.Text = "";
            }
        }
    }
}
