using Guna.UI.WinForms;
using Mabolo_Dormitory_System.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mabolo_Dormitory_System
{
    public partial class roomTab : UserControl
    {
        private int roomNum = 0;
        private DatabaseManager db;
        private List<User> users;
        private Form form;
        public roomTab(Form form)
        {
            db = new DatabaseManager();
            InitializeComponent();
            this.form = form;
            // Set up Room Choose ComboBox
            for (int i = 1; i < 10; i++)
                roomChooseCB.Items.Add("Room " + i);
            roomChooseCB.Text = "1";
            
            // Set up Room User Default View 
            users = db.GetUsersInRoom(roomNum);
            SetUpTable(roomUserView, users);

        }
        private void SetUpTable(GunaDataGridView view, List<User> users)
        {
            // Reset Table
            view.Rows.Clear();
            view.Columns.Clear();

            // Set up Table
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "Column1";
            checkBoxColumn.HeaderText = "#";
            view.Columns.Add(checkBoxColumn);
            view.Columns.Add("UserId", "User ID");
            view.Columns.Add("FirstName", "First Name");
            view.Columns.Add("LastName", "Last Name");
            view.Columns.Add("Birthday", "Birthday");
            view.Columns.Add("Email", "Email");
            view.Columns.Add("PhoneNumber", "Phone Number");
            view.Columns.Add("UserType", "User Type");

            // Set up Table Style
            view.Columns["Column1"].Width = 50;
            view.DefaultCellStyle.Font = new Font("Century Gothic", 12);
            view.DefaultCellStyle.ForeColor = Color.Black;
            view.AllowUserToResizeRows = false;
            view.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            view.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(40, 167, 69);
            view.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            view.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            view.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            view.RowTemplate.Height = 40;

            // Add ComboBox Column
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.Items.AddRange("Update", "View");
            comboBoxColumn.Name = "Action";
            comboBoxColumn.HeaderText = "Action";
            comboBoxColumn.ValueType = typeof(String);
            view.Columns.Add(comboBoxColumn);
            view.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dataGridView1_EditingControlShowing);
            
            // Add Data to Table
            foreach (DataGridViewColumn column in view.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (User user in users)
            {
                
                view.Rows.Add(false, user.UserId, user.FirstName, user.LastName, user.Birthday.ToString("yyyy/MM/dd"), user.Email, user.PhoneNumber, user.UserStatus);
            }
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
                int i = roomUserView.CurrentRow.Index;
                if (cb.SelectedItem.ToString() == "Update")
                {
                    UpdateForm update = new UpdateForm();
                    SetFormLocation(update);
                    update.SetInformation(users, i);
                    update.Owner = form;
                    update.Show();
                }
                else if (cb.SelectedItem.ToString() == "View")
                {
                    ViewForm viewForm = new ViewForm();
                    SetFormLocation(viewForm);
                    viewForm.SetInformation(users, i);
                    viewForm.Owner = form;
                    viewForm.Show();
                }
            }
        }

        private void CreateTable(GunaDataGridView view, List<User> users)
        {
            view.Rows.Clear();
            foreach (User user in users)
            { 
                view.Rows.Add(false, user.UserId, user.FirstName, user.LastName, user.Birthday.ToString("yyyy/MM/dd"), user.Email, user.PhoneNumber, user.UserType);
            }  
        }

        private void roomChooseCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            String text = roomChooseCB.SelectedItem.ToString().Split()[1];
            roomNum = Convert.ToInt32(text);
            CreateTable(roomUserView, db.GetUsersInRoom(roomNum)); 
        }

        private void SetFormLocation(Form form)
        {
            form.StartPosition = FormStartPosition.Manual;
            int x = Screen.PrimaryScreen.Bounds.Width - form.Width - Convert.ToInt32(10 * 96 / 2.54);
            int y = ((Screen.PrimaryScreen.Bounds.Height - form.Height) / 2);
            form.Location = new Point(x, y);
          
        }

        private void add1_Click(object sender, EventArgs e)
        {
            if(roomNum == 0)
            {
                MessageBox.Show("No room selected.\nPlease choose one before proceeding.");
                return;
            }
            if(!db.GetRoom(roomNum).CanIncreaseOccupancy(1))
            { 
                MessageBox.Show("Maximum room capacity reached.\nPlease try another room.");
                return;
            }
 
            AddRoomAllocation add = new AddRoomAllocation(roomNum, this);
            SetFormLocation(add);
            add.Owner = form;
            add.Show();
            
        }

        public void refreshBut_Click(object sender, EventArgs e)
        {
            CreateTable(roomUserView, db.GetUsersInRoom(roomNum));
        }

        private void delBut_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
            bool isChecked = false, hasChecked = false;    
            foreach (DataGridViewRow row in roomUserView.Rows)
            {
                if (row.Cells["Column1"].Value != null && Convert.ToBoolean(row.Cells["Column1"].Value))
                {
                    hasChecked = true;
                    DialogResult dialogResult = MessageBox.Show("Confirmation required: Remove user from room?", "Delete", messageBoxButtons);
                    if (dialogResult == DialogResult.Yes)
                    {
                        isChecked = true;
                        db.DeleteUser(row.Cells["UserId"].Value.ToString());
                        roomUserView.Rows.Remove(row);
                    }
                    else
                        return;
                }
            }
            if (!hasChecked)
            {
                MessageBox.Show("No rows selected for deletion.");
                return;
            }
            if (!isChecked)
                MessageBox.Show("Deletion cancelled.");
            else
                MessageBox.Show("Selected row(s) deleted successfully");
            
        }

        private void roomUserView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns["Column1"] is DataGridViewCheckBoxColumn && e.RowIndex > -1)
            {
                if(!Convert.ToBoolean(senderGrid.Rows[e.RowIndex].Cells["Column1"].Value))
                    senderGrid.Rows[e.RowIndex].Cells["Column1"].Value = true;
   
                else
                    senderGrid.Rows[e.RowIndex].Cells["Column1"].Value = false;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if(roomNum == 0)
            {
                MessageBox.Show("No room selected.\nPlease choose one before proceeding.");
                return;
            }
            var EditForm = new RoomReallocation(roomNum, this);
            SetFormLocation(EditForm);
            EditForm.Owner = form; 
            EditForm.Show();
        }

        private void selectAllCB_CheckedChanged(object sender, EventArgs e)
        {
            if(roomChooseCB.Text == "")
            {
                MessageBox.Show("No room selected.\nPlease choose one before proceeding.");
               
                return;
            }
            if(roomUserView.Rows.Count == 0)
            {
                MessageBox.Show("No users in room.");
                
                return;
            }
            if (selectAllCB.Checked)
            {
                for (int i = roomUserView.Rows.Count - 1; i >= 0; i--)
                {
                    DataGridViewRow row = roomUserView.Rows[i];
                    row.Cells["Column1"].Value = true;
                }
            }
            else
            {
                for (int i = roomUserView.Rows.Count - 1; i >= 0; i--)
                {
                    DataGridViewRow row = roomUserView.Rows[i];
                    row.Cells["Column1"].Value = false;
                }
            }
        }
    }
}
