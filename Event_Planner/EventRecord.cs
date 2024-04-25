using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Planner
{
    public class EventRecord
    {
        public List<Guest> guest_Lists = new List<Guest>();
        public string Location { get; set; }
        public decimal budget { get; set; }
        public string name { get; set; }
        public DateTime Date { get; set; }

        public EventRecord()
        {

        }

        public EventRecord(string location, decimal budget, string name, DateTime Date)
        {
            this.Location = location;
            this.budget = budget;
            this.name = name;
            this.Date = Date;
        }
    }
}
