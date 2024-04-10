using Guna.UI.WinForms;
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
    public partial class RegularPayableForm : Form
    {
        private DatabaseManager db;
        private List<RegularPayable> regularPayables;
        private PaymentsTab paymentsTab;
        private bool mouseDown;
        private Point lastLocation;

        public RegularPayableForm(PaymentsTab paymentsTab)
        {
            this.paymentsTab = paymentsTab;
            this.db = new DatabaseManager();
            this.regularPayables = new List<RegularPayable>();
            InitializeComponent();
            // Add event handlers to the buttons
            foreach (GunaElipsePanel panel in flowLayoutPanel1.Controls.OfType<GunaElipsePanel>())
            {
                foreach (GunaAdvenceButton button in panel.Controls.OfType<GunaAdvenceButton>())
                {
                    button.Click += new EventHandler(editPayable_Click);
                }
            }
            SetUpEvents();
        }

        public void SetUpEvents()
        {
            // Hide all panels
            foreach (GunaElipsePanel panel in flowLayoutPanel1.Controls.OfType<GunaElipsePanel>())
            {
                panel.Visible = false;
            }

            regularPayables = db.GetRegularPayables();
            int i = 0;
            foreach (GunaElipsePanel panel in flowLayoutPanel1.Controls.OfType<GunaElipsePanel>())
            {

                if (i < regularPayables.Count)
                {
                    panel.Visible = true;
                    panel.Controls.OfType<Label>().ToList()[0].Text = "ID: " + regularPayables[i].RegularPayableId.ToString();
                    panel.Controls.OfType<Label>().ToList()[2].Text = regularPayables[i].Name.ToString();
                    panel.Controls.OfType<Label>().ToList()[1].Text = "₱ " + regularPayables[i].Amount.ToString("N2"); 
                    i++;
                }
                else if (i >= regularPayables.Count)
                    break;
            }
        }
        
        private void editPayable_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not available.\nThis can only be access every beginning of the semester.", "Feature not available", MessageBoxButtons.OK, MessageBoxIcon.Information);      
        }

        private void closeRegularPayableBut_Click(object sender, EventArgs e)
        {
            paymentsTab.refreshBut_Click(sender, e);
            this.Dispose();
        }

        private void addRegularPayable_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not available.\nThis can only be access every beginning of the semester.", "Feature not available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not available.\nThis can only be access every beginning of the semester.", "Feature not available", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
