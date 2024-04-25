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

        public List<GuestList> guest = new List<GuestList>();
        public List<EventRecord> events= new List<EventRecord>();
        public AddNewEventForm(List<EventRecord> List)
        {
            events= List;
            InitializeComponent();
        }

        
        private void addCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void addPpl_Click(object sender, EventArgs e)
        {
            GuestList guestlist = new GuestList();
            GuestListForm guestList = new GuestListForm(guestlist);
            DialogResult selectedButton = guestList.ShowDialog();
            if (selectedButton == DialogResult.OK)
            {
                guest.Clear();
                guest.Add(guestlist);
                guest.ForEach(g => textBox1.Text += g.Print() + "\n") ;

            }
           
        }
        private GuestList list = null;
        public GuestList GetNew()
        {
            this.ShowDialog();
            return list;
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
    }
}
