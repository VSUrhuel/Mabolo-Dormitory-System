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

namespace Mabolo_Dormitory_System.GUI___Event
{
    public partial class EventTab : UserControl
    {
        private DatabaseManager db;
        private List<Event> events;
        private Form form;
        public EventTab(Form form)
        {
            this.form = form;
            InitializeComponent();

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
            foreach (GunaElipsePanel panel in flowLayoutPanel2.Controls.OfType<GunaElipsePanel>())
            {
                panel.Visible = false;
            }
            foreach (GunaElipsePanel panel in flowLayoutPanel1.Controls.OfType<GunaElipsePanel>())
            {
                panel.Visible = false;
            }
            db = new DatabaseManager();
            List<Event> eventsThisMonth = db.GetEventsThisMonth();
            List<Panel> panels = flowLayoutPanel2.Controls.OfType<Panel>().ToList();
            int i = 0;
            foreach (Event e in eventsThisMonth)
            {
                panels[i].Visible = true;
                panels[i].Controls.OfType<Label>().ToList()[0].Text = e.EventName;
                panels[i].Controls.OfType<Label>().ToList()[1].Text = e.EventDate.ToString("MMMM dd, yyyy");
            }
            events = db.GetAllEvents();
            i = 0;
            foreach (GunaElipsePanel panel in flowLayoutPanel1.Controls.OfType<GunaElipsePanel>())
            {
                
                if (i < events.Count)
                {
                    string formattedString = events[i].EventDate.ToString("MMMM dd, yyyy");
                    panel.Visible = true;
                    panel.Controls.OfType<Label>().ToList()[0].Text = ("Event ID: " + events[i].EventId.ToString());
                    panel.Controls.OfType<Label>().ToList()[1].Text = events[i].EventName.ToString();
                    panel.Controls.OfType<Label>().ToList()[2].Text = formattedString;
                    i++;
                }
                else if (i >= events.Count)
                {
                    break;
                }

            }
        }

        private void eventBut_Click(object sender, EventArgs e)
        {
            GunaAdvenceButton button = (GunaAdvenceButton)sender;
            GunaElipsePanel panel = (GunaElipsePanel)button.Parent;
            int id = 0;
            foreach(GunaElipsePanel panel1 in flowLayoutPanel1.Controls.OfType<GunaElipsePanel>())
            {
                if(panel1 == panel)
                    id = (panel.Controls.OfType<Label>().ToList()[0].Text.Last());
            }
            id -= 48;
            ViewEvent viewEvent = new ViewEvent(id);
            viewEvent.Owner = form;
            SetFormLocation(viewEvent);
            viewEvent.Show();
        }
        private void SetFormLocation(Form form)
        {
            form.StartPosition = FormStartPosition.Manual;
            int x = Screen.PrimaryScreen.Bounds.Width - form.Width - Convert.ToInt32(10 * 96 / 2.54);
            int y = ((Screen.PrimaryScreen.Bounds.Height - form.Height) / 2);
            form.Location = new Point(x, y);
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add1_Click(object sender, EventArgs e)
        {
            AddEvent addEvent = new AddEvent();
            addEvent.Owner = form;
            SetFormLocation(addEvent);
            addEvent.Show();
        }

        private void delBut_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.Owner = form;
            SetFormLocation(deleteForm);
            deleteForm.Show();
        }

        private void refreshBut_Click(object sender, EventArgs e)
        {
            SetUpEvents();
        }
    }
}
