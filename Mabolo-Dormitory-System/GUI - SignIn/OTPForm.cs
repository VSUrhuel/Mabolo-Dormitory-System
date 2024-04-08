using Guna.UI.WinForms;
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
    public partial class OTPForm : Form
    {
        private String otpCode;
        private String email;
        private Point lastLocation;
        private bool mouseDown;
        private Form form;
        
        public OTPForm(String otp, String email, Form form)
        {
            this.form = form;
            this.otpCode = otp;
            this.email = email;
            InitializeComponent();
        }

        private void verifyViewButton_Click(object sender, EventArgs e)
        {
            String otp = "";
            foreach(Control c in this.Controls)
            {
                if(c is GunaLineTextBox)
                {
                    GunaLineTextBox tb = (GunaLineTextBox)c;
                    otp += tb.Text;
                }
            }
            
            char[] rev = otp.ToCharArray();
            Array.Reverse(rev);
            otp = new string(rev);
            if (otp == otpCode)
            {
                MessageBox.Show("Verification is Succesfull.");
                ResetPassword resetPassword = new ResetPassword(email);
                SetFormLocation(resetPassword);
                resetPassword.Owner = form;
                resetPassword.Show();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("OTP Code is incorrect");
            }
        }

        private void closeViewButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void SetFormLocation(Form form)
        {
            form.StartPosition = FormStartPosition.Manual;
            int x = Screen.PrimaryScreen.Bounds.Left + 400;
            int y = ((Screen.PrimaryScreen.Bounds.Height - form.Height) / 2);
            form.Location = new Point(x, y);
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
