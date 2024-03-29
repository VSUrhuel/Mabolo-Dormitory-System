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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
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
            var dormers = new dormersTab();
            mainPanel.Controls.Add(dormers);
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(dashboardPanel1);
            mainPanel.Controls.Add(dashboardPanel2);
           
        }

        private void roomButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            roomTab room = new roomTab();
            mainPanel.Controls.Add(room);
        }
    }
}
