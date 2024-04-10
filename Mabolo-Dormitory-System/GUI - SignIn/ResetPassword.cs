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
                MessageBox.Show("Please fill up all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordText.LineColor = Color.Red;
                confirmPassword.LineColor = Color.Red;
                return;
            }
            else if (!ValidationClass.ValidatePassword(passwordText.Text))
            {
                
                MessageBox.Show("Must contain an uppercase, number, special character and at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordText.LineColor = Color.Red;
                return;
            }
            else if(passwordText.Text != confirmPassword.Text)
            {
                MessageBox.Show("Password does not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                confirmPassword.LineColor = Color.Red;
                return;
            }
            else
            {
                passwordText.LineColor = Color.FromArgb(46, 204, 113);
                confirmPassword.LineColor = Color.FromArgb(46, 204, 113);
                if (db.AdminPassReset(email, passwordText.Text))
                    MessageBox.Show("Password has been reset.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Password reset failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeViewButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void passwordText_MouseClick(object sender, MouseEventArgs e)
        {
            passwordText.LineColor = Color.FromArgb(46, 204, 113);
        }

        private void confirmPassword_MouseClick(object sender, MouseEventArgs e)
        {
            confirmPassword.LineColor = Color.FromArgb(46, 204, 113);
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
    }
}
