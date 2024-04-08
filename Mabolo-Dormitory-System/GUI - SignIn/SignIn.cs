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
using System.Net;
using System.Net.Mail;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mabolo_Dormitory_System
{
    public partial class SignIn : Form
    {
        private Main main;
        private DatabaseManager db;
        public SignIn()
        {
            this.db = new DatabaseManager();
            InitializeComponent();
            hideViewBut.Visible = false;
            viewBut.Visible = true;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void emailTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            emailReview.Text = "";
            emailTextBox.Text = "";
            emailTextBox.ForeColor = Color.Black;
            emailTextBox.FocusedLineColor = Color.ForestGreen;
            emailTextBox.LineColor = Color.FromArgb(46, 204, 113);
        }

        private void passwordTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            emailReview.Text = "";
            passwordTextBox.Text = "";
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.ForeColor = Color.Black;
            passwordTextBox.LineColor = Color.FromArgb(46, 204, 113);
            passwordTextBox.FocusedLineColor = Color.ForestGreen;
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            emailReview.Text = "";
            String email = emailTextBox.Text;
            String pass = passwordTextBox.Text;
            if(!ValidationClass.ValidateFieldsNotEmpty(new String[] { email, pass }) || (email.Equals("Email") && pass.Equals("Password")))
            {
                MessageBox.Show("Please fill up all fields");
                emailTextBox.FocusedLineColor = Color.Red;
                passwordTextBox.FocusedLineColor = Color.Red;
                emailTextBox.LineColor = Color.Red;
                passwordTextBox.LineColor = Color.Red;
                return;
            }
            if (!ValidationClass.ValidateEmail(email))
            {
                emailReview.Text = "Invalid Email";
                emailTextBox.FocusedLineColor = Color.Red;
                emailTextBox.LineColor = Color.Red;
                return;
            }

            // Check if account exists
            if(db.AccountExist(email, pass))
            {
                main = new Main(email);
                main.Show();
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("Invalid Email or Password");
                emailTextBox.FocusedLineColor = Color.Red;
                passwordTextBox.FocusedLineColor = Color.Red;
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

        private void forgotPass_Click(object sender, EventArgs e)
        {
            if(emailTextBox.Text == "Email")
            {
                MessageBox.Show("Please input your email first");
                return;
            }
            if (!ValidationClass.ValidateEmail(emailTextBox.Text))
            {
                emailReview.Text = "Invalid Email";
                emailTextBox.LineColor = Color.Red;
                return;
            }
            if (db.CheckAdminEmailExists(emailTextBox.Text))
            {
                SendOTPCode(emailTextBox.Text);
                emailReview.ForeColor = Color.Green;
                emailTextBox.LineColor = Color.FromArgb(46, 204, 113);   
            }
            else
            {
                emailReview.Text = "Email not found";
                emailTextBox.LineColor = Color.Red;
            }
        }
        
        private void SendOTPCode(String email)
        {
            
            String OTPCode = GenerateOTP(6);
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("22-1-00109@vsu.edu.ph");
            mail.To.Add(email);
            mail.Subject = "OTP Code Verification [Mabolo Dormitory System]";
            mail.IsBodyHtml = true;
            string htmlBody = $@"
            <html>
            <head>
            <style>
              body {{
                font-family: Arial, sans-serif; 
                font-size: 16px;
              }}
              b {{
                font-weight: bold;
              }}
            </style>
            </head>
            <body>
              <p>Hi,</p>
              <p>Your OTP code for verification is: <b>{OTPCode}</b></p>
              <p>Please enter this code to reset your password.</p>
              <p>This code is valid as long as this is the most recent code. Please do not share it with anyone.</p>
              <p>Thank you, and God bless!</p>
            </body>
            </html>";
            mail.Body = htmlBody;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            NetworkCredential NetworkCred = new NetworkCredential();
            NetworkCred.UserName = "22-1-00109@vsu.edu.ph";
            NetworkCred.Password = "laurente1234";
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = NetworkCred;
            smtp.Port = 587;
            MessageBox.Show("Sending email...\nThis may take a while.");
            try
            {
                smtp.Send(mail);
                OTPForm oTPForm = new OTPForm(OTPCode, email, this);
                SetFormLocation(oTPForm);
                oTPForm.Owner = this;
                oTPForm.Show();
                MessageBox.Show("OTP code sent successfully to " + email);  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message);
               
            }
        }
        
        private string GenerateOTP(int length)
        {
            Random random = new Random();
            StringBuilder otp = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                otp.Append(random.Next(0, 10)); 
            }
            return otp.ToString();
        }
        
        private void SetFormLocation(Form form)
        {
            form.StartPosition = FormStartPosition.Manual;
            int x = Screen.PrimaryScreen.Bounds.Left + 400;
            int y = ((Screen.PrimaryScreen.Bounds.Height - form.Height) / 2);
            form.Location = new Point(x, y);
        }

        private void passwordTextBox_Click(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = true;
        }
    }
}
