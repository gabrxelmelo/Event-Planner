using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Planner
{
    public class guest_list
    {
        
        public string Name {  get; set; }
        

        public guest_list(string name) 
        {
            Name = name;
            


        }

        public guest_list()
        {

        }
        public string Print()
        {

            Name = "# " + Name + "\n";

            return Name;
        }
       

    }
}
