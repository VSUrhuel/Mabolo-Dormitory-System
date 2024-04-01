using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mabolo_Dormitory_System.Classes;
using Microsoft.Extensions.Logging;

namespace Mabolo_Dormitory_System.GUI___Payment
{
    public partial class PaymentsTab : UserControl
    {
        private Form form;
        private List<Event> events;
        private List<User> users;
        private List<Payment> payments;
        private List<RegularPayable> regularPayables;
        private int RegularPayableId;
        private int EventId;
        private DatabaseManager db;
        public PaymentsTab(Form form)
        {
            this.form = form;
            users = new List<User>();
            events = new List<Event>();
            payments = new List<Payment>();
            regularPayables = new List<RegularPayable>();
            db = new DatabaseManager();
            InitializeComponent();
            //MessageBox.Show(regularPayablesCB.Text);
            events = db.GetAllEvents();
            users = db.GetAllUsersExcpetAdmin();
            regularPayables = db.GetRegularPayables();
            payments = db.GetPayments();
            SetupTable();
            foreach(RegularPayable regularPayables in regularPayables)
            {
                regularPayablesCB.Items.Add(regularPayables.Name);
            }
            foreach (Event e in events)
            {
                if(e.HasPayables)
                    eventPayabalesCB.Items.Add(e.EventName);
            }
            

        }
        private void UpdateColumns()
        {
            int index = -1;
            RegularPayableId -= 1;
            EventId -= 1;
            foreach (Payment p in payments)
            {
                foreach (User u in users)
                {
                    index = GetRowIndex(u.UserId);
                    
                    if ((p.FK_RegularPayablesId_Payment == RegularPayableId && p.FK_UserId_Payment == u.UserId && eventPayabalesCB.Text != "") || (p.FK_EventId_Payment == EventId && p.FK_UserId_Payment == u.UserId && regularPayablesCB.Text != "")) 
                        {
                            MessageBox.Show(p.FK_UserId_Payment + " " + u.UserId + " " + p.FK_EventId_Payment + " " + EventId + " " + p.FK_RegularPayablesId_Payment + " " + RegularPayableId + " the event payable text: " + eventPayabalesCB.Text);
                            if (p.PaymentStatus == "Paid")
                                dormerTableView.Rows[index].Cells["Status"].Value = "PAID";
                            else
                                dormerTableView.Rows[index].Cells["Status"].Value = "PENDING";
                        }
                        else
                            dormerTableView.Rows[index].Cells["Status"].Value = "PENDING";
                   
                    
                }
            }
            index = 0;
            foreach(DataGridViewRow row in dormerTableView.Rows)
            {
                if (row.Cells["Status"].Value == null)
                {
                    dormerTableView.Rows[index].Cells["Status"].Value = "PENDING";
                }
            }
            RegularPayableId += 1;
            EventId += 1;
            index = 0;
            if(regularPayablesCB.Text != "")
            {
                foreach (DataGridViewRow row in dormerTableView.Rows)
                {
                    if (row.Cells["Status"].Value.ToString() == "PENDING")
                    {
                        dormerTableView.Rows[index++].Cells["RemainingBalance"].Value = "300";
                    }
                    else
                    {
                        
                        float x = (db.GetPayment(RegularPayableId, row.Cells["UserId"].Value.ToString(), "Regular Payable").Amount);
                        
                        float amount = 300 - x;
                        dormerTableView.Rows[index++].Cells["RemainingBalance"].Value = amount.ToString();
                    }
                }
            }
            else
            {
                index = 0;
                foreach (DataGridViewRow row in dormerTableView.Rows)
                {
                    if (row.Cells["Status"].Value.ToString() == "PENDING")
                    {
                        dormerTableView.Rows[index++].Cells["RemainingBalance"].Value = db.GetEvent(EventId).EventFeeContribution + db.GetEvent(EventId).AttendanceFineAmount;
                    }
                    else
                    {

                        /*float x = (db.GetPayment(ID, row.Cells["UserId"].Value.ToString(), "Regular Payable").Amount);

                        float amount = 300 - x;
                        dormerTableView.Rows[index++].Cells["RemainingBalance"].Value = amount.ToString();*/
                    }
                }
            }
        }
        private int GetRowIndex(string userId)
        {
            for (int i = 0; i < dormerTableView.Rows.Count; i++)
            {
                if (dormerTableView.Rows[i].Cells["UserId"].Value.ToString() == userId)
                {
                    return i;
                }
            }
            return -1;
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
            foreach (User u in users)
            {
                dormerTableView.Rows.Add(u.UserId, u.FirstName, u.LastName);
            }

        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EventId = db.GetEvent(eventPayabalesCB.SelectedItem.ToString()).EventId;
            regularPayablesCB.SelectedIndex = -1;
            RegularPayableId = -1;
            UpdateColumns();
        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void dormerTableView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns["Attendance"] is DataGridViewCheckBoxColumn && e.RowIndex > -1)
            {
                if (!Convert.ToBoolean(senderGrid.Rows[e.RowIndex].Cells["Attendance"].Value))
                    senderGrid.Rows[e.RowIndex].Cells["Attendance"].Value = true;
                else
                    senderGrid.Rows[e.RowIndex].Cells["Attendance"].Value = false;
            }
        }

        private void updateViewButton_Click(object sender, EventArgs e)
        {
            if(eventPayabalesCB.SelectedItem == null || regularPayablesCB.SelectedItem == null)
            {
                MessageBox.Show("Please select an event type payment or a regular payable.");
                return;
            }
            if(eventPayabalesCB.SelectedItem != null || regularPayablesCB.SelectedItem != null)
            {
                MessageBox.Show("Please select only one payment type.");
                return;
            }
            foreach(DataGridViewRow row in dormerTableView.Rows)
            {
                try
                {
                    Convert.ToDouble(row.Cells["Amount"].Value);
                }
                catch
                {
                    MessageBox.Show("Please enter valid amount.");
                    return;
                }

            }
            /*foreach (DataGridViewRow row in dormerTableView.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Attendance"].Value))
                    db.AddPayment(ID, row.Cells["Attendance"].Value.ToString(), Convert.ToDouble(row.Cells["Amount"].Value);
                else
                   db.RecordAttendance(row.Cells["UserId"].Value.ToString(), EventId, "Absent");
            }*/
            MessageBox.Show("Attendance Updated!");
        }

        private void regularPayablesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegularPayableId = db.GetRegularPayableId(regularPayablesCB.SelectedItem.ToString());
            eventPayabalesCB.SelectedIndex = -1;
            eventPayabalesCB.Text = String.Empty;
            EventId = -1;
            UpdateColumns();
        }
    }
}
