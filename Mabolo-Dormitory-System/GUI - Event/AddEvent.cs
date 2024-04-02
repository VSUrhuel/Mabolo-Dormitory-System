using Mabolo_Dormitory_System.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mabolo_Dormitory_System.GUI___Event
{
    public partial class AddEvent : Form
    {
        private DatabaseManager db;
        private Point lastLocation;
        private bool mouseDown;
        public AddEvent()
        {
            this.db = new DatabaseManager();
            InitializeComponent();
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.ShowUpDown = true;
        }

        private void closeViewButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void addViewButton_Click(object sender, EventArgs e)
        {
            // Validate the fields
            if(ValidationClass.ValidateFieldsNotEmpty(new string[] { data2.Text, data3.Text, data4.Text, data9.Text, data10.Text }) == false)
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

            if(dateTimePicker1.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Please enter a valid date.");
                return;
            }

            // Add the event
            int index = db.GetLastEventId() + 1;
            DateTime date = dateTimePicker1.Value.Date;
            DateTime time = dateTimePicker1.Value;
            bool hasPayables = comboBox1.Text == "Yes" ? true : false;
            Event x = new Event(index, data2.Text, date, time, data3.Text, data4.Text, hasPayables, float.Parse(data9.Text.ToString()), float.Parse(data10.Text));
            if(db.AddEvent(x))
            {
                MessageBox.Show("Event added successfully!");
                this.Dispose();
            }
            else
                MessageBox.Show("An error occured while adding the event. Please try again.");
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
