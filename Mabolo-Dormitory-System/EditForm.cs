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

namespace Mabolo_Dormitory_System
{
    public partial class EditForm : Form
    {
        private DatabaseManager db;
        private List<User> users;
        private int roomNum = 0;
        private Point lastLocation;
        private bool mouseDown;
        public EditForm(int roomNum)
        {
            InitializeComponent();
            db = new DatabaseManager();
            this.roomNum = roomNum;
            users = db.GetUsersInRoom(roomNum);
            chooseCB.Items.Clear();
            foreach (User user in users)
            {
                chooseCB.Items.Add(user.UserId + ": " + user.FirstName + " " + user.LastName);
            }
        }

        private void addViewButton_Click(object sender, EventArgs e)
        {
            if(!ValidationClass.ValidateFieldsNotEmpty(new string[] { roomChooseCB.Text, chooseCB.Text}))
            {
                MessageBox.Show("Please fill up all fields.");
                return;
            }
            int newRoom = Convert.ToInt32(roomChooseCB.SelectedItem.ToString().Split(' ')[1]);
            string text = chooseCB.SelectedItem.ToString().Split(':')[0];
            db.UpdateUserRoom(roomNum, newRoom, text);
            MessageBox.Show(text + " was moved to room " + newRoom + ".");
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
