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

namespace Mabolo_Dormitory_System
{
    public partial class Main : Form
    {
        private DatabaseManager db = null;
        public Main(String email)
        {
            db = new DatabaseManager();
            String text = db.GetUserNameOfAdmin(email);
            InitializeComponent();
            username.Text = text;
            UpdateInformation();
        }
        private void UpdateInformation()
        {
            List<User> users = db.GetAllUsers();
            dormerCountLabel.Text = (Convert.ToInt16(users.Count - 2)).ToString();
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
        }

        private void Main_Load(object sender, EventArgs e)
        {

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
            mainPanel.Controls.Clear();
            roomTab room = new roomTab(this);
            mainPanel.Controls.Add(room);
        }

        private void logoutBut_Click(object sender, EventArgs e)
        {            
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
            this.Dispose();
        }

        private void eventButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            EventTab eventTab = new EventTab(this);
            mainPanel.Controls.Add(eventTab);
        }
    }
}
