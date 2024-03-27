using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using Mabolo_Dormitory_System.Classes;

namespace Mabolo_Dormitory_System
{
    public partial class dormersTab : UserControl
    {
        DatabaseManager db = new DatabaseManager();
        List<User> users;
        public dormersTab()
        {
            InitializeComponent();
            users = new List<User>();    
            users = db.GetAllUsers();
           
            dormerTableView.DataSource = users;
            dormerTableView.DefaultCellStyle.Font = new Font("Century Gothic", 12);
            dormerTableView.DefaultCellStyle.ForeColor = Color.Black;
            dormerTableView.AllowUserToResizeRows = false;
            
            dormerTableView.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dormerTableView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(40, 167, 69);
            dormerTableView.ColumnHeadersDefaultCellStyle.Font = new Font( "Century Gothic", 14, FontStyle.Bold);
            
            dormerTableView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dormerTableView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dormerTableView.RowTemplate.Height = 40;
            dormerTableView.Columns[8].Visible = false;
            dormerTableView.Columns[10].Visible = false;
            dormerTableView.Columns[7].Visible = false;

           
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.Items.AddRange("Update","View", "Delete");
            
            comboBoxColumn.HeaderText = "Action";
            comboBoxColumn.ValueType = typeof(String);
            dormerTableView.Columns.Add(comboBoxColumn);
            
            dormerTableView.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dataGridView1_EditingControlShowing);
            dormerTableView.Columns[0].Width = 30;
            dormerTableView.Columns[1].HeaderText = "User ID";
            dormerTableView.Columns[2].HeaderText = "First Name";
            dormerTableView.Columns[3].HeaderText = "Last Name";
            dormerTableView.Columns[4].HeaderText = "Birthday";
            dormerTableView.Columns[5].HeaderText = "Email";
            dormerTableView.Columns[6].HeaderText = "Phone Number";
            dormerTableView.Columns[7].HeaderText = "User Type";

           
        }
        private void dataGridView1_EditingControlShowing(object sender,DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox combo = e.Control as ComboBox;
            if (combo != null)
            {
                combo.SelectedIndexChanged -= new EventHandler(ComboBox_SelectedIndexChanged);
                combo.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            }
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedItem != null)
            {
                int i = dormerTableView.CurrentRow.Index; 
                if(cb.SelectedItem.ToString() == "Update")
                {
                    MessageBox.Show("Updated");
                }
                else if(cb.SelectedItem.ToString() == "View")
                {
                    ViewForm viewForm = new ViewForm();
                    SetFormLocation(viewForm);
                    viewForm.SetInformation(users, i);
                    viewForm.Show();
                }
                else if(cb.SelectedItem.ToString() == "Delete")
                {
                    MessageBox.Show("Delete");
                }   
            }
        }
        private void SetFormLocation(Form form)
        {
            form.StartPosition = FormStartPosition.Manual;
            int x = Screen.PrimaryScreen.Bounds.Width - form.Width - Convert.ToInt32(10 * 96 / 2.54);
            int y = ((Screen.PrimaryScreen.Bounds.Height - form.Height) / 2);
            form.Location = new Point(x, y);
        }
        

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
