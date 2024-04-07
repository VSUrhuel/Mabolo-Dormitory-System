using Guna.UI.WinForms;
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
    public partial class RegularPayableForm : Form
    {
        private DatabaseManager db;
        private List<RegularPayable> regularPayables;
        private PaymentsTab paymentsTab;
        private bool mouseDown;
        private Point lastLocation;

        public RegularPayableForm(PaymentsTab paymentsTab)
        {
            this.paymentsTab = paymentsTab;
            this.db = new DatabaseManager();
            this.regularPayables = new List<RegularPayable>();
            InitializeComponent();
            // Add event handlers to the buttons
            foreach (GunaElipsePanel panel in flowLayoutPanel1.Controls.OfType<GunaElipsePanel>())
            {
                foreach (GunaAdvenceButton button in panel.Controls.OfType<GunaAdvenceButton>())
                {
                    button.Click += new EventHandler(eventBut_Click);
                }
            }
            SetUpEvents();
        }

        public void SetUpEvents()
        {
            // Hide all panels
            foreach (GunaElipsePanel panel in flowLayoutPanel1.Controls.OfType<GunaElipsePanel>())
            {
                panel.Visible = false;
            }

            regularPayables = db.GetRegularPayables();
            int i = 0;
            foreach (GunaElipsePanel panel in flowLayoutPanel1.Controls.OfType<GunaElipsePanel>())
            {

                if (i < regularPayables.Count)
                {
                    panel.Visible = true;
                    panel.Controls.OfType<Label>().ToList()[0].Text = "ID: " + regularPayables[i].RegularPayableId.ToString();
                    panel.Controls.OfType<Label>().ToList()[2].Text = regularPayables[i].Name.ToString();
                    panel.Controls.OfType<Label>().ToList()[1].Text = "₱ " + regularPayables[i].Amount.ToString("N2"); 
                    i++;
                }
                else if (i >= regularPayables.Count)
                    break;
            }
        }
        private void eventBut_Click(object sender, EventArgs e)
        {
            // Get the event id
            GunaAdvenceButton button = (GunaAdvenceButton)sender;
            GunaElipsePanel panel = (GunaElipsePanel)button.Parent;
            char id = 'a';
            foreach (GunaElipsePanel panel1 in flowLayoutPanel1.Controls.OfType<GunaElipsePanel>())
            {
                if (panel1 == panel)
                    id = (panel.Controls.OfType<Label>().ToList()[0].Text.Last());
            }
            int x = int.Parse(id.ToString());
            RegularPayableView regularPayableView = new RegularPayableView(this, x);
            regularPayableView.Owner = this;
            SetFormLocation(regularPayableView);
            regularPayableView.Show();

        }


        private void RegularPayable_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void closeRegularPayableBut_Click(object sender, EventArgs e)
        {
            paymentsTab.refreshBut_Click(sender, e);
            this.Dispose();
        }

        private void SetFormLocation(Form form)
        {
            form.StartPosition = FormStartPosition.Manual;
            int x = Screen.PrimaryScreen.Bounds.Width - form.Width;
            int y = ((Screen.PrimaryScreen.Bounds.Height - form.Height) / 2);
            form.Location = new Point(x*1/75, y);
        }

        private void addDormerButton_Click(object sender, EventArgs e)
        {
            AddRegularPayableForm addRegularPayableForm = new AddRegularPayableForm(this, paymentsTab);
            addRegularPayableForm.Owner = this;
            SetFormLocation(addRegularPayableForm);
            addRegularPayableForm.Show();
        }

        private void gunaAdvenceButton7_Click(object sender, EventArgs e)
        {

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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeletRegularPayable deletRegularPayable = new DeletRegularPayable(this);
            deletRegularPayable.Owner = this;
            SetFormLocation(deletRegularPayable);
            deletRegularPayable.Show();

        }
    }
}
