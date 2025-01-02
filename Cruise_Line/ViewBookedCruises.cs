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
    public partial class ViewBookedCruises : Form
    {
        string username;
        Controller controlleroj = new Controller();
        
        public ViewBookedCruises(string username)
        {
            InitializeComponent();
            this.username = username;
            DataTable dt = new DataTable();
            dt = controlleroj.getCruise(username);
            CruiseNameCombo.DataSource = dt;
            CruiseNameCombo.DisplayMember = "Name";
            CruiseNameCombo.ValueMember = "CruiseID";
            Error.Visible = false;


        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            CustomerInterface customer = new CustomerInterface(username);
            customer.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (CruiseNameCombo.SelectedIndex == -1)
            {
                Error.Visible = true;
                Error.Text = "Please select a cruise";
                return;
            }

            Error.Visible = false; // Hide error if all is valid

            // Get the user ID
            int userID = controlleroj.GetUserIdByUsername(username);

            // Set the data source based on the checkbox
            if (ShowCabinIDs.Checked == false)
            {
                CabinIDs.DataSource = controlleroj.getBookedCruise(userID, (int)CruiseNameCombo.SelectedValue);
            }
            else
            {
                CabinIDs.DataSource = controlleroj.getBookedCabins(username, (int)CruiseNameCombo.SelectedValue);
            }

        }

    }
}
