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
    public partial class EventPlannerForm : Form
    {
        public EventRecord EventRecord { get; set; }

        List<EventRecord> events = new List<EventRecord>();
        public EventPlannerForm()
        {
            InitializeComponent();
            LoadEvent();
            DisplayEvent();
        }
        private EventRecord selectedProduct;
        private void DisplayEvent()
        {
            upcomingDataGridView.Columns.Clear();
            upcomingDataGridView.DataSource = new BindingList<EventRecord>(this.events.ToList());

            
            // add column for delete button
            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
            upcomingDataGridView.Columns.Add(deleteColumn);

            // format the column header
            //dgvProducts.EnableHeadersVisualStyles = false;
            //dgvProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            upcomingDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            upcomingDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            // format the first column
            upcomingDataGridView.Columns[0].HeaderText = "Location";
            upcomingDataGridView.Columns[0].Width = 110;

            // format the second column
            upcomingDataGridView.Columns[3].HeaderText = "Date";
            upcomingDataGridView.Columns[3].Width = 90;


            // format the third column
            upcomingDataGridView.Columns[2].HeaderText = "Name";
            upcomingDataGridView.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            upcomingDataGridView.Columns[2].Width = 90;
            upcomingDataGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // format the forth column
            upcomingDataGridView.Columns[1].HeaderText = "Budget";
            upcomingDataGridView.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            upcomingDataGridView.Columns[1].Width = 90;
            upcomingDataGridView.Columns[1].DefaultCellStyle.Format = "c";
            upcomingDataGridView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        public void LoadEvent()
        {
            string location, name;
            decimal budget;
            DateTime date;

            


            EventRecord A1 = new EventRecord("cashel", 1000, "party", new DateTime(2020, 12, 21));
            this.events.Add(A1);

        }
        private void addBut_Click(object sender, EventArgs e)
        {
            AddNewEventForm addNewEventForm = new AddNewEventForm(events);

            DialogResult dialogResult = addNewEventForm.ShowDialog();
            {
                DisplayEvent();

            }
           
            
        }

        private void closeBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void Upcoming_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // store index values for Modify and Delete button column
            
            
            const int deleteColumIndex = 0;

            if (e.ColumnIndex == deleteColumIndex)
            {
                string location = upcomingDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                selectedProduct = GetEvent(location);
            }

            
            if (e.ColumnIndex == deleteColumIndex)
            {
                DeleteProduct();
            }

        
        }
        private EventRecord GetEvent(string location)
        {
            foreach (EventRecord e in events)
            {
                if (e.Location.Equals(location)) return e;
            }
            return null;

        }
        private void DeleteProduct()
        {
            DialogResult result =
                MessageBox.Show($"Delete {selectedProduct.Location.Trim()}?",
                "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {

                    if (events.Remove(selectedProduct))
                    {
                        DisplayEvent();
                    }

                }
                catch(Exception ex)
                {

                    HandleGeneralError(ex);
                
                }


            }
        }
        private void HandleGeneralError(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.GetType().ToString());
        }

        private void deleteBut_Click(object sender, EventArgs e)
        {

        }
    }
}
