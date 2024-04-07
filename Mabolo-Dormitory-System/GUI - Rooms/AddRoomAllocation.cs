﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mabolo_Dormitory_System.Classes;

namespace Mabolo_Dormitory_System
{
    public partial class AddRoomAllocation : Form
    {
        private Point lastLocation;
        private bool mouseDown;
        private DatabaseManager db;
        private int roomNUm;
        private roomTab roomTab;
        public AddRoomAllocation(int n, roomTab tab)
        {
            this.roomTab = tab;
            this.roomNUm = n;
            this.db = new DatabaseManager();
            InitializeComponent();
        }

        private void closeRoomAllocationBut_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void addRoomAllocationBut_Click(object sender, EventArgs e)
        {
            if(!ValidationClass.ValidateFieldsNotEmpty(new string[] { chooseCB.Text, userTypeCB.Text}))
            {
                MessageBox.Show("Please fill up all fields.");
                return;
            }
            string text = chooseCB.SelectedItem.ToString().Split(':')[0];
            if(db.GetUser(text).UserType == "Big Brod" && db.RoomHasBigBrod(roomNUm))
            {
                MessageBox.Show("This room already has a Big Brod assigned.");
                return;
            }
            if(db.AddUserInRoom(roomNUm, text))
                MessageBox.Show(text + " was added in room " + roomNUm + ".");
            roomTab.refreshBut_Click(sender, e);
            this.Dispose();
        }

        private void userTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            String text = userTypeCB.SelectedItem.ToString();
            List<User> users = db.GetUsersTypeWithoutRoom(text);
            if(users == null)
            {
                MessageBox.Show("All users of this type are already assigned a room.");
                return;
            }
            chooseCB.Items.Clear();
            foreach (User user in users)
                chooseCB.Items.Add(user.UserId + ": " + user.FirstName + " " + user.LastName);
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
