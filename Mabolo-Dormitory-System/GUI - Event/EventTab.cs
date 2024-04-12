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
            this.db = new DatabaseManager();
            this.events = new List<Event>();
            InitializeComponent();

            // Add event handlers to the buttons
            foreach (GunaElipsePanel panel in flowLayoutPanel1.Controls.OfType<GunaElipsePanel>())
            {
                foreach (GunaAdvenceButton button in panel.Controls.OfType<GunaAdvenceButton>())
                {
                    button.Click += new EventHandler(eventBut_Click);
                }
            }
            foreach (GunaElipsePanel panel in flowLayoutPanel1.Controls.OfType<GunaElipsePanel>())
            {
                foreach (GunaImageButton button in panel.Controls.OfType<GunaImageButton>())
                {
                    button.Click += new EventHandler(editButton_Click);
                }
            }
            


            // Load information from the database
            SetUpEvents();  
        }

        private void SetUpEvents()
        {
            // Hide all panels
            foreach (GunaElipsePanel panel in flowLayoutPanel2.Controls.OfType<GunaElipsePanel>())
            {
                panel.Visible = false;
            }
            foreach (GunaElipsePanel panel in flowLayoutPanel1.Controls.OfType<GunaElipsePanel>())
            {
                panel.Visible = false;
            }

            // Load the events for this month
            db = new DatabaseManager();
            List<Event> eventsThisMonth = db.GetMonthlyEvent();
            List<Panel> panels = flowLayoutPanel2.Controls.OfType<Panel>().ToList();
            int i = 0;
            foreach (Event e in eventsThisMonth)
            {
                panels[i].Visible = true;
                panels[i].Controls.OfType<Label>().ToList()[0].Text = e.EventName;
                panels[i].Controls.OfType<Label>().ToList()[1].Text = e.EventDate.ToString("MMMM dd, yyyy");
                i++;
            }

            // Load all events
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
                    break;
            }
        }

        private void eventBut_Click(object sender, EventArgs e)
        {
            // Get the event id
            GunaAdvenceButton button = (GunaAdvenceButton)sender;
            GunaElipsePanel panel = (GunaElipsePanel)button.Parent;
            char id = 'a';
            foreach(GunaElipsePanel panel1 in flowLayoutPanel1.Controls.OfType<GunaElipsePanel>())
            {
                if(panel1 == panel)
                    id = (panel.Controls.OfType<Label>().ToList()[0].Text.Last());
            }
            int x = int.Parse(id.ToString());

            // Open the view event form
            ViewEvent viewEvent = new ViewEvent(form, x);
            viewEvent.Owner = form;
            SetFormLocation(viewEvent);
            viewEvent.Show();
        }
        
        private void SetFormLocation(Form form)
        {
            // Set the form location to the right side of the screen
            form.StartPosition = FormStartPosition.Manual;
            int x = Screen.PrimaryScreen.Bounds.Width - form.Width - Convert.ToInt32(10 * 96 / 2.54);
            int y = ((Screen.PrimaryScreen.Bounds.Height - form.Height) / 2);
            form.Location = new Point(x, y);
        }

        private void addEvent_Click(object sender, EventArgs e)
        {
            AddEvent addEvent = new AddEvent(this);
            addEvent.Owner = form;
            SetFormLocation(addEvent);
            addEvent.Show();
        }

        private void delBut_Click(object sender, EventArgs e)
        {
            if(events.Count == 0)
            {
                MessageBox.Show("There are no events to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            deleteEventButton deleteForm = new deleteEventButton(this);
            deleteForm.Owner = form;
            SetFormLocation(deleteForm);
            deleteForm.Show();
        }

        public void refreshBut_Click(object sender, EventArgs e)
        {
            searchBar.Text = "";
            SetUpEvents();
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
                MessageBox.Show("Please enter a valid Event name to search", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                searchBar.Text = "";
                return;
            }
            String eventName = searchBar.Text;
            events = db.GetAllEvents();
            List<Event> u2 = events.Select(u => u).ToList();
            events.Clear();
            foreach (Event ex in u2)
            {
                if (ex.EventName.Contains(eventName))
                {
                    events.Add(ex);
                }
            }
            if (events.Count == 0)
            {
                MessageBox.Show("No event with the Name '" + eventName + "'  was found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                SetUpEvents();
            }
            else
            {
                foreach (GunaElipsePanel panel in flowLayoutPanel1.Controls.OfType<GunaElipsePanel>())
                {
                    panel.Visible = false;
                }
                int i = 0;
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
                        break;
                }
            }   
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            GunaImageButton button = (GunaImageButton)sender;
            GunaElipsePanel panel = (GunaElipsePanel)button.Parent;
            char id = 'a';
            foreach (GunaElipsePanel panel1 in flowLayoutPanel1.Controls.OfType<GunaElipsePanel>())
            {
                if (panel1 == panel)
                    id = (panel.Controls.OfType<Label>().ToList()[0].Text.Last());
            }
            int x = int.Parse(id.ToString());
            EditEvent editEvent = new EditEvent(form, x);
            editEvent.Owner = form;
            SetFormLocation(editEvent);
            editEvent.Show();
        }

        private void searchBar_Enter(object sender, EventArgs e)
        {
            if (searchBar.Text == "Search...")
                searchBar.Text = "";
        }
    }
}
