﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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
            db.LoadUsersPayable();
            InitializeComponent();
            count.Text = "";
            over.Text = "";
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
                else if(cb.SelectedItem.ToString() == "View Payments")
                {
                    ViewPayment viewPayment = new ViewPayment(db.GetUser(
                dormerTableView.Rows[i].Cells["UserId"].Value.ToString()));
                    SetFormLocation(viewPayment);
                    viewPayment.Owner = form;
                    viewPayment.Show();
                }
                else if(cb.SelectedItem.ToString() == "Payment Distribution")
                {
                    PaymentDistribution paymentDistribution = new PaymentDistribution(db.GetUser(
                dormerTableView.Rows[i].Cells["UserId"].Value.ToString()), this);
                    SetFormLocation(paymentDistribution);
                    paymentDistribution.Owner = form;
                    paymentDistribution.Show();
                }
            }
        }

        private void statusCB_SelectedIndexChanged(object sender, EventArgs e)
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
                    MessageBox.Show("No " + status + " status was found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    users.Clear();
                    SetupTable(users);
                }
                else
                    SetupTable(users);
            }
        }
      
        private void SetFormLocation(Form form)
        {
            form.StartPosition = FormStartPosition.Manual;
            int x = Screen.PrimaryScreen.Bounds.Width - form.Width - Convert.ToInt32(10 * 96 / 2.54);
            int y = ((Screen.PrimaryScreen.Bounds.Height - form.Height) / 2);
            form.Location = new Point(x, y);
        }

        public void refreshBut_Click(object sender, EventArgs e)
        {
            searchBar.Text = "";
            statusCB.Text = "All";
            itemCB.Text = "60";
            users.Clear();
            users = db.GetAllUsersExcpetAdmin();
            SetupTable(users);
        }

        private void itemCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchBar.Text = "Search...";
            if (statusCB.Text == "")
                users = db.GetAllUsersExcpetAdmin();
            else if(statusCB.Text == "Pending")
            {
                users = db.GetPendingUsers();
            }
            else if(statusCB.Text == "Paid")
            {
                users = db.GetPaidUsers();
            }
            else
            {
                users = db.GetAllUsersExcpetAdmin();
            }
            int n = Convert.ToInt32(itemCB.SelectedItem);
            if(users.Count == 0)
            {
                return;
            }
            count.Text = 1.ToString();
            over.Text = (Math.Ceiling((double)(users.Count / ((double)n))).ToString());
            
            SetupTable(users, n);
        }

        private void searchBar_Click(object sender, EventArgs e)
        {
            if(searchBar.Text == "Search...")
                searchBar.Text = "";
        }

        private void searchBut_Click(object sender, EventArgs e)
        {
            if (searchBar.Text == "" || searchBar.Text == "Search...")
            {
                MessageBox.Show("Please enter a valid User ID to search", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                searchBar.Text = "";
                return;
            }
            String name = searchBar.Text;
            users = db.GetAllUsersExcpetAdmin();
            List<User> u2 = users.Select(u => u).ToList();
            users.Clear();
            foreach (User u in u2)
            {
                if (u.FirstName.ToLower().Contains(name.ToLower()) || u.LastName.ToLower().Contains(name.ToLower()) || u.UserId.Contains(name))
                {
                    users.Add(u);
                }
            }
            if (users.Count == 0)
            {
                users = db.GetAllUsersExcpetAdmin();
            }
            SetupTable(users);
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            if (count.Text == "")
            {
                MessageBox.Show("Please select the number of items to display", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Convert.ToInt32(count.Text) == Convert.ToInt32(over.Text))
            {
                MessageBox.Show("You are already at the last page", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if(Convert.ToInt32(count.Text) < Convert.ToInt32(over.Text))
            {// Assuming db.GetAllUsersExcpetAdmin() returns a List<User>

                int pageNumber = Convert.ToInt32(count.Text);  
                int pageSize = Convert.ToInt32(itemCB.SelectedItem);
                if (statusCB.Text == "" || statusCB.Text == "All")
                    users = db.GetAllUsersExcpetAdmin();
                List<User> usersForPage = users.Skip(pageNumber * pageSize).Take(pageSize).ToList();
                count.Text = (pageNumber+1).ToString(); 
                SetupTable(usersForPage);  
            }

        }

        private void prevPage_Click(object sender, EventArgs e)
        {
            if(count.Text == "")
            {
                MessageBox.Show("Please select the number of items to display", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            if(Convert.ToInt32(count.Text) == 1)
            {
                MessageBox.Show("You are already at the first page", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if(Convert.ToInt32(count.Text) > 1 )
            {
                int pageNumber = Convert.ToInt32(count.Text)-2;
                int pageSize = Convert.ToInt32(itemCB.SelectedItem);
                if (statusCB.Text == "" || statusCB.Text == "All")
                    users = db.GetAllUsersExcpetAdmin();

                List<User> usersForPage = users.Skip(pageNumber * pageSize).Take(pageSize).ToList();
                
                count.Text = (pageNumber+1).ToString();
                SetupTable(usersForPage);
            }
        }

        private void paymentsSummary_Click(object sender, EventArgs e)
        {
            PaymentsSummary paymentsSummary = new PaymentsSummary();
            SetFormLocation(paymentsSummary);
            paymentsSummary.Owner = form;
            paymentsSummary.Show();
        }

        private void regularPayablesBut_Click(object sender, EventArgs e)
        {
            RegularPayableForm regularPayable = new RegularPayableForm(this);
            SetFormLocation(regularPayable);
            regularPayable.Owner = form;
            regularPayable.Show();
        }

        private void searchBar_Enter(object sender, EventArgs e)
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
            printer.Title = "Mabolo Payments List\n";
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

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            if(searchBar.Text == "" || searchBar.Text == "Search...")
            {
                users = db.GetAllUsersExcpetAdmin();
                List<User> u3 = users.Select(u => u).ToList();
                SetupTable(u3);
                return;
            }
            String name = searchBar.Text;
            users = db.GetAllUsersExcpetAdmin();
            List<User> u2 = users.Select(u => u).ToList();
            users.Clear();
            foreach (User u in u2)
            {
                if (u.FirstName.ToLower().Contains(name.ToLower()) || u.LastName.ToLower().Contains(name.ToLower()) || u.UserId.Contains(name))
                {
                    users.Add(u);
                }
            }
            SetupTable(users);
        }

        private void dormerTableView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
