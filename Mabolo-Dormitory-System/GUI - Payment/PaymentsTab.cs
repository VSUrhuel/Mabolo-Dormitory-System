using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mabolo_Dormitory_System.Classes;
using Microsoft.Extensions.Logging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Mabolo_Dormitory_System.GUI___Payment
{
    public partial class PaymentsTab : UserControl
    {
        private Form form;
        private List<Event> events;
        private List<User> users;
        private List<Payment> payments;
        private List<Classes.RegularPayable> regularPayables;
        private DatabaseManager db;
        public PaymentsTab(Form form)
        {
            
            this.form = form;
            users = new List<User>();
            events = new List<Event>();
            payments = new List<Payment>();
            regularPayables = new List<Classes.RegularPayable>();
            db = new DatabaseManager();
            InitializeComponent();
            count.Text = "";
            over.Text = "";
            //db.LoadUserPayable();
            //MessageBox.Show(regularPayablesCB.Text);
            events = db.GetAllEvents();
            users = db.GetAllUsersExcpetAdmin();
            regularPayables = db.GetRegularPayables();
            payments =  db.GetAllPayment();
            SetupTable(users);
        }
        private void SetupTable(List<User> users, int n = 60)
        {
            dormerTableView.DataSource = null;
            dormerTableView.Rows.Clear();
            dormerTableView.DefaultCellStyle.Font = new Font("Century Gothic", 12);
            dormerTableView.DefaultCellStyle.ForeColor = Color.Black;
            dormerTableView.AllowUserToResizeRows = false;
            dormerTableView.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dormerTableView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(40, 167, 69);
            dormerTableView.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            dormerTableView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dormerTableView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dormerTableView.RowTemplate.Height = 40;
            dormerTableView.Columns["RemainingBalance"].DefaultCellStyle.Format = "₱ #,##0.00";
            //Combo box
            //MessageBox.Show(users.Count.ToString());    
            dormerTableView.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dormerTableView_EditingControlShowing);
            int i = 0;
            foreach (User u in users)
            {
                if (u != null)
                {
                    if (i > (n - 1))
                        break;
                   
                    dormerTableView.Rows.Add(u.UserId, u.FirstName, u.LastName);
                    i++;
                }
            }


            foreach (DataGridViewRow row in dormerTableView.Rows)
            {
                String username = row.Cells["UserId"].Value.ToString();
                float x = db.GetUserPayableBalance(username);
                String status = x > 0 ? "PENDING" : "PAID";
                row.Cells["RemainingBalance"].Value = x;
                row.Cells["Status"].Value = status;
            }

        }
        private void RefreshTable()
        {

        }

        private void dormerTableView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
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
                if (cb.SelectedItem.ToString() == "Add Payment")
                {
                    PaymentTransaction paymentTransaction = new PaymentTransaction(db.GetUser(
                dormerTableView.Rows[i].Cells["UserId"].Value.ToString()), this);
                    SetFormLocation(paymentTransaction);
                    paymentTransaction.Owner = form;
                    paymentTransaction.Show();
                }
                else
                {
                    ViewPayment viewPayment = new ViewPayment(db.GetUser(
                dormerTableView.Rows[i].Cells["UserId"].Value.ToString()));
                    SetFormLocation(viewPayment);
                    viewPayment.Owner = form;
                    viewPayment.Show();
                }
            }
        }


        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchBar.Text = "Search...";   
            dormerTableView.DataSource = null;
            dormerTableView.Rows.Clear();
            itemCB.Text = "60";
            String status = statusCB.SelectedItem.ToString();
            if (status == "All")
            {
                users = db.GetAllUsersExcpetAdmin();
                SetupTable(users);
            }
            else
            {
                users.Clear();
                //MessageBox.Show(users.Count.ToString());
                if (status == "Pending")
                {
                    users = db.GetPendingUsers();
                    
                }
                else
                {
                    users.Clear();
                    users = db.GetPaidUsers();
                    
                }

                
                if (users.Count == 0)
                {
                    MessageBox.Show("No " + status + " status was found");
                    users.Clear();
                    SetupTable(users);
                }
                else
                    SetupTable(users);
            }
        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void dormerTableView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*aymentTransaction paymentTransaction = new PaymentTransaction(db.GetUser(
                dormerTableView.Rows[e.RowIndex].Cells["UserId"].Value.ToString()));
            SetFormLocation(paymentTransaction);
            paymentTransaction.Show();*/
            
        }

        private void SetFormLocation(Form form)
        {
            form.StartPosition = FormStartPosition.Manual;
            int x = Screen.PrimaryScreen.Bounds.Width - form.Width - Convert.ToInt32(10 * 96 / 2.54);
            int y = ((Screen.PrimaryScreen.Bounds.Height - form.Height) / 2);
            form.Location = new Point(x, y);
        }

        private void updateViewButton_Click(object sender, EventArgs e)
        {
           
            foreach(DataGridViewRow row in dormerTableView.Rows)
            {
                try
                {
                    Convert.ToDouble(row.Cells["Amount"].Value);
                }
                catch
                {
                    MessageBox.Show("Please enter valid amount.");
                    return;
                }

            }
            /*foreach (DataGridViewRow row in dormerTableView.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Attendance"].Value))
                    db.AddPayment(ID, row.Cells["Attendance"].Value.ToString(), Convert.ToDouble(row.Cells["Amount"].Value);
                else
                   db.RecordAttendance(row.Cells["UserId"].Value.ToString(), EventId, "Absent");
            }*/
            MessageBox.Show("Attendance Updated!");
        }

        private void regularPayablesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        public void refreshBut_Click(object sender, EventArgs e)
        {
            users.Clear();
            users = db.GetAllUsersExcpetAdmin();
            SetupTable(users);
        }

        private void itemCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchBar.Text = "Search...";
            if (statusCB.Text == "")
                users = db.GetAllUsersExcpetAdmin();
            int n = Convert.ToInt32(itemCB.SelectedItem);
            count.Text = 1.ToString();
            over.Text = (Math.Ceiling((double)(users.Count / ((double)n))).ToString());
            
            SetupTable(users, n);
        }

        private void searchBar_Click(object sender, EventArgs e)
        {
            searchBar.Text = "";
        }

        private void searchBut_Click(object sender, EventArgs e)
        {
            if (searchBar.Text == "" || searchBar.Text == "Search...")
            {
                MessageBox.Show("Please enter a valid User ID to search");
                searchBar.Text = "";
                return;
            }
            String userId = searchBar.Text;
            
            List<User> u2 = users.Select(u => u).ToList();
            users.Clear();
            foreach (User u in u2)
            {
                if (u.UserId.Contains(userId))
                {
                    users.Add(u);
                }
            }
            if (users.Count == 0)
            {
                MessageBox.Show("No user with the ID: '" + userId + "' with status: '" + statusCB.Text + "' was found");
                users = db.GetAllUsersExcpetAdmin();
            }
            SetupTable(users);
        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            if (count.Text == "")
            {
                MessageBox.Show("Please select the number of items to display");
                return;
            }
            if (Convert.ToInt32(count.Text) == Convert.ToInt32(over.Text))
            {
                MessageBox.Show("You are already at the last page");
                return;
            }
            else if(Convert.ToInt32(count.Text) < Convert.ToInt32(over.Text))
            {// Assuming db.GetAllUsersExcpetAdmin() returns a List<User>

                int pageNumber = Convert.ToInt32(count.Text);  
                int pageSize = Convert.ToInt32(itemCB.SelectedItem);
                if (statusCB.Text == "")
                    users = db.GetAllUsersExcpetAdmin();
                List<User> usersForPage = users.Skip(pageNumber * pageSize).Take(pageSize).ToList();
                count.Text = (pageNumber+1).ToString(); 
                SetupTable(usersForPage);  
            }

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            if(count.Text == "")
            {
                MessageBox.Show("Please select the number of items to display");
                return;
            }
            else
            if(Convert.ToInt32(count.Text) == 1)
            {
                MessageBox.Show("You are already at the first page");
                return;
            }
            else if(Convert.ToInt32(count.Text) > 1 )
            {
                int pageNumber = Convert.ToInt32(count.Text)-2;
                int pageSize = Convert.ToInt32(itemCB.SelectedItem);
                if (statusCB.Text == "")
                    users = db.GetAllUsersExcpetAdmin();
                List<User> usersForPage = users.Skip(pageNumber * pageSize).Take(pageSize).ToList();
                
                count.Text = (pageNumber+1).ToString();
                SetupTable(usersForPage);
            }
        }

        private void addDormerButton_Click(object sender, EventArgs e)
        {
            PaymentsSummary paymentsSummary = new PaymentsSummary();
            SetFormLocation(paymentsSummary);
            paymentsSummary.Owner = form;
            paymentsSummary.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            RegularPayableForm regularPayable = new RegularPayableForm(this);
            SetFormLocation(regularPayable);
            regularPayable.Owner = form;
            regularPayable.Show();
        }
    }
}
