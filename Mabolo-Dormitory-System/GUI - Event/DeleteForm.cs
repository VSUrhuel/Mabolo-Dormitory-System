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
    public partial class DeleteForm : Form
    {
        private DatabaseManager db;
        public DeleteForm()
        {
            InitializeComponent();
            db = new DatabaseManager();
            foreach (Event e in db.GetAllEvents())
            {
                comboBox1.Items.Add("Event " + e.EventId + ": " + e.EventName);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(comboBox1 == null)
            {
                MessageBox.Show("Please select an event to delete.");
                return;
            }
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this event?", "Delete Event", messageBoxButtons);
            String eventId = comboBox1.Text.Split(':')[0];
            int id = Int32.Parse(eventId.Split()[1])-1;
            if(dialogResult == DialogResult.Yes)
            {
                db.DeleteEvent(id);
                MessageBox.Show("Event deleted successfully!");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Event deletion cancelled.");
                return;
            }
        }
    }
}
