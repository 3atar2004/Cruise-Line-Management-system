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
    public partial class Cabinutilization : UserControl
    {
        public Cabinutilization()
        {
            InitializeComponent();
            Controller obj = new Controller();
            DataTable dt1 = obj.getnumberofbooked();
            DataTable dt2 = obj.getallcabins();
            if (dt1.Columns.Count > 0)
            {
                DataColumn newColumn = new DataColumn("Number of Booked Cabins", dt1.Columns[0].DataType);
                dt2.Columns.Add(newColumn);

                // Populate the new column with data from dt2
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    if (i < dt1.Rows.Count)
                    {
                        dt2.Rows[i]["Number of Booked Cabins"] = dt1.Rows[i][0];
                    }
                    else
                    {
                        dt2.Rows[i]["Number of Booked Cabins"] = 0; // Fill with null if dt2 has fewer rows
                    }
                }
            }
            dataGridView1.DataSource = dt2;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cabinutilization_Load(object sender, EventArgs e)
        {

        }
    }
}
