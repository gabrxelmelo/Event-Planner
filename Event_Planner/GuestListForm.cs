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
    public partial class GuestListForm : Form
    {

        Guest guestList;
        public GuestListForm(Guest guestList)
        {
            this.guestList = guestList;
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
            guestList.Name = name;

            this.DialogResult = DialogResult.OK;
            this.Close();


        }
    }
}
