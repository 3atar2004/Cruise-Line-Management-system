namespace Cruise_Line
{
    partial class ManagerInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reportspanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.statisticsbtn = new System.Windows.Forms.Button();
            this.AddManagerButton = new System.Windows.Forms.Button();
            this.AddShipButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.managerlabel = new System.Windows.Forms.Label();
            this.ViewReportsButton = new System.Windows.Forms.Button();
            this.addActivitiesButton = new System.Windows.Forms.Button();
            this.assignStaffButton = new System.Windows.Forms.Button();
            this.AddStaffButton = new System.Windows.Forms.Button();
            this.ViewCruiseButton = new System.Windows.Forms.Button();
            this.addCruiseButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.reportspanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.sidebarPanel.Controls.Add(this.label1);
            this.sidebarPanel.Controls.Add(this.pictureBox2);
            this.sidebarPanel.Controls.Add(this.pictureBox1);
            this.sidebarPanel.Controls.Add(this.reportspanel);
            this.sidebarPanel.Controls.Add(this.AddManagerButton);
            this.sidebarPanel.Controls.Add(this.AddShipButton);
            this.sidebarPanel.Controls.Add(this.panel1);
            this.sidebarPanel.Controls.Add(this.managerlabel);
            this.sidebarPanel.Controls.Add(this.ViewReportsButton);
            this.sidebarPanel.Controls.Add(this.addActivitiesButton);
            this.sidebarPanel.Controls.Add(this.assignStaffButton);
            this.sidebarPanel.Controls.Add(this.AddStaffButton);
            this.sidebarPanel.Controls.Add(this.ViewCruiseButton);
            this.sidebarPanel.Controls.Add(this.addCruiseButton);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(195, 711);
            this.sidebarPanel.TabIndex = 0;
            this.sidebarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebarPanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Hello, ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Cruise_Line.Properties.Resources.logout;
            this.pictureBox2.Location = new System.Drawing.Point(148, 664);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cruise_Line.Properties.Resources.profile_user;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // reportspanel
            // 
            this.reportspanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.reportspanel.Controls.Add(this.button1);
            this.reportspanel.Controls.Add(this.button4);
            this.reportspanel.Controls.Add(this.button3);
            this.reportspanel.Controls.Add(this.statisticsbtn);
            this.reportspanel.Location = new System.Drawing.Point(24, 492);
            this.reportspanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reportspanel.Name = "reportspanel";
            this.reportspanel.Size = new System.Drawing.Size(148, 179);
            this.reportspanel.TabIndex = 10;
            this.reportspanel.Paint += new System.Windows.Forms.PaintEventHandler(this.reportspanel_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 128);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cabin Utilization";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 90);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 35);
            this.button4.TabIndex = 2;
            this.button4.Text = "Loyality Program";
            this.button4.UseMnemonic = false;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 50);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 32);
            this.button3.TabIndex = 1;
            this.button3.Text = "Cruises Report";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // statisticsbtn
            // 
            this.statisticsbtn.Location = new System.Drawing.Point(7, 9);
            this.statisticsbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statisticsbtn.Name = "statisticsbtn";
            this.statisticsbtn.Size = new System.Drawing.Size(140, 35);
            this.statisticsbtn.TabIndex = 0;
            this.statisticsbtn.Text = "View Statistics";
            this.statisticsbtn.UseVisualStyleBackColor = true;
            this.statisticsbtn.Click += new System.EventHandler(this.statisticsbtn_Click);
            // 
            // AddManagerButton
            // 
            this.AddManagerButton.Location = new System.Drawing.Point(22, 305);
            this.AddManagerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddManagerButton.Name = "AddManagerButton";
            this.AddManagerButton.Size = new System.Drawing.Size(146, 41);
            this.AddManagerButton.TabIndex = 0;
            this.AddManagerButton.Text = "Add Manager";
            this.AddManagerButton.UseVisualStyleBackColor = true;
            this.AddManagerButton.Click += new System.EventHandler(this.AddManagerButton_Click);
            // 
            // AddShipButton
            // 
            this.AddShipButton.Location = new System.Drawing.Point(21, 398);
            this.AddShipButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddShipButton.Name = "AddShipButton";
            this.AddShipButton.Size = new System.Drawing.Size(147, 38);
            this.AddShipButton.TabIndex = 9;
            this.AddShipButton.Text = "Add Ships";
            this.AddShipButton.UseVisualStyleBackColor = true;
            this.AddShipButton.Click += new System.EventHandler(this.AddShipButton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(195, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 50);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // managerlabel
            // 
            this.managerlabel.AutoSize = true;
            this.managerlabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerlabel.Location = new System.Drawing.Point(65, 38);
            this.managerlabel.Name = "managerlabel";
            this.managerlabel.Size = new System.Drawing.Size(70, 27);
            this.managerlabel.TabIndex = 8;
            this.managerlabel.Text = "label1";
            this.managerlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.managerlabel.Click += new System.EventHandler(this.managerlabel_Click);
            // 
            // ViewReportsButton
            // 
            this.ViewReportsButton.Location = new System.Drawing.Point(24, 442);
            this.ViewReportsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ViewReportsButton.Name = "ViewReportsButton";
            this.ViewReportsButton.Size = new System.Drawing.Size(146, 42);
            this.ViewReportsButton.TabIndex = 7;
            this.ViewReportsButton.Text = "View Reports";
            this.ViewReportsButton.UseVisualStyleBackColor = true;
            this.ViewReportsButton.Click += new System.EventHandler(this.ViewReportsButton_Click_1);
            // 
            // addActivitiesButton
            // 
            this.addActivitiesButton.Location = new System.Drawing.Point(22, 352);
            this.addActivitiesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addActivitiesButton.Name = "addActivitiesButton";
            this.addActivitiesButton.Size = new System.Drawing.Size(146, 39);
            this.addActivitiesButton.TabIndex = 6;
            this.addActivitiesButton.Text = "Add Activiites";
            this.addActivitiesButton.UseVisualStyleBackColor = true;
            this.addActivitiesButton.Click += new System.EventHandler(this.addActivitiesButton_Click_1);
            // 
            // assignStaffButton
            // 
            this.assignStaffButton.Location = new System.Drawing.Point(24, 259);
            this.assignStaffButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.assignStaffButton.Name = "assignStaffButton";
            this.assignStaffButton.Size = new System.Drawing.Size(146, 39);
            this.assignStaffButton.TabIndex = 5;
            this.assignStaffButton.Text = "Assign Staff";
            this.assignStaffButton.UseVisualStyleBackColor = true;
            this.assignStaffButton.Click += new System.EventHandler(this.assignStaffButton_Click_1);
            // 
            // AddStaffButton
            // 
            this.AddStaffButton.Location = new System.Drawing.Point(24, 210);
            this.AddStaffButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddStaffButton.Name = "AddStaffButton";
            this.AddStaffButton.Size = new System.Drawing.Size(146, 41);
            this.AddStaffButton.TabIndex = 4;
            this.AddStaffButton.Text = "Add Staff";
            this.AddStaffButton.UseVisualStyleBackColor = true;
            this.AddStaffButton.Click += new System.EventHandler(this.AddStaffButton_Click_1);
            // 
            // ViewCruiseButton
            // 
            this.ViewCruiseButton.Location = new System.Drawing.Point(22, 161);
            this.ViewCruiseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ViewCruiseButton.Name = "ViewCruiseButton";
            this.ViewCruiseButton.Size = new System.Drawing.Size(146, 41);
            this.ViewCruiseButton.TabIndex = 3;
            this.ViewCruiseButton.Text = "View Cruise";
            this.ViewCruiseButton.UseVisualStyleBackColor = true;
            this.ViewCruiseButton.Click += new System.EventHandler(this.ViewCruiseButton_Click_1);
            // 
            // addCruiseButton
            // 
            this.addCruiseButton.Location = new System.Drawing.Point(21, 110);
            this.addCruiseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addCruiseButton.Name = "addCruiseButton";
            this.addCruiseButton.Size = new System.Drawing.Size(146, 42);
            this.addCruiseButton.TabIndex = 1;
            this.addCruiseButton.Text = "Add Cruise";
            this.addCruiseButton.UseVisualStyleBackColor = true;
            this.addCruiseButton.Click += new System.EventHandler(this.addCruiseButton_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(195, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(82, 711);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Cruise_Line.Properties.Resources.menu;
            this.pictureBox3.Location = new System.Drawing.Point(7, 8);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(195, 0);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1021, 711);
            this.contentPanel.TabIndex = 1;
            this.contentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.contentPanel_Paint);
            // 
            // ManagerInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 711);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManagerInterface";
            this.Text = "ManagerInterface";
            this.sidebarPanel.ResumeLayout(false);
            this.sidebarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.reportspanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Button ViewReportsButton;
        private System.Windows.Forms.Button addActivitiesButton;
        private System.Windows.Forms.Button assignStaffButton;
        private System.Windows.Forms.Button AddStaffButton;
        private System.Windows.Forms.Button ViewCruiseButton;
        private System.Windows.Forms.Button addCruiseButton;
        private System.Windows.Forms.Label managerlabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddShipButton;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Button AddManagerButton;
        private System.Windows.Forms.Panel reportspanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button statisticsbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}