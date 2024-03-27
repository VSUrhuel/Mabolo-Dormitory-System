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
        DatabaseManager db = new DatabaseManager();
        List<User> users = new List<User>();
        List<Department> depts = new List<Department>();
        public UpdateForm()
        {
            InitializeComponent();
            
        }
        public void SetInformation(List<User> users, int index)
        {
            // Set the information of the dormer
            User user = users[index];
            data1.Text = user.UserId;
            data2.Text = user.FirstName;
            data3.Text = user.LastName;
            data4.Text = user.Birthday.ToString("yyyy/MM/dd");
            data5.Text = user.Email;
            data6.Text = user.PhoneNumber;
            data7.Text = user.Address;

            dormerStatusCB.Items.Add("active");
            dormerStatusCB.Items.Add("inactive");
            
            dormerTypeCB.Items.Add("Regular dormer");
            dormerTypeCB.Items.Add("Big Brod");
            dormerTypeCB.Items.Add("Student Assistant");
            dormerTypeCB.Items.Add("Dormitory Adviser");
            dormerTypeCB.Items.Add("Assistant Dormitory Adviser");
            dormerTypeCB.Text = user.UserType;
            dormerStatusCB.Text = user.UserStatus.ToString();
            Department department = db.GetUserDepartment(user.UserId);
            
            depts = db.GetAllDepartments();
            foreach(Department d in depts)
            {
                departmentCB.Items.Add(d.DepartmentName);
            }
            departmentCB.Text = department.DepartmentName;
            collegeText.Text = department.CollegeName;
            Room r = db.GetUserRoom(user.UserId);
            

        }

        private void closeViewButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void updateViewButton_Click(object sender, EventArgs e)
        {
            
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
           
            if(ValidationClass.ValidateFieldsNotEmpty(new string[] { data1.Text, data2.Text, data3.Text, data4.Text, data5.Text, data6.Text, data7.Text }) == false)
            {
                MessageBox.Show("Please fill up all fields!");
                return;
            }
            if(ValidationClass.ValidateEmail(data5.Text) == false)
            {
                MessageBox.Show("Invalid Email!");
                return;
            }
            if(ValidationClass.ValidatePhoneNumber(data6.Text) == false)
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
            if(ValidationClass.ValidateDateValid(DateTime.Parse(data4.Text)) == false)
            {
                MessageBox.Show("Birthdate Should be in the Past.!");
                return;
            }


            User newDormer = new User(data1.Text, data2.Text, data3.Text, DateTime.Parse(data4.Text), data5.Text, data6.Text, data7.Text, dormerStatusCB.Text, dormerTypeCB.Text, (int)x);
            
            string message = "Update " + newDormer.FirstName + " " + newDormer.LastName + "'s Information?";
            string title = "Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
           
            
            
            if(MessageBox.Show(message, title, buttons) == DialogResult.Yes)
            {
                
                db.UpdateUser(newDormer);
                MessageBox.Show("Update Successful!");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Update Cancelled!");
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
    }
}
