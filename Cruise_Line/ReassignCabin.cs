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
    public partial class ReassignCabin : UserControl
    {
        Panel contentPanel;
        Controller obj;
        UserControl View;
        int CabinID;
        int ShipID;
        int BookingID;
        public ReassignCabin(Panel content, int cruiseID, string fullname, int cabinID, int shipID, int bookingID,int type, UserControl view)
        {
            InitializeComponent();
            obj = new Controller();
            View = view;
            CabinID = cabinID;
            ShipID = shipID;
            BookingID = bookingID;
            DataTable dt = obj.getavailablecabins(cruiseID,type);
            emptyCabinsGrid.DataSource = dt;
            fullnameLabel.Text = $"Full Name: {fullname}";
            cabinIdLabel.Text = $"Cabin Number: {cabinID}";
            cabinsLabel.Visible = false;

            if (dt == null)
            {
                cabinsLabel.Text = "No cabins available";
                cabinsLabel.Visible = true;
            }
            DataGridViewButtonColumn assignButtonColumn = new DataGridViewButtonColumn
            {
                Name = "assignButton",
                HeaderText = "",
                Text = "Reassign",
                UseColumnTextForButtonValue = true
            };


            emptyCabinsGrid.Columns.Insert(emptyCabinsGrid.ColumnCount, assignButtonColumn);
        }

        private void ReassignCabin_Load(object sender, EventArgs e)
        {

        }

        private void emptyCabinsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == emptyCabinsGrid.Columns["assignButton"].Index && e.RowIndex >= 0)
            {

                int result = obj.updateAssignedCabin((int)emptyCabinsGrid.Rows[e.RowIndex].Cells["CabinID"].Value,CabinID,ShipID,BookingID);
                if (result == 0)
                {
                    MessageBox.Show("Couldn't reassign cabin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Cabin reassigned Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    View.Show();
                    return;
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            View.Show();
        }
    }
}
