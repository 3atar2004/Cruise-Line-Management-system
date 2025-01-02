using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cruise_Line
{
    public partial class AddActivity : UserControl
    {

        Controller controllerObj;
        DateTime startDate;
        DateTime endDate;
        public AddActivity()
        {
            controllerObj = new Controller();
            InitializeComponent();
            DataTable dt = controllerObj.getcruises();
            cruisesCombobox.DataSource = dt;
            cruisesCombobox.DisplayMember = "Name";
            cruisesCombobox.ValueMember = "CruiseID";
            startDate = controllerObj.getStartDate((int)cruisesCombobox.SelectedValue);
            endDate = controllerObj.getendDate((int)cruisesCombobox.SelectedValue);
            startlabel.Text = "Cruise Start Date: " + startDate.ToString("yyyy-MM-dd");
            endlabel.Text = "Cruise End Date: " + endDate.ToString("yyyy-MM-dd");
        }

        private void AddActivity_Load(object sender, EventArgs e)
        {

        }

        private void activityDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void activityDatagrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Clear previous error
            activityDatagrid.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = string.Empty;
            activityDatagrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.White;

            // Get column name
            string columnName = activityDatagrid.Columns[e.ColumnIndex].Name;
            string cellValue = e.FormattedValue.ToString();

            // Perform validation based on column
            switch (columnName)
            {
                case "ActivityName":
                    if (string.IsNullOrWhiteSpace(cellValue))
                    {
                        SetCellError(e, "Activity Name is required.");
                    }
                    break;
                case "ActivityDescription":
                    if (string.IsNullOrWhiteSpace(cellValue))
                    {
                        SetCellError(e, "Activity Description is required.");
                    }
                    break;

                case "ActivityCost":
                    if (!decimal.TryParse(cellValue, out decimal cost) || cost < 0)
                    {
                        SetCellError(e, "Activity Cost must be a positive number.");
                    }
                    break;

                case "ActivityCapacity":
                    if (!int.TryParse(cellValue, out int capacity) || capacity <= 0)
                    {
                        SetCellError(e, "Activity Capacity must be a positive integer.");
                    }
                    break;
                case "ActivityTime":
                    if (!TimeSpan.TryParse(cellValue, out TimeSpan activityTime))
                    {
                        SetCellError(e, "Activity Time is invalid. Use format HH:mm:ss.");
                    }
                    break;
                case "ActivityDate":
                    if (!DateTime.TryParse(cellValue, out DateTime activityDate))
                    {
                        SetCellError(e, "Activity Date is invalid.");
                    }
                    else if (activityDate < startDate || activityDate > endDate)
                    {
                        SetCellError(e, $"Activity Date must be between {startDate} and {endDate}.");
                    }
                    break;
            }
        }
        private void SetCellError(DataGridViewCellValidatingEventArgs e, string errorMessage)
        {

            activityDatagrid.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = errorMessage;

            activityDatagrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;

        }

        private void activityDatagrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Invalid value entered. Please correct it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cruisesCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            startDate = (DateTime)controllerObj.getStartDate((int)cruisesCombobox.SelectedValue);
            endDate = (DateTime)controllerObj.getendDate((int)cruisesCombobox.SelectedValue);
            startlabel.Text = "Cruise Start Date: " + startDate.ToString("yyyy-MM-dd");
            endlabel.Text = "Cruise End Date: " + endDate.ToString("yyyy-MM-dd");
        }
        private bool IsGridValid()
        {
            foreach (DataGridViewRow row in activityDatagrid.Rows)
            {
                if (row.IsNewRow) continue;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (!string.IsNullOrEmpty(cell.ErrorText))
                    {
                        // Invalid cell found
                        MessageBox.Show($"Please fix the errors in row {row.Index + 1} before proceeding.",
                                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }

            // No errors found
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsGridValid())
            {
                return; // Stop insertion if there are invalid cells
            }
            foreach (DataGridViewRow row in activityDatagrid.Rows)
            {
                if (row.IsNewRow) continue; // Skip the new row

                // Insert valid rows into Activity table
                string activityName = row.Cells["ActivityName"].Value.ToString();
                decimal activityCost = Convert.ToDecimal(row.Cells["ActivityCost"].Value);
                int activityCapacity = Convert.ToInt32(row.Cells["ActivityCapacity"].Value);
                DateTime activityDate = Convert.ToDateTime(row.Cells["ActivityDate"].Value);
                string activityDescription = row.Cells["ActivityDescription"].Value.ToString();
                TimeSpan time = TimeSpan.Parse(row.Cells["ActivityTime"].Value.ToString());
                int result = controllerObj.insertactivity((int)cruisesCombobox.SelectedValue, activityCapacity, activityName, activityCost, activityDate, activityDescription, time);
                if(result==0)
                {
                    MessageBox.Show("Activity is not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Activity is added successfully ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    activityDatagrid.Rows.Clear();
                    return;
                    
                }


            }
        }
    }
}
