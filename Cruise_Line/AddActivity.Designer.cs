namespace Cruise_Line
{
    partial class AddActivity
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cruisesCombobox = new System.Windows.Forms.ComboBox();
            this.activityDatagrid = new System.Windows.Forms.DataGridView();
            this.ActivityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivityDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivityTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivityCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivityCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivityDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.startlabel = new System.Windows.Forms.Label();
            this.endlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.activityDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Cruise";
            // 
            // cruisesCombobox
            // 
            this.cruisesCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cruisesCombobox.FormattingEnabled = true;
            this.cruisesCombobox.Location = new System.Drawing.Point(324, 74);
            this.cruisesCombobox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cruisesCombobox.Name = "cruisesCombobox";
            this.cruisesCombobox.Size = new System.Drawing.Size(242, 28);
            this.cruisesCombobox.TabIndex = 1;
            this.cruisesCombobox.SelectedIndexChanged += new System.EventHandler(this.cruisesCombobox_SelectedIndexChanged);
            // 
            // activityDatagrid
            // 
            this.activityDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activityDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ActivityName,
            this.ActivityDate,
            this.ActivityTime,
            this.ActivityCost,
            this.ActivityCapacity,
            this.ActivityDescription});
            this.activityDatagrid.Location = new System.Drawing.Point(164, 130);
            this.activityDatagrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.activityDatagrid.Name = "activityDatagrid";
            this.activityDatagrid.RowHeadersWidth = 51;
            this.activityDatagrid.RowTemplate.Height = 24;
            this.activityDatagrid.Size = new System.Drawing.Size(641, 362);
            this.activityDatagrid.TabIndex = 2;
            this.activityDatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.activityDatagrid_CellContentClick);
            this.activityDatagrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.activityDatagrid_CellValidating);
            this.activityDatagrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.activityDatagrid_DataError);
            // 
            // ActivityName
            // 
            this.ActivityName.HeaderText = "Name";
            this.ActivityName.MinimumWidth = 6;
            this.ActivityName.Name = "ActivityName";
            this.ActivityName.Width = 125;
            // 
            // ActivityDate
            // 
            this.ActivityDate.HeaderText = "Date";
            this.ActivityDate.MinimumWidth = 6;
            this.ActivityDate.Name = "ActivityDate";
            this.ActivityDate.Width = 125;
            // 
            // ActivityTime
            // 
            this.ActivityTime.HeaderText = "Time";
            this.ActivityTime.MinimumWidth = 6;
            this.ActivityTime.Name = "ActivityTime";
            this.ActivityTime.Width = 125;
            // 
            // ActivityCost
            // 
            this.ActivityCost.HeaderText = "Cost";
            this.ActivityCost.MinimumWidth = 6;
            this.ActivityCost.Name = "ActivityCost";
            this.ActivityCost.Width = 125;
            // 
            // ActivityCapacity
            // 
            this.ActivityCapacity.HeaderText = "Capacity";
            this.ActivityCapacity.MinimumWidth = 6;
            this.ActivityCapacity.Name = "ActivityCapacity";
            this.ActivityCapacity.Width = 125;
            // 
            // ActivityDescription
            // 
            this.ActivityDescription.HeaderText = "Description";
            this.ActivityDescription.MinimumWidth = 6;
            this.ActivityDescription.Name = "ActivityDescription";
            this.ActivityDescription.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 54);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Activity";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // startlabel
            // 
            this.startlabel.AutoSize = true;
            this.startlabel.Location = new System.Drawing.Point(227, 518);
            this.startlabel.Name = "startlabel";
            this.startlabel.Size = new System.Drawing.Size(87, 20);
            this.startlabel.TabIndex = 4;
            this.startlabel.Text = "Start Date:";
            // 
            // endlabel
            // 
            this.endlabel.AutoSize = true;
            this.endlabel.Location = new System.Drawing.Point(515, 518);
            this.endlabel.Name = "endlabel";
            this.endlabel.Size = new System.Drawing.Size(81, 20);
            this.endlabel.TabIndex = 5;
            this.endlabel.Text = "End Date:";
            // 
            // AddActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.endlabel);
            this.Controls.Add(this.startlabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.activityDatagrid);
            this.Controls.Add(this.cruisesCombobox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddActivity";
            this.Size = new System.Drawing.Size(842, 568);
            this.Load += new System.EventHandler(this.AddActivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activityDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cruisesCombobox;
        private System.Windows.Forms.DataGridView activityDatagrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityDescription;
        private System.Windows.Forms.Label startlabel;
        private System.Windows.Forms.Label endlabel;
    }
}
