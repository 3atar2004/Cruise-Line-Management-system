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
    public partial class trackactivity : UserControl
    {
        Controller obj;
        string username;
        public trackactivity(string user)
        {
            InitializeComponent();
            obj = new Controller();
            username = user;
            DataTable dt = obj.getworkingcruise(username);
            cruisescombobox.DataSource = dt;
            cruisescombobox.DisplayMember = "Name";
            cruisescombobox.ValueMember = "CruiseID";

            if (dt != null)
            {
                DataRow emptyRow = dt.NewRow();
                emptyRow["Name"] = "";
                dt.Rows.InsertAt(emptyRow, 0);
                cruisescombobox.SelectedIndex = 0;
            }

            DataTable d2 = obj.getactivitiesoncruise((int)cruisescombobox.SelectedValue);
            activitycombobox.DataSource = d2;
            activitycombobox.DisplayMember = "Name";
            activitycombobox.ValueMember = "Activity ID";

            if (d2 != null)
            {
                DataRow emptyRow2 = d2.NewRow();
                emptyRow2["Name"] = "";
                d2.Rows.InsertAt(emptyRow2, 0);
                activitycombobox.SelectedIndex = 0;
            }

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void trackactivity_Load(object sender, EventArgs e)
        {

        }

        private void activitycombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable d4 = obj.getactivityreservations((int)activitycombobox.SelectedValue);
            activitytable.DataSource = d4;
        }

        private void cruisescombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DataTable d3 = obj.getactivitiesoncruise((int)cruisescombobox.SelectedValue);
            activitycombobox.DataSource = d3;
            activitycombobox.DisplayMember = "Name";
            activitycombobox.ValueMember = "Activity ID";

        }
    }
}
