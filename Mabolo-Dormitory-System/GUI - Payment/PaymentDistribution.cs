using Mabolo_Dormitory_System.Classes;
using Mabolo_Dormitory_System.GUI___Dormers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mabolo_Dormitory_System.GUI___Payment
{
    public partial class PaymentDistribution : Form
    {
        private DatabaseManager db;
        private PaymentsTab form;
        private roomTab formRoom;
        private Point lastLocation;
        private bool mouseDown;
        public PaymentDistribution(User u, PaymentsTab form)
        {
            this.form = form;
            this.db = new DatabaseManager();
            InitializeComponent();
            paidAmount.Text = "₱ " + db.GetSumUserPayments(u.UserId).ToString("N2");
            pendingPayable.Text = "₱ " + db.GetUserPayableBalance(u.UserId).ToString("N2");
            float fines = (db.GetSumEvents() - db.GetSumPresentAttendances(u.UserId)) + db.GetUserAccFines(u.UserId);
            cleaningMeetFines.Text = "₱ " + (db.GetSumEvents() - db.GetSumPresentAttendances(u.UserId)).ToString("N2");
            accFines.Text = "₱ " + db.GetUserAccFines(u.UserId).ToString("N2");
            semPayable.Text = "₱ " + (db.GetTotalPayable(u.UserId) - fines).ToString("N2");
            totalPayable.Text = "₱ " + db.GetTotalPayable(u.UserId).ToString("N2");
        }

        public PaymentDistribution(User u, roomTab form)
        {
            this.formRoom = form;
            this.db = new DatabaseManager();
            InitializeComponent();
            paidAmount.Text = "₱ " + db.GetSumUserPayments(u.UserId).ToString("N2");
            pendingPayable.Text = "₱ " + db.GetUserPayableBalance(u.UserId).ToString("N2");
            float fines = (db.GetSumEvents() - db.GetSumPresentAttendances(u.UserId)) + db.GetUserAccFines(u.UserId);
            cleaningMeetFines.Text = "₱ " + (db.GetSumEvents() - db.GetSumPresentAttendances(u.UserId)).ToString("N2");
            accFines.Text = "₱ " + db.GetUserAccFines(u.UserId).ToString("N2");
            semPayable.Text = "₱ " + (db.GetTotalPayable(u.UserId) - fines).ToString("N2");
            totalPayable.Text = "₱ " + db.GetTotalPayable(u.UserId).ToString("N2");
        }
        private void closeViewButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void PaymentDistribution_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void PaymentDistribution_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void PaymentDistribution_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
