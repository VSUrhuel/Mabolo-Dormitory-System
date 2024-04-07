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
    public partial class ViewPayment : Form
    {
        private DatabaseManager db;
        private List<Payment> paymentList;
        private Point lastLocation;
        private bool mouseDown;
        public ViewPayment(User u)
        {
            db = new DatabaseManager();
            paymentList = new List<Payment>();
            InitializeComponent();
            paymentList = db.GetAllUserPayments(u.UserId);
            label1.Text = u.UserId;
            label2.Text = u.FirstName;
            label3.Text = u.LastName;
            label4.Text = "₱ " + db.GetUserPayableBalance(u.UserId).ToString("N2");
            label6.Text = "₱ " + (((Convert.ToDouble(db.GetSumEvents()) + db.GetSumRegularPayable()*5) - db.GetUserPayableBalance(u.UserId)).ToString("N2"));
            label5.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            SetupTable();
        }

        private void SetupTable()
        {
            dormerTableView.DefaultCellStyle.Font = new Font("Century Gothic", 12);
            dormerTableView.DefaultCellStyle.ForeColor = Color.Black;
            dormerTableView.AllowUserToResizeRows = false;
            dormerTableView.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dormerTableView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(40, 167, 69);
            dormerTableView.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            dormerTableView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dormerTableView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dormerTableView.RowTemplate.Height = 40;
            foreach (Payment p in paymentList)
            {
                dormerTableView.Rows.Add(p.PaymentId, p.PaymentDate.ToString("MMMM dd, yyyy"), p.Amount, p.Remarks);
            }
        }

        private void gunaLabel9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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
