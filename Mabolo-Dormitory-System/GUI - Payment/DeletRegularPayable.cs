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
    public partial class DeletRegularPayable : Form
    {
        private RegularPayableForm regularPayableForm;
        private DatabaseManager db;
        public DeletRegularPayable(RegularPayableForm regularPayableForm)
        {
            this.regularPayableForm = regularPayableForm;
            this.db = new DatabaseManager();
            InitializeComponent();
            List<RegularPayable> regularPayables = db.GetRegularPayables();
            foreach (RegularPayable regularPayable in regularPayables)
            {
                comboBox1.Items.Add("Payable ID "+ regularPayable.RegularPayableId + ": " + regularPayable.Name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            String s = comboBox1.Text.Split()[2];
            int id = Int32.Parse(s[0].ToString());

            MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this event?", "Delete Event", messageBoxButtons);

            if (dialogResult == DialogResult.Yes)
            {
                db.DeleteRegularPayable(id);
                db.LoadUsersPayable();
                MessageBox.Show("Regular Payable deleted successfully!");
                regularPayableForm.SetUpEvents();
                this.Dispose();

            }
            else
            {
                MessageBox.Show("Regular Payable deletion cancelled.");
                return;
            }
        }
    }
}
