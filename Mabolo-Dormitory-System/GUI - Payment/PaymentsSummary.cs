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
    public partial class PaymentsSummary : Form
    {
        private DatabaseManager db;
        private Point lastLocation;
        private bool mouseDown;
        public PaymentsSummary()
        {
            this.db = new DatabaseManager();
            InitializeComponent();
            float total = ((db.GetSumEvents() + db.GetSumRegularPayable() * 5) *db.GetAllUsersExcpetAdmin().Count);
            float remainingBalance = db.GetSumRemainingBalance();   
            
            float received = total - db.GetSumRemainingBalance();
            receivedAmount.Text = "₱ " + (received.ToString("N2"));
            pendingCollectibles.Text = "₱ " + (total - received).ToString("N2");
        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void closeViewButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
