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
    public partial class loyalityprogram : UserControl
    {
        public loyalityprogram()
        {
            InitializeComponent();
            Controller obj = new Controller();
            dataGridView1.DataSource = obj.rankcustomers();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
