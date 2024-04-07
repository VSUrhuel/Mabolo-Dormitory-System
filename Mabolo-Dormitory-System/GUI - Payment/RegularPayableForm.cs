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

        public RegularPayableForm()
        {
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

        private void SetUpEvents()
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
                    panel.Controls.OfType<Label>().ToList()[0].Text = "₱ " + regularPayables[i].Amount.ToString("N2");
                    panel.Controls.OfType<Label>().ToList()[1].Text = "₱ " + regularPayables[i].Name.ToString("N2");
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

            // Open the view event form
            ViewEvent viewEvent = new ViewEvent(form, x);
            viewEvent.Owner = form;
            SetFormLocation(viewEvent);
            viewEvent.Show();
        }


        private void RegularPayable_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
