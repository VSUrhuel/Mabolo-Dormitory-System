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
        
        public ViewEvent(int eventId)
        {
            this.EventId = eventId;
            InitializeComponent();
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            comboBox1.Visible = false;
            updateViewButton.Visible = false;
            db = new DatabaseManager();
            SetUpInformation();
        }

        private void SetUpInformation()
        {
            Event e = db.GetEvent(EventId);
            data2.Text = e.EventName;
            data4.Text = e.Description;
            data3.Text = e.Location;
            data6.Text = e.EventDate.ToString("MMMM dd, yyyy");
            if(e.EventTime.ToString("HH:mm:ss") == "00:00:00")
            {
                data7.Text = "N/A";
            }
            else if(e.EventTime.Hour > 12)
            {
                data7.Text = e.EventTime.ToString("hh:mm") + " PM";
            }
            else
            {
                data7.Text = e.EventTime.ToString("hh:mm") + " AM";
            }
            data8.Text = e.HasPayables ? "Yes" : "No";
            data9.Text =   e.AttendanceFineAmount.ToString() + ".00";
            data10.Text =  e.EventFeeContribution.ToString() + ".00";
            data11.Text = ((int)(e.AttendanceFineAmount + e.EventFeeContribution)).ToString() + ".00";
        }

        private void closeViewButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            updateViewButton.Visible = true;
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.ShowUpDown = true;
            comboBox1.Visible = true;
            gunaLabel1.Text = " EDIT INFORMATION";
            foreach (Control c in this.Controls)
            {
                if (c is GunaLineTextBox)
                {
                    ((GunaLineTextBox)c).ReadOnly = false;
                }
            }
            dateTimePicker1.Value = DateTime.Parse(data6.Text);
            dateTimePicker2.Value = DateTime.Parse(data7.Text);
        }

        private void updateViewButton_Click(object sender, EventArgs e)
        {
            if (ValidationClass.ValidateFieldsNotEmpty(new string[] { data2.Text, data3.Text, data4.Text, data9.Text, data10.Text }) == false)
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
            if (dateTimePicker1.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Please enter a valid date.");
                return;
            }
            int index = db.GetAllEvents().Count + 1;
            DateTime date = dateTimePicker1.Value.Date;
            DateTime time = dateTimePicker1.Value;
            bool hasPayables = comboBox1.Text == "Yes" ? true : false;
            Event x = new Event(index, data2.Text, date, time, data3.Text, data4.Text, hasPayables, float.Parse(data9.Text.ToString()), float.Parse(data10.Text));
            if (db.UpdateEvent(x))
            {
                MessageBox.Show("Event updated successfully!");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("An error occured while updating the event. Please try again.");
            }
        }

        private void closeViewButton_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
