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
    public partial class UpdateForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private DatabaseManager db;
        private List<Department> depts;
       
        public UpdateForm()
        {
            this.db = new DatabaseManager();
            this.depts = new List<Department>();
            InitializeComponent(); 
        }
        
        public void SetInformation(List<User> users, int index)
        {
            if(users.Count < index)
            {
                MessageBox.Show("No User Found!");
                this.Dispose();
            }

            // Set the information of the dormer
            User user = users[index];
            data1.Text = user.UserId;
            data2.Text = user.FirstName;
            data3.Text = user.LastName;
            dateTimePicker1.Value = user.Birthday;
            data5.Text = user.Email;
            data6.Text = user.PhoneNumber;
            data7.Text = user.Address;

            // Set the status and type of the dormer
            dormerStatusCB.Items.Add("Active");
            dormerStatusCB.Items.Add("Inactive");
            
            dormerTypeCB.Items.Add("Regular Dormer");
            dormerTypeCB.Items.Add("Big Brod");
            dormerTypeCB.Items.Add("Student Assistant");
            dormerTypeCB.Items.Add("Dormitory Adviser");
            dormerTypeCB.Items.Add("Assistant Dormitory Adviser");
            dormerStatusCB.Text = user.UserStatus.ToString();

            // Set the department and college of the dormer
            Department department = db.GetUserDepartment(user.UserId);
            depts = db.GetAllDepartments();
            foreach(Department d in depts)
            {
                departmentCB.Items.Add(d.DepartmentName);
            }
            departmentCB.Text = department.DepartmentName;
            collegeText.Text = department.CollegeName;
            dormerTypeCB.Text = user.UserType;
        }

        private void closeUpdateButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void updateDormerButton_Click(object sender, EventArgs e)
        {
            // Get the college in accordance to department
            depts = db.GetAllDepartments();
            int x = 0;
            foreach (Department d in depts)
            {
                if(d.DepartmentName == departmentCB.Text)
                {
                    x = d.DepartmentId;
                    collegeText.Text = d.CollegeName;
                }
            }
           
            // Validate the fields
            if(ValidationClass.ValidateFieldsNotEmpty(new string[] { data1.Text, data2.Text, data3.Text, dateTimePicker1.Value.ToString(), data5.Text, data6.Text, data7.Text }) == false)
            {
                MessageBox.Show("Please fill up all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(ValidationClass.ValidateEmail(data5.Text) == false)
            {
                MessageBox.Show("Invalid Email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(ValidationClass.ValidatePhoneNumber(data6.Text) == false)
            {
                MessageBox.Show("Invalid Phone Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("Birthdate Should be in the Past!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (data2.Text.Count() < 2)
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

            // Update the information
            User newDormer = new User(data1.Text, data2.Text, data3.Text,dateTimePicker1.Value, data5.Text, data6.Text, data7.Text, dormerStatusCB.Text, dormerTypeCB.Text, (int)x); 
            string message = "Update " + newDormer.FirstName + " " + newDormer.LastName + "'s Information?";
            string title = "Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            if(MessageBox.Show(message, title, buttons, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.UpdateUser(newDormer);
                MessageBox.Show("Update Successful!\nClick the refresh button, to load the updates.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Update Cancelled!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            
        }

        private void departmentCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(departmentCB.SelectedItem != null)
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
