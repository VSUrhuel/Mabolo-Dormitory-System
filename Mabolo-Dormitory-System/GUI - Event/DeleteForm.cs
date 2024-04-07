using Mabolo_Dormitory_System.Classes;
using Mabolo_Dormitory_System.GUI___Payment;
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
    public partial class DeleteForm : Form
    {
        private DatabaseManager db;
        private Point lastLocation;
        private bool mouseDown;
        private EventTab evenTab;
        public DeleteForm(EventTab eventTab)
        {
            this.evenTab = eventTab;
            this.db = new DatabaseManager();
            InitializeComponent();
            foreach (Event e in db.GetAllEvents())
            {
                comboBox1.Items.Add("Event " + e.EventId + ": " + e.EventName);
            }
        }

        private void deleteDeletEventButton_Click(object sender, EventArgs e)
        {
            if(comboBox1 == null)
            {
                MessageBox.Show("Please select an event to delete.");
                return;
            }
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this event?", "Delete Event", messageBoxButtons);
            String eventId = comboBox1.Text.Split(':')[0];
            int id = Int32.Parse(eventId.Split()[1]);
            if(dialogResult == DialogResult.Yes)
            {
                db.DeleteEvent(id);
                MessageBox.Show("Event deleted successfully!");
                evenTab.refreshBut_Click(sender, e);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Event deletion cancelled.");
                return;
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

        private void cancelDeleteEventButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
