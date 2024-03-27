using System;
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
    public partial class ViewForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        DatabaseManager db = new DatabaseManager();
        public ViewForm()
        {
            InitializeComponent();
        }

        private void closeViewButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
            data8.Text = user.UserStatus.ToString();
            data9.Text = user.UserType;
            Department department = db.GetUserDepartment(user.UserId);
            data10.Text = department.DepartmentName;
           
            data11.Text = department.CollegeName;
            Room r = db.GetUserRoom(user.UserId);
            if(r != null)
                data12.Text = r.RoomId.ToString();
            else
                data12.Text = "N/A";
            data13.Text = (DateTime.Now.Year - user.Birthday.Year).ToString();

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
