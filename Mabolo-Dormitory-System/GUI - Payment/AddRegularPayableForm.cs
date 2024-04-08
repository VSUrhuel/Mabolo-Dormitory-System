using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mabolo_Dormitory_System.Classes;
using System.Windows.Forms;

namespace Mabolo_Dormitory_System.GUI___Payment
{
    public partial class AddRegularPayableForm : Form
    {
        private PaymentsTab paymentsTab;
        private DatabaseManager db;
        private Point lastLocation;
        private bool mouseDown;
        private RegularPayableForm regularPayableForm;
        public AddRegularPayableForm(RegularPayableForm form, PaymentsTab paymentsTab)
        {
            this.regularPayableForm = form;
            this.paymentsTab = paymentsTab;
            this.db = new DatabaseManager();
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int index;
            if(db.GetRegularPayables().Count == 0)
                index = 1;
            else
                index = db.GetRegularPayables()[db.GetRegularPayables().Count - 1].RegularPayableId + 1;
            db.AddRegularPayable(new RegularPayable(index, gunaTextBox1.Text, float.Parse(gunaTextBox2.Text)));
            db.LoadUsersPayable();
            MessageBox.Show("Regular Payable added successfully!");
            paymentsTab.refreshBut_Click(sender, e);
            regularPayableForm.SetUpEvents();
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

        private void closeViewButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
