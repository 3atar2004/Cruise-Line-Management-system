using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cruise_Line
{

    public partial class viewcabinsavailable : UserControl
    {
        Controller obj;
        Panel contentPanel;
        public viewcabinsavailable(string username, Panel contentpanel)
        {
            InitializeComponent();
            contentPanel = contentpanel;
            obj = new Controller();
            DataTable dt = obj.getworkingcruise(username);
            cruisescombobox.DataSource = dt;
            cruisescombobox.DisplayMember = "Name";
            cruisescombobox.ValueMember = "CruiseID";
        }

        private void getcabinsbtn_Click(object sender, EventArgs e)
        {
            availablecabinstable.DataSource = null;
            availablecabinstable.Rows.Clear();
            availablecabinstable.Columns.Clear();
            availablecabinstable.DataSource = obj.getOccupied((int)cruisescombobox.SelectedValue,firstnameTextbox.Text,lastnameTextbox.Text);
            availablecabinstable.Refresh();
            DataGridViewButtonColumn reassignButtonColumn = new DataGridViewButtonColumn
            {
                Name = "reassignButton",
                HeaderText = "",
                Text = "Reassign",
                UseColumnTextForButtonValue = true
            };


            availablecabinstable.Columns.Insert(availablecabinstable.ColumnCount, reassignButtonColumn);
        }

        private void cruisescombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void availablecabinstable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == availablecabinstable.Columns["reassignButton"].Index && e.RowIndex >= 0)
            {
                this.Hide();
                int cruiseID = (int)cruisescombobox.SelectedValue;
                var ReassignControl = new ReassignCabin(contentPanel, cruiseID, availablecabinstable.Rows[e.RowIndex].Cells["Full Name"].Value.ToString(), (int)availablecabinstable.Rows[e.RowIndex].Cells["Cabin Number"].Value, (int)availablecabinstable.Rows[e.RowIndex].Cells["Ship ID"].Value, (int)availablecabinstable.Rows[e.RowIndex].Cells["Booking ID"].Value, (int)availablecabinstable.Rows[e.RowIndex].Cells["Cabin Type"].Value, this);
                //contentPanel.Controls.Clear();
                contentPanel.Controls.Add(ReassignControl);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            availablecabinstable.DataSource = null;
            availablecabinstable.Rows.Clear();
            availablecabinstable.Columns.Clear();
            availablecabinstable.DataSource = obj.getOccupied((int)cruisescombobox.SelectedValue, firstnameTextbox.Text, lastnameTextbox.Text);
            availablecabinstable.Refresh();
            DataGridViewButtonColumn reassignButtonColumn = new DataGridViewButtonColumn
            {
                Name = "reassignButton",
                HeaderText = "",
                Text = "Reassign",
                UseColumnTextForButtonValue = true
            };


            availablecabinstable.Columns.Insert(availablecabinstable.ColumnCount, reassignButtonColumn);
       
        }
    }
}
