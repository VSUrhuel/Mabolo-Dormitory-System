﻿using Mabolo_Dormitory_System.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mabolo_Dormitory_System
{
    public partial class AddDormerForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private DatabaseManager db = new DatabaseManager();
        private List<Department> depts;
        public AddDormerForm()
        {
            InitializeComponent();

            dormerStatusCB.Items.Add("active");
            dormerStatusCB.Items.Add("inactive");

            dormerTypeCB.Items.Add("Regular dormer");
            dormerTypeCB.Items.Add("Big Brod");
            dormerTypeCB.Items.Add("Student Assistant");
            dormerTypeCB.Items.Add("Dormitory Adviser");
            dormerTypeCB.Items.Add("Assistant Dormitory Adviser");
          
            depts = db.GetAllDepartments();
            foreach (Department d in depts)
            {
                departmentCB.Items.Add(d.DepartmentName);
            }
        }

        private void addDormerButton_Click(object sender, EventArgs e)
        {
            depts = db.GetAllDepartments();
            int x = 0;
            foreach (Department d in depts)
            {
                if (d.DepartmentName == departmentCB.Text)
                {
                    x = d.DepartmentId;
                    collegeText.Text = d.CollegeName;
                }
            }

            if (ValidationClass.ValidateFieldsNotEmpty(new string[] { data1.Text, data2.Text, data3.Text, data4.Text, data5.Text, data6.Text, data7.Text }) == false)
            {
                MessageBox.Show("Please fill up all fields!");
                return;
            }
            if (ValidationClass.ValidateEmail(data5.Text) == false)
            {
                MessageBox.Show("Invalid Email!");
                return;
            }
            if (ValidationClass.ValidatePhoneNumber(data6.Text) == false)
            {
                MessageBox.Show("Invalid Phone Number!");
                return;
            }
            try
            {
                DateTime.Parse(data4.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Date!");
                return;
            }
            if (ValidationClass.ValidateDateValid(DateTime.Parse(data4.Text)) == false)
            {
                MessageBox.Show("Birthdate Should be in the Past.!");
                return;
            }


            User newDormer = new User(data1.Text, data2.Text, data3.Text, DateTime.Parse(data4.Text), data5.Text, data6.Text, data7.Text, dormerStatusCB.Text, dormerTypeCB.Text, (int)x);

            string message = "Add " + newDormer.FirstName + " " + newDormer.LastName + "'s Information?";
            string title = "Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;



            if (MessageBox.Show(message, title, buttons) == DialogResult.Yes)
            {

                db.AddUser(newDormer);
                MessageBox.Show("Sucesfully Added");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Cancelled!");
                this.Dispose();
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

        private void departmentCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (departmentCB.SelectedItem != null)
            {
                int x = 0;
                foreach (Department d in depts)
                {
                    if (d.DepartmentName == departmentCB.Text)
                    {
                        x = d.DepartmentId;
                        collegeText.Text = d.CollegeName;
                    }
                }
            }
        }
    }
}
