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

    public partial class AddCruise : UserControl
    {
        Controller controllerObj;
        int cruiseid;
        Panel content;
        public AddCruise(int CruiseNumber, Panel contentpanel)
        {
            controllerObj = new Controller();
            InitializeComponent();
            DataTable dt = controllerObj.getAvailableships(StartDatePicker.Value,EndDatePicker.Value);
            shipCombobox.DataSource = dt;
            shipCombobox.DisplayMember = "Name";
            shipCombobox.ValueMember = "ShipID";
            gobackbtn.Visible = false;
            cruiseid = CruiseNumber;
            content = contentpanel;

            if (CruiseNumber != -1)
            {
                DataTable dt1 = controllerObj.getcruisebyid(CruiseNumber);
                nametextbox.Text = dt1.Rows[0]["Name"].ToString();
                shipCombobox.Enabled = false;
                StartDatePicker.Value = (DateTime)dt1.Rows[0]["StartDate"];
                EndDatePicker.Value = (DateTime)dt1.Rows[0]["EndDate"];
                departureTextbox.Text = dt1.Rows[0]["Departure"].ToString();
                DestinationTextbox.Text = dt1.Rows[0]["Destination"].ToString();
                shipCombobox.SelectedValue = dt1.Rows[0]["ShipID"];
                desctextbox.Text = dt1.Rows[0]["Description"].ToString();
                InsertCruiseButton.Text = "Edit Cruise";
                gobackbtn.Visible = true;
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void InsertCruiseButton_Click(object sender, EventArgs e)
        {
            string description = desctextbox.Text.Trim();
            DateTime startDate = StartDatePicker.Value;
            DateTime endDate = EndDatePicker.Value;
            string departure = departureTextbox.Text.Trim();
            string destination = DestinationTextbox.Text.Trim();
            string CruiseName = nametextbox.Text.Trim();
            int shipId;


            if (string.IsNullOrEmpty(description) || string.IsNullOrEmpty(departure) ||
                string.IsNullOrEmpty(destination) || !int.TryParse(shipCombobox.SelectedValue.ToString(), out shipId) || string.IsNullOrEmpty(CruiseName))
            {
                MessageBox.Show("Please fill in all fields and select a valid ship.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (startDate >= endDate)
            {
                MessageBox.Show("Start Date must be earlier than End Date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(cruiseid>0)
            {
                int result = controllerObj.UpdateCruise(cruiseid, description, startDate, endDate, departure, destination, CruiseName);
                if (result == 0)
                {
                    MessageBox.Show("Cruise is not updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Cruise is Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    return;
                }
            }
            else
            {
                int result = controllerObj.InsertCruise(description, startDate, endDate, departure, destination, shipId, CruiseName);
                if (result == 0)
                {
                    MessageBox.Show("Cruise is not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Cruise is Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nametextbox.Clear();
                    desctextbox.Clear();
                    departureTextbox.Clear();
                    DestinationTextbox.Clear();
                    StartDatePicker.Value = DateTime.Now;
                    EndDatePicker.Value = DateTime.Now.AddDays(1);
                    shipCombobox.SelectedIndex = -1;
                    return;
                }
            }
            
        }

        private void nametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCruise_Load(object sender, EventArgs e)
        {

        }

        private void gobackbtn_Click(object sender, EventArgs e)
        {
            var viewcruisesControl = new ViewCruises(content);
            content.Controls.Clear();
            content.Controls.Add(viewcruisesControl);
        }

        private void shipCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.getAvailableships(StartDatePicker.Value, EndDatePicker.Value);
            shipCombobox.DataSource = dt;
            shipCombobox.DisplayMember = "Name";
            shipCombobox.ValueMember = "ShipID";
        }

        private void EndDatePicker_ValueChanged(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.getAvailableships(StartDatePicker.Value, EndDatePicker.Value);
            shipCombobox.DataSource = dt;
            shipCombobox.DisplayMember = "Name";
            shipCombobox.ValueMember = "ShipID";
        }
    }
}