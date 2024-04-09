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
    public partial class EditEvent : Form
    {
        private int eventId;
        private DatabaseManager db;
        private Point lastLocation;
        private bool mouseDown;
        
        public EditEvent(Form form, int eventId)
        {
            this.eventId = eventId;
            this.db = new DatabaseManager();
            InitializeComponent();
            SetInformation();
        }
        private void SetInformation()
        {
            Event ev = db.GetEvent(eventId);
            data2.Text = ev.EventName;
            data4.Text = ev.Description;
            data3.Text = ev.Location;
            comboBox1.Text = ev.HasPayables ? "Yes" : "No";
            data9.Text = ev.AttendanceFineAmount.ToString();
            data10.Text = ev.EventFeeContribution.ToString();
            dateTimePicker1.Value = ev.EventDate;
            dateTimePicker2.Value = DateTime.Parse(ev.EventTime);
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.ShowUpDown = true;
        }

        private void closeEditEventBut_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void updateEditEventBut_Click(object sender, EventArgs e)
        {
            if (ValidationClass.ValidateFieldsNotEmpty(new string[] { data2.Text, data3.Text, data4.Text, data9.Text, data10.Text }) == false)
            {
                MessageBox.Show("Please fill up all fields!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                float.Parse(data9.Text);
                float.Parse(data10.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid number for the amount fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(float.Parse(data9.Text) < 0 || float.Parse(data10.Text) < 0)
            {
                MessageBox.Show("Please enter a valid number for the amount fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DateTime date = dateTimePicker1.Value.Date;
            DateTime time = dateTimePicker2.Value;
            bool hasPayables = comboBox1.Text == "Yes" ? true : false;
            Event x = new Event(eventId, data2.Text, date, time, data3.Text, data4.Text, hasPayables, float.Parse(data9.Text.ToString()), float.Parse(data10.Text), true);
            if (db.UpdateEvent(x))
            {
                MessageBox.Show("Event updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
                MessageBox.Show("An error occured while updating the event. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
