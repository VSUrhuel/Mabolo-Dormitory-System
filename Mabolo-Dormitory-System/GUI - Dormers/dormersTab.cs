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
using DGVPrinterHelper;

namespace Mabolo_Dormitory_System
{
    public partial class dormersTab : UserControl
    {
        private DatabaseManager db;
        private List<User> users;
        private Form form;
        public dormersTab(Form form)
        {
            this.db = new DatabaseManager();
            this.form = form;
            this.users = new List<User>();
            InitializeComponent();
            count.Text = "";
            over.Text = "";
            users = db.GetAllUsers();
            RefreshTable(users);
        }

        public void RefreshTable(List<User> users, int n = 60)
        {
            // Reset Textboxes
            userTypeCB.Text = viewCountCB.Text = "";

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
            dormerTableView.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dormerTableView_EditingControlShowing);
            
           
           // Set up Column Header
            dormerTableView.Columns["UserId"].HeaderText = "User ID";
            dormerTableView.Columns["FirstName"].HeaderText = "First Name";
            dormerTableView.Columns["LastName"].HeaderText = "Last Name";
            dormerTableView.Columns["Birthday"].HeaderText = "Birthday";
            dormerTableView.Columns["Email"].HeaderText = "Email";
            dormerTableView.Columns["PhoneNumber"].HeaderText = "Phone Number";
            dormerTableView.Columns["UserType"].HeaderText = "UserType"; 
        }

        private void dormerTableView_EditingControlShowing(object sender,DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox combo = e.Control as ComboBox;
            if (combo != null)
            {
                combo.SelectedIndexChanged -= new EventHandler(ComboBoxAction_SelectedIndexChanged);
                combo.SelectedIndexChanged += new EventHandler(ComboBoxAction_SelectedIndexChanged);
            }
        }
       
        private void ComboBoxAction_SelectedIndexChanged(object sender, EventArgs e)
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
                    update.Owner = form;
                    update.Show();
                }
                else if(cb.SelectedItem.ToString() == "View")
                {
                    ViewForm viewForm = new ViewForm();
                    SetFormLocation(viewForm);
                    viewForm.SetInformation(users, i);
                    viewForm.Owner = form;
                    viewForm.Show();
                }
                else if(cb.SelectedItem.ToString() == "Delete")
                {
                    DialogResult result = MessageBox.Show("Do you want to delete " + users[i].FirstName + " " + users[i].LastName + "" +
                        "'s Information?\nThis action is irreversible.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show(users[i].FirstName + " " + users[i].LastName + "'s information was sucesfully deleted.", "Sucessfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.DeleteUser(users[i].UserId);
                        RefreshTable(users);
                        refreshButtton_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Deletion was cancelled", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dormerTableView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        public void refreshButtton_Click(object sender, EventArgs e)
        {
            viewCountCB.Text = "60";
            userTypeCB.Text = "All";
            searchBar.Text = "";
            users = db.GetAllUsers();
            RefreshTable(users);
        }

        private void viewCountCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchBar.Text = "Search...";
            int n = Convert.ToInt32(viewCountCB.SelectedItem);
            count.Text = 1.ToString();
            over.Text = (Math.Ceiling((double)(users.Count / ((double)n))).ToString());
            int index = Convert.ToInt32(viewCountCB.SelectedItem.ToString());
            if(index > users.Count)
            {
                RefreshTable(users);
            }
            else
                RefreshTable(users, index);
        }

        private void userTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchBar.Text = "Search...";
            viewCountCB.Text = "60";
            String userType = userTypeCB.SelectedItem.ToString();
            if(userType == "All")
            {
                users = db.GetAllUsers();
                RefreshTable(users);
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
                    MessageBox.Show("No " + userType + " was Found", "Information", MessageBoxButtons.OK ,MessageBoxIcon.Information);
                    users = db.GetAllUsers();
                    RefreshTable(users);
                }
                else
                    RefreshTable(users);
            }
        }   


        private void searchButton_Click(object sender, EventArgs e)
        {
            if(searchBar.Text == "" || searchBar.Text == "Search...")
            {
                MessageBox.Show("Please enter a valid User ID to search", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                searchBar.Text = "";
                return;
            }
            String userId = searchBar.Text;
            
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
                if((userTypeCB.Text == "All") || (userTypeCB.Text == ""))
                    MessageBox.Show("No user with the ID: '" + userId + "' was found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No user with the ID: '" + userId + "' with user type: '" + userTypeCB.Text + "' was found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                users = db.GetAllUsers();
            }
            RefreshTable(users);
        }

        private void addDormerButton_Click(object sender, EventArgs e)
        {
            AddDormerForm addDormerForm = new AddDormerForm(this);
            SetFormLocation(addDormerForm);
            addDormerForm.Owner = form;
            addDormerForm.Show();
        }
       
        private void selectAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(dormerTableView.Rows.Count == 0)
            {
                MessageBox.Show("No rows to select", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (selectAllCheckBox.Checked)
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

        private void deleteButtoon_Click(object sender, EventArgs e)
        {
            bool isChecked = false, hasChecked = false;
            int i = 0;
            foreach (DataGridViewRow row in dormerTableView.Rows)
            {
                if (row.Cells["Column1"].Value != null && Convert.ToBoolean(row.Cells["Column1"].Value))
                {
                    hasChecked = true;
                    if(i == 0)
                    {
                        DialogResult dialogResult = MessageBox.Show("Do you want to delete the selected rows?\nThis action is irreversible.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (row.Cells["UserType"].Value.ToString() == "Dormitory Adviser" || row.Cells["UserType"].Value.ToString() == "Assistant Dormitory Adviser")
                            {
                                MessageBox.Show("You cannot delete a Dormitory Adviser or Assistant Dormitory Adviser", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            isChecked = true;
                            db.DeleteUser(row.Cells["UserId"].Value.ToString());
                        }
                        else
                        {
                            return;
                        }
                        i++;
                    }
                    else
                        db.DeleteUser(row.Cells["UserId"].Value.ToString());
                    
                }
            }
            if(!hasChecked)
            {
                MessageBox.Show("No rows selected for deletion.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!isChecked)
                MessageBox.Show("No rows selected for deletion.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Selected rows deleted successfully", "Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshButtton_Click(sender, e);
        }

        private void moveNextPage_Click(object sender, EventArgs e)
        {
            if(viewCountCB.Text == "")
            {
                MessageBox.Show("Please select the number of items to display", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Convert.ToInt32(count.Text) == Convert.ToInt32(over.Text))
            {
                MessageBox.Show("You are already at the last page", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (Convert.ToInt32(count.Text) < Convert.ToInt32(over.Text))
            {
                int pageNumber = Convert.ToInt32(count.Text);
                int pageSize = Convert.ToInt32(viewCountCB.SelectedItem);
                List<User> usersForPage = users.Skip(pageNumber * pageSize).Take(pageSize).ToList();
                count.Text = (pageNumber + 1).ToString();
                RefreshTable(usersForPage);
            }
        }

        private void movePrevPage_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(count.Text) == 1)
            {
                MessageBox.Show("You are already at the first page", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (Convert.ToInt32(count.Text) > 1)
            {
                int pageNumber = Convert.ToInt32(count.Text) - 2;
                int pageSize = Convert.ToInt32(viewCountCB.SelectedItem);
                List<User> usersForPage = users.Skip(pageNumber * pageSize).Take(pageSize).ToList();

                count.Text = (pageNumber + 1).ToString();
                RefreshTable(usersForPage);
            }
        }

        private void searchBar_Enter(object sender, EventArgs e)
        {
            if(searchBar.Text == "Search...")
                searchBar.Text = "";
        }

        private void searchBar_Click(object sender, EventArgs e)
        {
            if (searchBar.Text == "Search...")
                searchBar.Text = "";
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            DGVPrinterHelper.DGVPrinter printer = new DGVPrinterHelper.DGVPrinter();
            printer.FooterFont = new Font("Arial", 8, FontStyle.Bold);
            printer.TitleFont = new Font("Century Gothic", 16, FontStyle.Bold);
            printer.SubTitleFont = new Font("Century Gothic", 10, FontStyle.Regular);
            printer.Title = "Mabolo Dormers List\n";
            printer.SubTitle = string.Format("Date: {0}\n", DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitle += string.Format("Time: {0}\n\n", DateTime.Now.ToString("HH:mm:ss"));
            
            printer.printDocument.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(50, 50, 50, 50);
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Mabolo Dormitory System";
            printer.FooterSpacing = 15;
            try
            {
                printer.PrintPreviewDataGridView(dormerTableView);
                printer.PrintDataGridView(dormerTableView);
            }
            catch
            {
                MessageBox.Show("An error occured while printing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
