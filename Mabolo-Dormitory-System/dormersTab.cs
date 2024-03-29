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
        private DatabaseManager db;
        private List<User> users;
        public dormersTab()
        {
            db = new DatabaseManager();
            InitializeComponent();
            users = new List<User>();    
            users = db.GetAllUsers();
            RefreshTable();
        }

        public void RefreshTable(int n = 60)
        {
            // Reset Table
            if (dormerTableView.Columns.Contains("Action"))
            {
                dormerTableView.Columns["Action"].Visible = false;
                dormerTableView.Columns.Remove("Action");
            }
            dormerTableView.DataSource = null;
            List<User> u2 = null;
            if(n == 60)
                u2 = users.GetRange(0, users.Count);
            else
                u2 = users.GetRange(0, n);
            
            // Set up Table Style
            dormerTableView.DataSource = u2;
            dormerTableView.DefaultCellStyle.Font = new Font("Century Gothic", 12);
            dormerTableView.DefaultCellStyle.ForeColor = Color.Black;
            dormerTableView.AllowUserToResizeRows = false;
            dormerTableView.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dormerTableView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(40, 167, 69);
            dormerTableView.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            dormerTableView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dormerTableView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dormerTableView.RowTemplate.Height = 40;
            dormerTableView.Columns["UserStatus"].Visible = false;
            dormerTableView.Columns["Address"].Visible = false;
            dormerTableView.Columns["FK_DepartmentId"].Visible = false;
            dormerTableView.Columns[0].Width = 30;
               
            // Add Action Column
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.Items.AddRange("Update", "View", "Delete");
            comboBoxColumn.Name = "Action";
            comboBoxColumn.HeaderText = "Action";
            comboBoxColumn.ValueType = typeof(String);
            dormerTableView.Columns.Add(comboBoxColumn);
            dormerTableView.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dataGridView1_EditingControlShowing);
            
           
           // Set up Column Header
            dormerTableView.Columns["UserId"].HeaderText = "User ID";
            dormerTableView.Columns["FirstName"].HeaderText = "First Name";
            dormerTableView.Columns["LastName"].HeaderText = "Last Name";
            dormerTableView.Columns["Birthday"].HeaderText = "Birthday";
            dormerTableView.Columns["Email"].HeaderText = "Email";
            dormerTableView.Columns["PhoneNumber"].HeaderText = "Phone Number";
            dormerTableView.Columns["UserType"].HeaderText = "UserType";
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
                    UpdateForm update = new UpdateForm();
                    SetFormLocation(update);
                    update.SetInformation(users, i);
                    update.Show();
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
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Are you sure you want to delete " + users[i].FirstName + " " + users[i].LastName + "'s information?\nThis action cannot be undone.", "Confirmation", buttons);
                    if(result == DialogResult.Yes)
                    {
                        db.DeleteUser(users[i].UserId);
                        MessageBox.Show(users[i].FirstName + " " + users[i].LastName + "'s information was Deleted");
                        RefreshTable();
                    }
                    else
                    {
                        MessageBox.Show("Delete Cancelled");
                    }
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
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns["Column1"] is DataGridViewCheckBoxColumn && e.RowIndex > -1)
            {
                if (!Convert.ToBoolean(senderGrid.Rows[e.RowIndex].Cells["Column1"].Value))
                {
                    senderGrid.Rows[e.RowIndex].Cells["Column1"].Value = true;
                }
                else
                {
                    senderGrid.Rows[e.RowIndex].Cells["Column1"].Value = false;
                }
            }
        }

        private void refreshBut_Click(object sender, EventArgs e)
        {
            users = db.GetAllUsers();
            
            RefreshTable();
        }

        private void itemCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(itemCB.SelectedItem.ToString());
            if(index > users.Count)
            {
                RefreshTable();
            }
            else
                RefreshTable(index);
        }

        private void userTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemCB.Text = "60";
            String userType = userTypeCB.SelectedItem.ToString();
            if(userType == "All")
            {
                users = db.GetAllUsers();
                RefreshTable();
            }
            else
            {
                users = db.GetAllUsers();
                List<User> u2 = users.Select(u => u).ToList();
                
                users.Clear();
                foreach(User u in u2)
                {
                    if(u.UserType == userType)
                    {
                        users.Add(u);
                    }
                }
                if(users.Count == 0)
                {
                    MessageBox.Show("No " + userType + " found");
                    users = db.GetAllUsers();
                    RefreshTable();
                }
                else
                    RefreshTable();
            }
        }   

        private void searchBar_MouseClick(object sender, MouseEventArgs e)
        {
            searchBar.Text = "";
            
        }

        private void searchBar_Click(object sender, EventArgs e)
        {
            searchBar.Text = "";
        }

        private void searchBut_Click(object sender, EventArgs e)
        {
            if(searchBar.Text == "" || searchBar.Text == "Search...")
            {
                MessageBox.Show("Please enter a User ID to search");
                searchBar.Text = "";
                return;
            }
            String userId = searchBar.Text;
            users = db.GetAllUsers();
            List<User> u2 = users.Select(u => u).ToList();
            users.Clear();
            foreach(User u in u2)
            {
                if(u.UserId.Contains(userId))
                {
                    users.Add(u);
                }
            }
            if(users.Count == 0)
            {
                MessageBox.Show("No user with the ID " + userId + " found");
                users = db.GetAllUsers();
            }
            RefreshTable();
        }

        private void addDormerButton_Click(object sender, EventArgs e)
        {
            AddDormerForm addDormerForm = new AddDormerForm();
            SetFormLocation(addDormerForm);
            addDormerForm.Show();
        }
       
        private void selectAllCB_CheckedChanged(object sender, EventArgs e)
        {
            if (selectAllCB.Checked)
            {
                for (int i = dormerTableView.Rows.Count - 1; i >= 0; i--)
                {
                    DataGridViewRow row = dormerTableView.Rows[i];
                    row.Cells["Column1"].Value = true;
                }
            }
            else
            {
                for (int i = dormerTableView.Rows.Count - 1; i >= 0; i--)
                {
                    DataGridViewRow row = dormerTableView.Rows[i];
                    row.Cells["Column1"].Value = false;
                }
            }
        }

        private void delBut_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
            bool isChecked = false;
            foreach (DataGridViewRow row in dormerTableView.Rows)
            {
                if (row.Cells["Column1"].Value != null && Convert.ToBoolean(row.Cells["Column1"].Value))
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the selected rows?\nThis action cannot be undone!", "Delete", messageBoxButtons);
                    if (dialogResult == DialogResult.Yes)
                    {
                        isChecked = true;

                        db.DeleteUser(row.Cells["UserId"].Value.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Selected row(s) not deleted");
                        break;
                    }
                }
            }
            if (!isChecked)
                MessageBox.Show("Please select a row(s) to delete");
            else
                MessageBox.Show("Selected row(s) deleted successfully");
        }
    }
}
