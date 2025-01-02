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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cruise_Line
{
    public partial class ManagerInterface : Form
    {
        string username1;
        public ManagerInterface(string username)
        {
            InitializeComponent();
            Controller obj = new Controller();
            string fname = obj.getfirstname(username);

            username1 = username;
            managerlabel.Text = fname;
            sidebarPanel.Visible = true;
            reportspanel.Visible = false;
        }
        private void addCruiseButton_Click_1(object sender, EventArgs e)
        {
            var addCruiseControl = new AddCruise(-1,contentPanel);
            addCruiseControl.Dock = DockStyle.Fill;
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(addCruiseControl);
        }

        private void ViewCruiseButton_Click_1(object sender, EventArgs e)
        {
            var viewCruiseControl = new ViewCruises(contentPanel);
            viewCruiseControl.Dock = DockStyle.Fill;
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(viewCruiseControl);
        }

        private void ViewReportsButton_Click_1(object sender, EventArgs e)
        {
            //var viewReportsControl = new ViewCruises(); //neb2a ne8yarha enaha tefta7 list of reports w dol yefta7o el report
            //viewReportsControl.Dock = DockStyle.Fill;
            //contentPanel.Controls.Clear();
            //contentPanel.Controls.Add(viewReportsControl);
            if(reportspanel.Visible)
            {
                reportspanel.Visible = false;
            }
            else
            {
                reportspanel.Visible = true;
            }
        }

        private void AddStaffButton_Click_1(object sender, EventArgs e)
        {
            var addStaffControl = new AddStaff("S");
            addStaffControl.Dock = DockStyle.Fill;
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(addStaffControl);
        }

        private void addActivitiesButton_Click_1(object sender, EventArgs e)
        {
            var addActivityControl = new AddActivity();
            addActivityControl.Dock = DockStyle.Fill;
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(addActivityControl);
        }

        private void assignStaffButton_Click_1(object sender, EventArgs e)
        {
            var assignStaffControl = new AssignStaff();
            assignStaffControl.Dock = DockStyle.Fill;
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(assignStaffControl);
        }

        private void Menubtn_Click(object sender, EventArgs e)
        {
            if(sidebarPanel.Visible)
            {
                sidebarPanel.Visible = false;
            }
            else
            {
                sidebarPanel.Visible = true;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void AddShipButton_Click(object sender, EventArgs e)
        {
            var addshipsControl = new AddShip();
            addshipsControl.Dock = DockStyle.Fill;
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(addshipsControl);
        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidebarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void managerlabel_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddManagerButton_Click(object sender, EventArgs e)
        {
            var addManagerControl = new AddStaff("M");
            addManagerControl.Dock = DockStyle.Fill;
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(addManagerControl);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var assignStaffControl = new info(username1);
            assignStaffControl.Dock = DockStyle.Fill;
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(assignStaffControl);
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (sidebarPanel.Visible)
            {
                sidebarPanel.Visible = false;
                pictureBox3.Visible = true;
            }
            else
            {
                sidebarPanel.Visible = true;
            }
        }

        private void statisticsbtn_Click(object sender, EventArgs e)
        {
            var showstatistics = new showstatistics();
            showstatistics.Dock = DockStyle.Fill;
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(showstatistics);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var cruisesreport = new cruisesreport();
            cruisesreport.Dock = DockStyle.Fill;
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(cruisesreport);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var cabinutilization = new Cabinutilization();
            cabinutilization.Dock = DockStyle.Fill;
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(cabinutilization);
        }

        private void reportspanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var loyalityprogram = new loyalityprogram();
            loyalityprogram.Dock = DockStyle.Fill;
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(loyalityprogram);
        }
    }
}
