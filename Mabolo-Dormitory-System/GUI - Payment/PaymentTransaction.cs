using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mabolo_Dormitory_System.Classes;

namespace Mabolo_Dormitory_System.GUI___Payment
{
    public partial class PaymentTransaction : Form
    {
        private DatabaseManager db;
        private Point lastLocation;
        private PaymentsTab form;
        private bool mouseDown;
        public PaymentTransaction(User u, PaymentsTab form)
        {
            this.form = form;
            
            db = new DatabaseManager();
            InitializeComponent();
            
            label1.Text = u.UserId;
            label2.Text = u.FirstName;
            label3.Text = u.LastName;
            label4.Text = db.GetUserPayableBalance(u.UserId).ToString();    
            label5.Text = DateTime.Now.ToString("MMMM dd, yyyy");
        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void closeViewButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void addPaymentButton_Click(object sender, EventArgs e)
        {
            if(amountText.Text == "" || remarksText.Text == "")
            {
                MessageBox.Show("Please input all fields");
                return;
            }
            int index = db.GetAllPayment().Count + 1;  
            db.AddPayment(new Payment(index, DateTime.Now, float.Parse(amountText.Text), remarksText.Text, label1.Text));
            MessageBox.Show("Payment Addded");
            form.refreshBut_Click(sender, e);
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
