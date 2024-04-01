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

namespace Mabolo_Dormitory_System.GUI___Event
{
    public partial class RecordAttendance : Form
    {
        private int EventId;
        private List<User> users;
        private DatabaseManager db;
        private Point lastLocation;
        private bool mouseDown;
        public RecordAttendance(int eventId)
        {
            this.db = new DatabaseManager();
            this.users = new List<User>();
            this.EventId = eventId;
            InitializeComponent();
            users = db.GetAllUsersExcpetAdmin();
            eventTitle.Text = db.GetEvent(eventId).EventName;
            List<EventAttendance> eventAttendances = db.GetEventAttendances(eventId);
            SetupTable();
            foreach (EventAttendance ea in eventAttendances)
            {
                foreach(User u in users)
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
            foreach(User u in users)
            {
                dormerTableView.Rows.Add(u.UserId, u.FirstName, u.LastName);
            }
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
            foreach(DataGridViewRow row in dormerTableView.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Attendance"].Value))
                    db.RecordAttendance(row.Cells["UserId"].Value.ToString(), EventId, "Present");
                else
                    db.RecordAttendance(row.Cells["UserId"].Value.ToString(), EventId, "Absent");
            }
            MessageBox.Show("Attendance Updated!");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void selectAllCB_CheckedChanged(object sender, EventArgs e)
        {
            if(selectAllCB.Checked)
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
