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
    public partial class viewassigned : UserControl
    {
        Controller obj;
        public viewassigned(string username)
        {
            InitializeComponent();
            obj = new Controller();
            scheduledcruises.DataSource = obj.getassigned(username);
            scheduledcruises.Refresh();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
