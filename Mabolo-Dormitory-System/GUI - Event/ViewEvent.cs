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
        private Point lastLocation;
        private bool mouseDown;
        
        public ViewEvent(int eventId)
        {
            this.EventId = eventId;
            InitializeComponent();

            // Hide the date time picker, combo box, and update button
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            comboBox1.Visible = false;
            updateViewButton.Visible = false;
            db = new DatabaseManager();
            SetUpInformation();
        }

        private void SetUpInformation()
        {
            // Load the event information from the database
            Event e = db.GetEvent(EventId);
            data2.Text = e.EventName;
            data4.Text = e.Description;
            data3.Text = e.Location;
            data6.Text = e.EventDate.ToString("MMMM dd, yyyy");
            data7.Text = e.EventTime;
            data8.Text = e.HasPayables ? "Yes" : "No";
            data9.Text =  e.AttendanceFineAmount.ToString() + ".00";
            data10.Text = e.EventFeeContribution.ToString() + ".00";
            data11.Text = ((int)(e.AttendanceFineAmount + e.EventFeeContribution)).ToString() + ".00";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            // View the information in edit mode
            data11.ReadOnly = true;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            updateViewButton.Visible = true;
            data11.Visible = false;
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.ShowUpDown = true;
           
            comboBox1.Visible = true;
            comboBox1.Text = data8.Text;
            gunaLabel1.Text = "    EDIT INFORMATION";

            // Enable the textboxes for editing
            foreach (Control c in this.Controls)
            {
                if (c is GunaLineTextBox)
                {
                    ((GunaLineTextBox)c).ReadOnly = false;
                }
            }
            try
            {
                DateTime.Parse(data7.Text);
                dateTimePicker2.Value = DateTime.Parse(data7.Text);
            }
            catch
            {
                dateTimePicker2.Value = DateTime.Now;
            }
            dateTimePicker1.Value = DateTime.Parse(data6.Text);
        }

        private void updateViewButton_Click(object sender, EventArgs e)
        {
            // Validate the fields
            if (ValidationClass.ValidateFieldsNotEmpty(new string[] { data2.Text, data3.Text, data4.Text, data9.Text, data10.Text, comboBox1.Text }) == false)
            {
                MessageBox.Show("Please fill up all fields!");
                return;
            }
            try
            {
                float.Parse(data9.Text);
                float.Parse(data10.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid number for the amount fields.");
                return;
            }
           
            // Update the event information
            DateTime date = dateTimePicker1.Value.Date;
            DateTime time = dateTimePicker2.Value;
            MessageBox.Show(time.ToShortTimeString());
            bool hasPayables = comboBox1.Text == "Yes" ? true : false;
            Event x = new Event(EventId, data2.Text, date, time, data3.Text, data4.Text, hasPayables, float.Parse(data9.Text.ToString()), float.Parse(data10.Text), true);
            if (db.UpdateEvent(x))
            {
                MessageBox.Show("Event updated successfully!");
                this.Dispose();
            }
            else
                MessageBox.Show("An error occured while updating the event. Please try again.");
        }

        private void closeViewButton_Click_1(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.Equals("Yes"))
            {
                data9.ReadOnly = false;
                data10.ReadOnly = false;
            }
            else
            {
                data9.ReadOnly = true;
                data10.ReadOnly = true;
            }
        }

        private void recordAttendance_Click(object sender, EventArgs e)
        {
            RecordAttendance recordAttendance = new RecordAttendance(EventId);
            recordAttendance.Show();
        }
    }
}
