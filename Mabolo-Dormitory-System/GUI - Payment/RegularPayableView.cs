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

namespace Mabolo_Dormitory_System.GUI___Payment
{
    public partial class RegularPayableView : Form
    {
        private int regularPayableId;
        private DatabaseManager db;
        private PaymentsTab paymentsTab;
        private Point lastLocation;
        private bool mouseDown;
        public RegularPayableView(PaymentsTab paymentsTab, int regularPayableId)
        {
            this.regularPayableId = regularPayableId;
            this.db = new DatabaseManager();
            InitializeComponent();
            gunaTextBox1.Text = db.GetRegularPayable(regularPayableId).Name;
            gunaTextBox2.Text = db.GetRegularPayable(regularPayableId).Amount.ToString("N2");
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if(gunaTextBox1 != null && gunaTextBox2 != null) 
            {
                try
                {
                    float.Parse(gunaTextBox2.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid amount!");
                    return;
                }
                db.UpdateRegularPayable(new RegularPayable(regularPayableId, gunaTextBox1.Text, float.Parse(gunaTextBox2.Text)));
                MessageBox.Show("Regular Payable updated successfully!");
                paymentsTab.refreshBut_Click(sender, e);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill up all fields!");
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

        private void closeViewButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
