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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Cruise_Line
{
    public partial class AssignStaff : UserControl
    {
        Controller controllerObj;
        DateTime startDate;
        DateTime endDate;
        public AssignStaff()
        {

            controllerObj = new Controller();
            InitializeComponent();
            DataTable dt = controllerObj.getcruises();
            CruiseCombobox.DataSource = dt;
            CruiseCombobox.DisplayMember = "Name";
            CruiseCombobox.ValueMember = "CruiseID";
            startDate = controllerObj.getStartDate((int)CruiseCombobox.SelectedValue);
            endDate = controllerObj.getendDate((int)CruiseCombobox.SelectedValue);

            DataTable dt2 = controllerObj.getAllRoles();
            dt2.Rows.Add("All");
            RoleCombobox.DataSource = dt2;
            RoleCombobox.DisplayMember = "Job";
            RoleCombobox.ValueMember = "Job";
            RoleCombobox.SelectedIndex = RoleCombobox.Items.Count - 1;

            DataTable d3 = controllerObj.getAvailableStaff(startDate, endDate, RoleCombobox.SelectedValue.ToString());
            AvailableDatagrid.DataSource = d3;

            DataTable d4 = controllerObj.getAssignedStaff((int)CruiseCombobox.SelectedValue);
            AssignedDatagrid.DataSource = d4;
        }

        private void AvailableDatagrid_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void AssignedDatagrid_DragOver(object sender, DragEventArgs e)

        {
                e.Effect = DragDropEffects.Move;
        }

        private void AvailableDatagrid_MouseDown(object sender, MouseEventArgs e)
        {
            if (AvailableDatagrid.SelectedRows.Count > 0)
            {
                AvailableDatagrid.DoDragDrop(AvailableDatagrid.SelectedRows[0], DragDropEffects.Move);
            }
        }

        private void AssignedDatagrid_MouseDown(object sender, MouseEventArgs e)
        {
            if (AssignedDatagrid.SelectedRows.Count > 0)
            {
                AssignedDatagrid.DoDragDrop(AssignedDatagrid.SelectedRows[0], DragDropEffects.Move);
            }
        }

        private void AvailableDatagrid_DragDrop(object sender, DragEventArgs e)
        {
            //hat check law ba drop fy nafs el grid
            //var targetDgv = sender as DataGridView;

            //if (AssignedDatagrid == targetDgv)
            //{
             //   return;
            //}

            if (e.Data.GetData(typeof(DataGridViewRow)) is DataGridViewRow draggedRow)
            {
                // Get the DataTable bound to dgvAssignedStaff
                DataTable assignedTable = (DataTable)AssignedDatagrid.DataSource;

                // Get the DataTable bound to dgvAvailableStaff
                DataTable availableTable = (DataTable)AvailableDatagrid.DataSource;

                // lazem yeb2a fy datasource mawgod el awal 3ashan ye3raf ye drop feh
                if (availableTable == null)
                {
                    //person.personID, CONCAT(person.FName, ' ', person.LName) AS FullName, Staff.Job, person.Gender, person.Phone, person.Address 
                    availableTable = new DataTable();
                    availableTable.Columns.Add("personID", typeof(int));
                    availableTable.Columns.Add("FullName", typeof(string));
                    availableTable.Columns.Add("Job", typeof(string));
                    availableTable.Columns.Add("Gender", typeof(string));
                    availableTable.Columns.Add("Phone", typeof(string));
                    availableTable.Columns.Add("Address", typeof(string));
                    AvailableDatagrid.DataSource = availableTable;
                }

                int result = controllerObj.removeWorks_On((int)CruiseCombobox.SelectedValue, (int)draggedRow.Cells["personID"].Value);
                
                // Add in the availableTable 
                DataRow newRow = availableTable.NewRow();
                foreach (DataColumn column in assignedTable.Columns)
                {
                    newRow[column.ColumnName] = draggedRow.Cells[column.ColumnName].Value;
                }
                availableTable.Rows.Add(newRow);

                // Remove from the assignedTable
                DataRow[] rowsToRemove = assignedTable.Select($"personID = {draggedRow.Cells["personID"].Value}");
                foreach (DataRow row in rowsToRemove)
                {
                    assignedTable.Rows.Remove(row);
                }
                AvailableDatagrid.Refresh();
                AssignedDatagrid.Refresh();

                if (result == 0)
                {
                    MessageBox.Show("Staff was not removed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Staff removed successfully ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void AssignedDatagrid_DragDrop(object sender, DragEventArgs e)
        {

            if (e.Data.GetData(typeof(DataGridViewRow)) is DataGridViewRow draggedRow)
            {
                DataTable availableTable = (DataTable)AvailableDatagrid.DataSource;
                DataTable assignedTable = (DataTable)AssignedDatagrid.DataSource;

                // lazem yeb2a fy datasource mawgod el awal 3ashan ye3raf ye drop feh
                if (assignedTable == null)
                {
                    //person.personID, CONCAT(person.FName, ' ', person.LName) AS FullName, Staff.Job, person.Gender, person.Phone, person.Address 
                    assignedTable = new DataTable();
                    assignedTable.Columns.Add("personID", typeof(int));
                    assignedTable.Columns.Add("FullName", typeof(string));
                    assignedTable.Columns.Add("Job", typeof(string));
                    assignedTable.Columns.Add("Gender", typeof(string));
                    assignedTable.Columns.Add("Phone", typeof(string));
                    assignedTable.Columns.Add("Address", typeof(string));
                    AssignedDatagrid.DataSource = assignedTable;
                }

                int result = controllerObj.addWorks_On((int)CruiseCombobox.SelectedValue, (int)draggedRow.Cells["personID"].Value);
                //MessageBox.Show("Staff was not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

                // Create a new row in the assignedTable and copy the data
                DataRow newRow = assignedTable.NewRow();
                foreach (DataColumn column in availableTable.Columns)
                {
                    newRow[column.ColumnName] = draggedRow.Cells[column.ColumnName].Value;
                }
                assignedTable.Rows.Add(newRow);
                AssignedDatagrid.Refresh();

                // Remove the row from the availableTable
                DataRow[] rowsToRemove = availableTable.Select($"personID = {draggedRow.Cells["personID"].Value}");
                foreach (DataRow row in rowsToRemove)
                {
                    availableTable.Rows.Remove(row);
                }
                AvailableDatagrid.Refresh();

                if (result == 0)
                {
                    MessageBox.Show("Staff was not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Staff added successfully ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void CruiseCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            startDate = controllerObj.getStartDate((int)CruiseCombobox.SelectedValue);
            endDate = controllerObj.getendDate((int)CruiseCombobox.SelectedValue);
            DataTable d3 = controllerObj.getAvailableStaff(startDate, endDate, RoleCombobox.SelectedValue.ToString());
            AvailableDatagrid.DataSource = d3;
            DataTable d4 = controllerObj.getAssignedStaff((int)CruiseCombobox.SelectedValue);
            AssignedDatagrid.DataSource = d4;

        }

        private void RoleCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            startDate = controllerObj.getStartDate((int)CruiseCombobox.SelectedValue);
            endDate = controllerObj.getendDate((int)CruiseCombobox.SelectedValue);
            DataTable d3 = controllerObj.getAvailableStaff(startDate, endDate, RoleCombobox.SelectedValue.ToString());
            AvailableDatagrid.DataSource = d3;
            DataTable d4 = controllerObj.getAssignedStaff((int)CruiseCombobox.SelectedValue);
            AssignedDatagrid.DataSource = d4;
        }
    }
}
