using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mabolo_Dormitory_System.Classes
{
    public class DataGridTableSetUp
    {
        GunaDataGridView dormerTableView;
        DatabaseManager db = new DatabaseManager();
        List<User> users;
        //int i = 0;
        public DataGridTableSetUp(GunaDataGridView view, List<User> users)
        {
            this.dormerTableView = view;
            this.users = users;
            if (dormerTableView.Columns.Contains("Action"))
            {
                dormerTableView.Columns["Action"].Visible = false;
                dormerTableView.Columns.Remove("Action");
            }
            dormerTableView.DataSource = users;
            
            List<User> u2 = users;
           
            
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

            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.Items.AddRange("Update", "View", "Delete");
            comboBoxColumn.Name = "Action";
            comboBoxColumn.HeaderText = "Action";
            comboBoxColumn.ValueType = typeof(String);
            dormerTableView.Columns.Add(comboBoxColumn);
            
          //  dormerTableView.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dataGridView1_EditingControlShowing);


            dormerTableView.Columns["UserId"].HeaderText = "User ID";
            dormerTableView.Columns["FirstName"].HeaderText = "First Name";
            dormerTableView.Columns["LastName"].HeaderText = "Last Name";
            dormerTableView.Columns["Birthday"].HeaderText = "Birthday";
            dormerTableView.Columns["Email"].HeaderText = "Email";
            dormerTableView.Columns["PhoneNumber"].HeaderText = "Phone Number";
            dormerTableView.Columns["UserType"].HeaderText = "UserType";

        }
        public void CreateTable(GunaDataGridView view, List<User>users)
        {
            view.DataSource = null;
            if (view.Columns.Contains("Action"))
            {
                view.Columns["Action"].Visible = false;
                view.Columns.Remove("Action");
            }
            view.DataSource = users;

           
            view.DefaultCellStyle.Font = new Font("Century Gothic", 12);
            view.DefaultCellStyle.ForeColor = Color.Black;
            view.AllowUserToResizeRows = false;

            view.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            view.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(40, 167, 69);
            view.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 14, FontStyle.Bold);

            view.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            view.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            view.RowTemplate.Height = 40;
            view.Columns["UserStatus"].Visible = false;
            view.Columns["Address"].Visible = false;
            view.Columns["FK_DepartmentId"].Visible = false;

            view.Columns[0].Width = 30;

            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.Items.AddRange("Update", "View", "Delete");
            comboBoxColumn.Name = "Action";
            comboBoxColumn.HeaderText = "Action";
            comboBoxColumn.ValueType = typeof(String);
            dormerTableView.Columns.Add(comboBoxColumn);

            dormerTableView.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dataGridView1_EditingControlShowing);


            dormerTableView.Columns["UserId"].HeaderText = "User ID";
            dormerTableView.Columns["FirstName"].HeaderText = "First Name";
            dormerTableView.Columns["LastName"].HeaderText = "Last Name";
            dormerTableView.Columns["Birthday"].HeaderText = "Birthday";
            dormerTableView.Columns["Email"].HeaderText = "Email";
            dormerTableView.Columns["PhoneNumber"].HeaderText = "Phone Number";
            dormerTableView.Columns["UserType"].HeaderText = "UserType";
        }
        public void RefreshTable(GunaDataGridView view, List<User> users)
        {
            this.dormerTableView = view;
            this.users = users;
            if (dormerTableView.Columns.Contains("Action"))
            {
                dormerTableView.Columns["Action"].Visible = false;
                dormerTableView.Columns.Remove("Action");
            }
            dormerTableView.DataSource = users;

            List<User> u2 = users;


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

            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.Items.AddRange("Update", "View", "Delete");
            comboBoxColumn.Name = "Action";
            comboBoxColumn.HeaderText = "Action";
            comboBoxColumn.ValueType = typeof(String);
            dormerTableView.Columns.Add(comboBoxColumn);

            //  dormerTableView.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dataGridView1_EditingControlShowing);


            dormerTableView.Columns["UserId"].HeaderText = "User ID";
            dormerTableView.Columns["FirstName"].HeaderText = "First Name";
            dormerTableView.Columns["LastName"].HeaderText = "Last Name";
            dormerTableView.Columns["Birthday"].HeaderText = "Birthday";
            dormerTableView.Columns["Email"].HeaderText = "Email";
            dormerTableView.Columns["PhoneNumber"].HeaderText = "Phone Number";
            dormerTableView.Columns["UserType"].HeaderText = "UserType";

        }
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
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
                if (cb.SelectedItem.ToString() == "Update")
                {
                    UpdateForm update = new UpdateForm();
                    SetFormLocation(update);
                    update.SetInformation(users, i);
                    update.Show();
                    cb.SelectedIndexChanged -= new EventHandler(ComboBox_SelectedIndexChanged);
                }
                else if (cb.SelectedItem.ToString() == "View")
                {
                    ViewForm viewForm = new ViewForm();
                    SetFormLocation(viewForm);
                    viewForm.SetInformation(users, i);
                    viewForm.Show();
                    cb.SelectedIndexChanged -= new EventHandler(ComboBox_SelectedIndexChanged);
                }
                else if (cb.SelectedItem.ToString() == "Delete")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Are you sure you want to delete " + users[i].FirstName + " " + users[i].LastName + "'s information?\nThis action cannot be undone.", "Confirmation", buttons);
                    if (result == DialogResult.Yes)
                    {
                        db.DeleteUser(users[i].UserId);
                        MessageBox.Show(users[i].FirstName + " " + users[i].LastName + "'s information was Deleted");
                        //RefreshTable(users);
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


    }
}
