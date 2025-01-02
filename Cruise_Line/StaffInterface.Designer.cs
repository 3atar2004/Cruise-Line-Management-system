namespace Cruise_Line
{
    partial class StaffInterface
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.viewassignedbtn = new System.Windows.Forms.Button();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.trackactivitybtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.viewcabinsbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stafflabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.contentpanel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(183, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(79, 670);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Cruise_Line.Properties.Resources.menu;
            this.pictureBox3.Location = new System.Drawing.Point(3, 6);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // viewassignedbtn
            // 
            this.viewassignedbtn.Location = new System.Drawing.Point(14, 195);
            this.viewassignedbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewassignedbtn.Name = "viewassignedbtn";
            this.viewassignedbtn.Size = new System.Drawing.Size(146, 54);
            this.viewassignedbtn.TabIndex = 1;
            this.viewassignedbtn.Text = "View Assigned";
            this.viewassignedbtn.UseVisualStyleBackColor = true;
            this.viewassignedbtn.Click += new System.EventHandler(this.viewassignedbtn_Click);
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.sidebarPanel.Controls.Add(this.trackactivitybtn);
            this.sidebarPanel.Controls.Add(this.label1);
            this.sidebarPanel.Controls.Add(this.viewcabinsbtn);
            this.sidebarPanel.Controls.Add(this.pictureBox1);
            this.sidebarPanel.Controls.Add(this.stafflabel);
            this.sidebarPanel.Controls.Add(this.pictureBox2);
            this.sidebarPanel.Controls.Add(this.viewassignedbtn);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(183, 670);
            this.sidebarPanel.TabIndex = 3;
            this.sidebarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebarPanel_Paint);
            // 
            // trackactivitybtn
            // 
            this.trackactivitybtn.Location = new System.Drawing.Point(14, 486);
            this.trackactivitybtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackactivitybtn.Name = "trackactivitybtn";
            this.trackactivitybtn.Size = new System.Drawing.Size(146, 54);
            this.trackactivitybtn.TabIndex = 10;
            this.trackactivitybtn.Text = "Track Activity";
            this.trackactivitybtn.UseVisualStyleBackColor = true;
            this.trackactivitybtn.Click += new System.EventHandler(this.trackactivitybtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Hello, ";
            // 
            // viewcabinsbtn
            // 
            this.viewcabinsbtn.Location = new System.Drawing.Point(14, 336);
            this.viewcabinsbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewcabinsbtn.Name = "viewcabinsbtn";
            this.viewcabinsbtn.Size = new System.Drawing.Size(146, 54);
            this.viewcabinsbtn.TabIndex = 9;
            this.viewcabinsbtn.Text = "View Cabins";
            this.viewcabinsbtn.UseVisualStyleBackColor = true;
            this.viewcabinsbtn.Click += new System.EventHandler(this.viewcabinsbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cruise_Line.Properties.Resources.profile_user;
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // stafflabel
            // 
            this.stafflabel.AutoSize = true;
            this.stafflabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stafflabel.Location = new System.Drawing.Point(75, 44);
            this.stafflabel.Name = "stafflabel";
            this.stafflabel.Size = new System.Drawing.Size(70, 27);
            this.stafflabel.TabIndex = 16;
            this.stafflabel.Text = "label1";
            this.stafflabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Cruise_Line.Properties.Resources.logout;
            this.pictureBox2.Location = new System.Drawing.Point(134, 616);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // contentpanel
            // 
            this.contentpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentpanel.Location = new System.Drawing.Point(262, 0);
            this.contentpanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contentpanel.Name = "contentpanel";
            this.contentpanel.Size = new System.Drawing.Size(1109, 670);
            this.contentpanel.TabIndex = 6;
            // 
            // StaffInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 670);
            this.Controls.Add(this.contentpanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sidebarPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StaffInterface";
            this.Text = "Form2";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.sidebarPanel.ResumeLayout(false);
            this.sidebarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button viewassignedbtn;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel contentpanel;
        private System.Windows.Forms.Button viewcabinsbtn;
        private System.Windows.Forms.Button trackactivitybtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label stafflabel;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}