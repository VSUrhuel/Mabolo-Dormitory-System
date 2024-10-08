﻿using Mabolo_Dormitory_System.Classes;
using Mabolo_Dormitory_System.GUI___Dormers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mabolo_Dormitory_System.GUI___Dormers
{
    public partial class AddFines : Form
    {
        private DatabaseManager db;
        private Point lastLocation;
        private dormersTab form;
        private bool mouseDown;
        User u;
        public AddFines(User u, dormersTab form)
        {
            this.form = form;
            this.db = new DatabaseManager();
            InitializeComponent();
            this.u = u;
            label1.Text = u.UserId;
            label2.Text = u.FirstName;
            label3.Text = u.LastName;
            label5.Text = DateTime.Now.ToString("MMMM dd, yyyy");
        }

        private void closeViewButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void addPaymentButton_Click(object sender, EventArgs e)
        {
            if (amountText.Text == "" || monthCB.Text == "")
            {
                MessageBox.Show("Please input all fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                float.Parse(amountText.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid number for the amount fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (float.Parse(amountText.Text) < 0)
            {
                MessageBox.Show("Please enter a valid number for the amount fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int index = db.GetLastAccFinesId() + 1;
            AccFines a = new AccFines(index, monthCB.Text, float.Parse(amountText.Text), u.UserId);
            if(db.AddAccFines(a))
            {
                MessageBox.Show("Fines added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error in adding fines!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }

        }

        private void AddFines_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void AddFines_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void AddFines_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
    }
}
