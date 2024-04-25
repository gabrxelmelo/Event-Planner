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
    public partial class GuestList : Form
    {

        guest_list list;
        public GuestList(guest_list g)
        {
            this.list = g;
            InitializeComponent();
        }

        private void cancelBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBut_Click(object sender, EventArgs e)
        {
            string name; 

            name = fnameText.Text + " " + lnameText.Text + "\n";
            list.Name = name;

            this.DialogResult = DialogResult.OK;
            this.Close();


        }
    }
}
