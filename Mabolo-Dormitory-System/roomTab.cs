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
        public int roomNum = 0;
        public DatabaseManager db;
        private List<User> users;
      
        public roomTab()
        {
            db = new DatabaseManager();
            InitializeComponent();
            for (int i = 1; i < 10; i++)
                roomChooseCB.Items.Add("Room " + i);
            roomChooseCB.Text = "1";
           
            users = db.GetUsersInRoom(roomNum);
            SetUpTable(bigBrodView, users);

        }
        private void SetUpTable(GunaDataGridView view, List<User> users)
        {
            view.Rows.Clear();
            view.Columns.Clear();
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

            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.Items.AddRange("Update", "View");
            comboBoxColumn.Name = "Action";
            comboBoxColumn.HeaderText = "Action";
            comboBoxColumn.ValueType = typeof(String);
            view.Columns.Add(comboBoxColumn);

            view.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dataGridView1_EditingControlShowing);

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
          // MessageBox.Show(sender.ToString());
            if (cb.SelectedItem != null)
            {
                int i = bigBrodView.CurrentRow.Index;
                if (cb.SelectedItem.ToString() == "Update")
                {
                    UpdateForm update = new UpdateForm();
                    SetFormLocation(update);
                    update.SetInformation(users, i);
                    update.Show();
                   // cb.SelectedIndexChanged -= new EventHandler(ComboBox_SelectedIndexChanged);
                }
                else if (cb.SelectedItem.ToString() == "View")
                {
                    ViewForm viewForm = new ViewForm();
                    SetFormLocation(viewForm);
                    viewForm.SetInformation(users, i);
                    viewForm.Show();
                  //  cb.SelectedIndexChanged -= new EventHandler(ComboBox_SelectedIndexChanged);
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
            String text = roomChooseCB.SelectedItem.ToString();
            text = text.Split()[1];
            roomNum = Convert.ToInt32(text);
            //MessageBox.Show("Room " + roomNum);
            CreateTable(bigBrodView, db.GetUsersInRoom(roomNum));
           
        }

        private void add2_Click(object sender, EventArgs e)
        {
            AddRoomAllocation add = new AddRoomAllocation(roomNum, "Regular Dormer");
            SetFormLocation(add);
            add.Show();
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
            AddRoomAllocation add = new AddRoomAllocation(roomNum, "Big Brod");
            SetFormLocation(add);
            add.Show();
            
        }


        private void refreshBut_Click(object sender, EventArgs e)
        {
            CreateTable(bigBrodView, db.GetUsersInRoom(roomNum));
        }

        private void delBut_Click(object sender, EventArgs e)
        {
            bool isChecked = false;
            for (int i = bigBrodView.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = bigBrodView.Rows[i];
                if (row.Cells["Column1"].Value != null && Convert.ToBoolean(row.Cells["Column1"].Value))
                {
                    isChecked = true;
                    db.DeleteUser(row.Cells["UserId"].Value.ToString());
                    bigBrodView.Rows.RemoveAt(i);
                }
            }

            if (!isChecked)
            {
                MessageBox.Show("Please select a row(s) to delete");
            }
            else
            {
                MessageBox.Show("Selected row(s) deleted successfully");
            }
        }

        private void bigBrodView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var EditForm = new EditForm(roomNum);
            SetFormLocation(EditForm);
            EditForm.Show();
        }
    }
}
