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
        private List<Payment> paymentList;
        private Point lastLocation;
        private bool mouseDown;
        public PaymentsSummary()
        {
            this.paymentList = new List<Payment>();
            this.db = new DatabaseManager();
            InitializeComponent();
            float total = ((db.GetSumEvents() + db.GetSumRegularPayable() * 5) * db.GetAllUsersExcpetAdmin().Count);

            float remainingBalance = db.GetSumRemainingBalance();
            float received = total - db.GetSumRemainingBalance() - db.GetAllSumPresentAttendances();
            receivedAmount.Text = "₱ " + (received.ToString("N2"));
            pendingCollectibles.Text = "₱ " + (total - received).ToString("N2");
            SetUpTable();
        }

        private void SetUpTable()
        {
            dormerTableView.DataSource = null;
            dormerTableView.Rows.Clear();
            dormerTableView.DefaultCellStyle.Font = new Font("Century Gothic", 12);
            dormerTableView.DefaultCellStyle.ForeColor = Color.Black;
            dormerTableView.AllowUserToResizeRows = false;
            dormerTableView.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dormerTableView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(40, 167, 69);
            dormerTableView.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            dormerTableView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dormerTableView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dormerTableView.RowTemplate.Height = 40;
            dormerTableView.Columns["Remarks"].Width = 200;

            dormerTableView.Columns["Amount"].DefaultCellStyle.Format = "₱ #,##0.00";


            paymentList = db.GetAllPayment();
            foreach(Payment p in paymentList)
            {
                dormerTableView.Rows.Add(p.FK_UserId_Payment, db.GetUser(p.FK_UserId_Payment).LastName,p.PaymentDate.ToString("MMMM dd, yyyy"), p.Amount, p.Remarks);
            }   
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
