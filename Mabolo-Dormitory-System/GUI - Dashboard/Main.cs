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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Mabolo_Dormitory_System.GUI___Event;
using Mabolo_Dormitory_System.GUI___Payment;
using Mabolo_Dormitory_System.GUI___Settings;
using System.IO;
using System.Security.Principal;

namespace Mabolo_Dormitory_System
{
    public partial class Main : Form
    {
        private DatabaseManager db;
        private String email;
        public Main(String email)
        {
            this.email = email;
            this.db = new DatabaseManager();
            InitializeComponent();      
            db.LoadUsersPayable();
            UpdateInformation();    
        }     
       
        public void UpdateInformation()
        {
            List<User> users = db.GetAllUsers();
            int count = db.GetMonthlyEvent().Count;
            eventCount.Text = db.GetAllEvents().Count.ToString();
            
            Account account = db.GetAccount(email);
            // Update Picature
            pictureUser.Image = null;
            byte[] imageData = account.ImageData;
            pictureUser.Image = Image.FromStream(new MemoryStream(imageData));
            
            User u = db.GetUser(account.FK_UserId_Account);
            if (u.UserType == "Dormitory Adviser")
            {
                label21.Text = "Dorm Adviser";
            }
            else
                label21.Text = "Ast. Dorm Adviser";
                

            // Update Username
            
            username.Text = account.UserName;

            // Dormer Count Panel
            if (count == 0)
                eventDescription.Text = "No events this month";
            else if(count == 1)
                eventDescription.Text = "There is one event this month";
            else
                eventDescription.Text = "There are " + count + " events this month";

            // Room Count Panel
            int x = (Convert.ToInt16(users.Count - countAdminUsers()));
            if (x < 0)
                dormerCountLabel.Text = "0";
            else
                dormerCountLabel.Text = x.ToString();
            if (dormerCountLabel.Text == "60")
            {
                roomDescription.Text = "Rooms are all occupied";
                dormerDescription.Text = "Dorm is already full";
            }
            else
            {
                roomDescription.Text = "Rooms are still available";
                dormerDescription.Text = "Dorm is not yet full";
            }

            // Payment Panel
            int regularPayable = Convert.ToInt32(db.GetSumRegularPayable() * 5);
            int totalEvents = Convert.ToInt32(db.GetSumEvents());
            int userCount = db.GetAllUsersExcpetAdmin().Count;
   
            int totalPayableAndEvents = (regularPayable + totalEvents) * userCount;
            int remainingBalance = totalPayableAndEvents - Convert.ToInt32(db.GetSumRemainingBalance()) - Convert.ToInt32(db.GetAllSumPresentAttendances());
            int number = Convert.ToInt32(totalPayableAndEvents - remainingBalance);

            if (number < 1000)
            {
                label13.Text = number.ToString();
            }
            else if (number < 1000000)
            {
                label13.Text = (number / 1000) + "K";
            }
            else
            {
                label13.Text = (number / 1000000) + "M";
            }
        }

        private int countAdminUsers()
        {
            int ctr = 0;
            List<User> users = new List<User>();
            users = db.GetAllUsers();
            foreach(User u in users)
            {
                if(u.UserType == "Dormitory Adviser" || u.UserType == "Assistant Dormitory Adviser")
                {
                    ctr++;
                }
            }
            return ctr;
        }
        
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dormerButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            var dormers = new dormersTab(this);
            mainPanel.Controls.Add(dormers);
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            UpdateInformation();
            mainPanel.Controls.Add(dashboardPanel1);
            mainPanel.Controls.Add(dashboardPanel2);
        }

        private void roomButton_Click(object sender, EventArgs e)
        {
            if (!verifyUsers())
            {
                return;
            }
            mainPanel.Controls.Clear();
            roomTab room = new roomTab(this);
            mainPanel.Controls.Add(room);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {            
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
            this.Dispose();
        }

        private void eventButton_Click(object sender, EventArgs e)
        {
            if(!verifyUsers())
                return;
            mainPanel.Controls.Clear();
            EventTab eventTab = new EventTab(this);
            mainPanel.Controls.Add(eventTab);
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            if (!verifyUsers())
                return;
             mainPanel.Controls.Clear();
            PaymentsTab paymentsTab = new PaymentsTab(this);
            mainPanel.Controls.Add(paymentsTab);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            SettingsTab settingsTab = new SettingsTab(this, email);
            mainPanel.Controls.Add(settingsTab);
        }

        private bool verifyUsers()
        {
            List<User> u = db.GetAllUsers();
            if (u.Count == 0 || !UserHasDormer(u))
            {
                MessageBox.Show("No dormers yet. Please input dormer that is not an Adviser or Assistant Adviser.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool UserHasDormer(List<User> u)
        {
            List<User> users = u;
            foreach(User user in users)
            {
                if(user.UserType == "Regular Dormer" || user.UserType == "Big Brod" || user.UserType == "Student Assistant")
                    return true;
            }
            return false;
        }
    }
}
