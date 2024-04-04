using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using Mabolo_Dormitory_System.Classes;
using Microsoft.Extensions.Logging;

namespace Mabolo_Dormitory_System.GUI___Event
{
    public partial class ViewEvent : Form
    {
        private DatabaseManager db;
        private int EventId;
        private List<User> users;
        private Point lastLocation;
        private bool mouseDown;
        private Form form;
        private RecordAttendance recordData;
        public ViewEvent(Form form, int eventId)
        {
            this.form = form;
            this.EventId = eventId;
            InitializeComponent();

            db = new DatabaseManager();
            SetUpInformation();

            // Attendance Record
            this.users = new List<User>();
            this.EventId = eventId;
            
            users = db.GetAllUsersExcpetAdmin();
            List<EventAttendance> eventAttendances = db.GetEventAttendances(eventId);
            SetupTable();
            foreach (EventAttendance ea in eventAttendances)
            {
                foreach (User u in users)
                {
                    if (ea.FK_UserId_EventAttendance == u.UserId)
                    {
                        int index = GetRowIndex(u.UserId);
                        if (ea.AttendanceStatus == "Present")
                            dormerTableView.Rows[index].Cells["Attendance"].Value = true;
                        else
                            dormerTableView.Rows[index].Cells["Attendance"].Value = false;
                    }
                }
            }
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

        private void SetUpInformation()
        {
            
            // Load the event information from the database
            Event e = db.GetEvent(EventId);
            data2.Text = e.EventName;
            data4.Text = e.Description;
            data3.Text = e.Location;
            data6.Text = e.EventDate.ToString("yyyy-MM-dd");
            data7.Text = e.EventTime;
            data9.Text =  e.AttendanceFineAmount.ToString() + ".00";
            data10.Text = e.EventFeeContribution.ToString() + ".00";
        }

        

       
        private void closeViewButton_Click_1(object sender, EventArgs e)
        {
            if (recordData != null)
                recordData.Dispose();
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
        private void selectAllCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void recordAttendance_Click(object sender, EventArgs e)
        {
            recordData = new RecordAttendance(EventId);
            SetFormLocation(recordData);
            recordData.Owner = form;
            recordData.Show();
        }

        private void SetFormLocation(Form form)
        {
            form.StartPosition = FormStartPosition.Manual;
            int x = (Screen.PrimaryScreen.Bounds.Width - form.Width) * 1/9;
            int y = ((Screen.PrimaryScreen.Bounds.Height - form.Height) / 2);
            form.Location = new Point(x, y);
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
        

      
        private void updateViewButton_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dormerTableView.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Attendance"].Value))
                    db.RecordAttendance(row.Cells["UserId"].Value.ToString(), EventId, "Present");
                else
                    db.RecordAttendance(row.Cells["UserId"].Value.ToString(), EventId, "Absent");
            }
            MessageBox.Show("Attendance Updated!");
        }

        private void selectAllCB_CheckedChanged_1(object sender, EventArgs e)
        {
            if (selectAllCB.Checked)
            {
                for (int i = dormerTableView.Rows.Count - 1; i >= 0; i--)
                {
                    DataGridViewRow row = dormerTableView.Rows[i];
                    row.Cells["Attendance"].Value = true;
                }
            }
            else
            {
                for (int i = dormerTableView.Rows.Count - 1; i >= 0; i--)
                {
                    DataGridViewRow row = dormerTableView.Rows[i];
                    row.Cells["Attendance"].Value = false;
                }
            }
        }

        private void gunaLabel6_Click(object sender, EventArgs e)
        {

        }

        private void data7_Click(object sender, EventArgs e)
        {

        }
    }
}
