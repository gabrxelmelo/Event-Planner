using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Planner
{
    public partial class AddNewEventForm : Form
    {

        public List<Guest> guests = new List<Guest>();
        public List<EventRecord> events= new List<EventRecord>();
        public AddNewEventForm(List<EventRecord> events)
        {
            this.events= events;
            InitializeComponent();
        }

        
        private void addCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void addPpl_Click(object sender, EventArgs e)
        {
            Guest guest = new Guest();
            GuestListForm guestListForm = new GuestListForm(guest);
            DialogResult selectedButton = guestListForm.ShowDialog();
            if (selectedButton == DialogResult.OK)
            {
                this.guests.Add(guest);
               DisplayGuests();

            }

        }

        private void DisplayGuests()
        {
            //this.guestsListBox.Items.Clear();
            guestsListBox.DataSource= new BindingList<Guest>(this.guests);
            guestsListBox.DisplayMember= "Name";
        }

        private Guest newGuest = null;
        public Guest GetNew()
        {
            this.ShowDialog();
            return newGuest;
        }

        private void addSave_Click(object sender, EventArgs e)
        {
            EventRecord eventRecord = new EventRecord();

            eventRecord.Location = locText.Text;
            eventRecord.budget = budNum.Value;
            eventRecord.name = hostText.Text;
            eventRecord.Date = dateTimePicker1.Value;

            events.Add(eventRecord);
            
            this.Close();
        }

        private void delPpl_Click(object sender, EventArgs e)
        {
            int selectedIndex = guestsListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                guests.RemoveAt(selectedIndex);
                this.DisplayGuests();
            }
        }
    }
}
