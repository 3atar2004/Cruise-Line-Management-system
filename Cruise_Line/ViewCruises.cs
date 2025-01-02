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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cruise_Line
{
    public partial class ViewCruises : UserControl
    {
        Controller controllerobj;
        Panel contentPanel;
        public ViewCruises(Panel contentPanel)
        {
            
            InitializeComponent();
            this.contentPanel = contentPanel;
            CruisesGrid.Visible = false;
            controllerobj = new Controller();

            DataTable dt = controllerobj.getDeparture();
            DataRow emptyRow = dt.NewRow();
            emptyRow["Departure"] = "None";
            dt.Rows.InsertAt(emptyRow, 0);
            DepatureComboBox.DataSource = dt;
            DepatureComboBox.DisplayMember = "Departure";
            DepatureComboBox.ValueMember = "Departure";
            DepatureComboBox.SelectedIndex = 0;

            DataTable dtDest = controllerobj.getDestination();
            DataRow emptyRow2 = dtDest.NewRow();
            emptyRow2["Destination"] = "None";
            dtDest.Rows.InsertAt(emptyRow2, 0);
            ArrivalComboBox.DataSource = dtDest;
            ArrivalComboBox.DisplayMember = "Destination";
            ArrivalComboBox.ValueMember = "Destination";
            ArrivalComboBox.SelectedIndex = 0;
            CruisesGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;




            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
            {
                Name = "EditButton",
                HeaderText = "",
                Text = "Edit",
                UseColumnTextForButtonValue = true
            };


            CruisesGrid.Columns.Insert(0, editButtonColumn);

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "DeleteButton",
                HeaderText = "",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };


            CruisesGrid.Columns.Insert(0, deleteButtonColumn);



        }

        private void CruisesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == CruisesGrid.Columns["editButton"].Index && e.RowIndex >= 0)
            {

                int cruiseID = (int)CruisesGrid.Rows[e.RowIndex].Cells["Cruise Number"].Value;
                var addCruiseControl = new AddCruise(cruiseID,contentPanel);
                contentPanel.Controls.Clear();
                contentPanel.Controls.Add(addCruiseControl);
            }
            else if (e.ColumnIndex == CruisesGrid.Columns["deleteButton"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete {CruisesGrid.Rows[e.RowIndex].Cells["Cruise Name"].Value.ToString()}?",
                "Confirm Action",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );


                if (result == DialogResult.No)
                {

                    return;
                }
                else
                {
                    int cruiseID = (int)CruisesGrid.Rows[e.RowIndex].Cells["Cruise Number"].Value;
                    int result2 = controllerobj.deleteCruise(cruiseID);
                    if (result2 == 0)
                    {
                        MessageBox.Show("Cruise is not deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Cruise is deleted", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return;
                    }
                }
                
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            int Price;
            int.TryParse(MaxPriceTextBox.Text, out Price);
            dt = controllerobj.SearchCruises(DepatureComboBox.SelectedValue.ToString(), ArrivalComboBox.SelectedValue.ToString(), Price.ToString());
            //dt = controllerobj.getCruises();
            CruisesGrid.DataSource = dt;
            if (CruisesGrid.Columns["Ship ID"] != null)
            {
                CruisesGrid.Columns["Ship ID"].Visible = false;
            }
            CruisesGrid.Visible = true;
        }
    }
}
