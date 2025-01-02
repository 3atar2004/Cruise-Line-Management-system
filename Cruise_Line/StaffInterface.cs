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
    public partial class StaffInterface : Form
    {
        string username;
        public StaffInterface(string user)
        {
            InitializeComponent();
            Controller obj = new Controller();
            string fname = obj.getfirstname(user);
            username = user;
            stafflabel.Text = fname;
            sidebarPanel.Visible = true;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
          

        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            
        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewassignedbtn_Click(object sender, EventArgs e)
        {
            var viewschedule = new viewassigned(username);
            viewschedule.Dock = DockStyle.Fill;
            contentpanel.Controls.Clear();
            contentpanel.Controls.Add(viewschedule);
        }

        private void viewcabinsbtn_Click(object sender, EventArgs e)
        {
            var viewcabins = new viewcabinsavailable(username,contentpanel);
            viewcabins.Dock = DockStyle.Fill;
            contentpanel.Controls.Clear();
            contentpanel.Controls.Add(viewcabins);
        }

        private void trackactivitybtn_Click(object sender, EventArgs e)
        {
            var trackactivity = new trackactivity(username);
            trackactivity.Dock = DockStyle.Fill;
            contentpanel.Controls.Clear();
            contentpanel.Controls.Add(trackactivity);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (sidebarPanel.Visible)
            {
                sidebarPanel.Visible = false;
            }
            else
            {
                sidebarPanel.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var staffinfo = new info(username);
            staffinfo.Dock = DockStyle.Fill;
            contentpanel.Controls.Clear();
            contentpanel.Controls.Add(staffinfo);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
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
                this.Close();
            }
        }

        private void sidebarPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
