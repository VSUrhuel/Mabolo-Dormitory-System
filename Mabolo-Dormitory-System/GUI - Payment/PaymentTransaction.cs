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
        public PaymentTransaction(User u)
        {
            db = new DatabaseManager();
            InitializeComponent();
            MessageBox.Show(u.ToString());
            label1.Text = u.UserId;
            label2.Text = u.FirstName;
            label3.Text = u.LastName;
            label4.Text = db.GetUserPayable(u.UserId).RemainingBalance.ToString();
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
        }
    }
}
