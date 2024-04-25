using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Planner
{
    public class GuestList
    {

        public string Name { get; set; }


        public GuestList(string name)
        {
            Name = name;
        }

        public GuestList()
        {

        }
        public string Print()
        { 
            return "# " + Name + "\n";
        }
    }
}
