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
    public partial class AddNewEvent : Form
    {
        EventRecord addEvent = new EventRecord();

        public List<guest_list> guest = new List<guest_list>();
        public List<EventRecord> events= new List<EventRecord>();
        public AddNewEvent(List<EventRecord> List)
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
            guest_list guestlist = new guest_list();
            GuestList guestList = new GuestList(guestlist);
            DialogResult selectedButton = guestList.ShowDialog();
            if (selectedButton == DialogResult.OK)
            {
                guest.Clear();
                guest.Add(guestlist);
                guest.ForEach(g => textBox1.Text += g.Print() + "\n") ;

            }
           
        }
        private guest_list list = null;
        public guest_list GetNew()
        {
            this.ShowDialog();
            return list;
        }

        private void addSave_Click(object sender, EventArgs e)
        {

            addEvent.Location = locText.Text;
            addEvent.budget = budNum.Value;
            addEvent.name = hostText.Text;
            addEvent.Date = dateTimePicker1.Value;
            
            this.Close();
        }
    }
}
