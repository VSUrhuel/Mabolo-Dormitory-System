using Mabolo_Dormitory_System.Classes;
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
        private DatabaseManager db;
        private List<Department> depts;
        private dormersTab dormersTab;
        public AddDormerForm(dormersTab tab)
        {
            this.dormersTab = tab;
            this.db = new DatabaseManager();
            this.depts = new List<Department>();
            InitializeComponent();

            // Add the items to the comboboxes
            dormerStatusCB.Items.Add("Active");
            dormerStatusCB.Items.Add("Inactive");

            dormerTypeCB.Items.Add("Regular Dormer");
            dormerTypeCB.Items.Add("Big Brod");
            dormerTypeCB.Items.Add("Student Assistant");
            dormerTypeCB.Items.Add("Dormitory Adviser");
            dormerTypeCB.Items.Add("Assistant Dormitory Adviser");
          
            // Add the items to the department combobox
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
            
            // Validate the fields
            if (ValidationClass.ValidateFieldsNotEmpty(new string[] { data1.Text, data2.Text, data3.Text, dateTimePicker1.Text, data5.Text, data6.Text, data7.Text }) == false)
            {
                MessageBox.Show("Please fill up all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ValidationClass.ValidateEmail(data5.Text) == false)
            {
                MessageBox.Show("Invalid Email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ValidationClass.ValidatePhoneNumber(data6.Text) == false)
            {
                MessageBox.Show("Invalid Phone Number!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dateTimePicker1.Value >= DateTime.Now)
            {
                MessageBox.Show("Birthdate Should be in the Past.!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(db.UserExists(data1.Text))
            {
                MessageBox.Show("User ID already exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(data1.Text.Count() != 11)
            {
                MessageBox.Show("User ID must be 11 characters long!\nFormat: ##-##-#####", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(data2.Text.Count() < 2)
            {
                MessageBox.Show("First Name must be atleast 2 characters long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (data3.Text.Count() < 2)
            {
                MessageBox.Show("Last Name must be atleast 2 characters long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (data7.Text.Count() < 2)
            {
                MessageBox.Show("Address must be atleast 2 characters long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(data1.Text == "0000000000")
            {
                MessageBox.Show("User ID must not be 0000000000!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Add the dormer
            User newDormer = new User(data1.Text, data2.Text, data3.Text, dateTimePicker1.Value, data5.Text, data6.Text, data7.Text, dormerStatusCB.Text, dormerTypeCB.Text, (int)x);

            string message = "Add " + newDormer.FirstName + " " + newDormer.LastName + "'s Information?";
            string title = "Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            if (MessageBox.Show(message, title, buttons, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.AddUser(newDormer);
                MessageBox.Show("Sucesfully Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dormersTab.refreshButtton_Click(sender, e);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Cancelled!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dormersTab.refreshButtton_Click(sender, e);
                this.Dispose();
            }
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
