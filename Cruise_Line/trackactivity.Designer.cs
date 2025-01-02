namespace Cruise_Line
{
    partial class trackactivity
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
            this.label2 = new System.Windows.Forms.Label();
            this.cruisescombobox = new System.Windows.Forms.ComboBox();
            this.activitycombobox = new System.Windows.Forms.ComboBox();
            this.activitytable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.activitytable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Cruise";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Activity";
            // 
            // cruisescombobox
            // 
            this.cruisescombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cruisescombobox.FormattingEnabled = true;
            this.cruisescombobox.Location = new System.Drawing.Point(258, 95);
            this.cruisescombobox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cruisescombobox.Name = "cruisescombobox";
            this.cruisescombobox.Size = new System.Drawing.Size(232, 28);
            this.cruisescombobox.TabIndex = 2;
            this.cruisescombobox.SelectedIndexChanged += new System.EventHandler(this.cruisescombobox_SelectedIndexChanged);
            // 
            // activitycombobox
            // 
            this.activitycombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activitycombobox.FormattingEnabled = true;
            this.activitycombobox.Location = new System.Drawing.Point(258, 144);
            this.activitycombobox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.activitycombobox.Name = "activitycombobox";
            this.activitycombobox.Size = new System.Drawing.Size(232, 28);
            this.activitycombobox.TabIndex = 3;
            this.activitycombobox.SelectedIndexChanged += new System.EventHandler(this.activitycombobox_SelectedIndexChanged);
            // 
            // activitytable
            // 
            this.activitytable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activitytable.Location = new System.Drawing.Point(112, 212);
            this.activitytable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.activitytable.Name = "activitytable";
            this.activitytable.RowHeadersWidth = 51;
            this.activitytable.RowTemplate.Height = 24;
            this.activitytable.Size = new System.Drawing.Size(721, 420);
            this.activitytable.TabIndex = 4;
            this.activitytable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // trackactivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.activitytable);
            this.Controls.Add(this.activitycombobox);
            this.Controls.Add(this.cruisescombobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "trackactivity";
            this.Size = new System.Drawing.Size(936, 734);
            this.Load += new System.EventHandler(this.trackactivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activitytable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cruisescombobox;
        private System.Windows.Forms.ComboBox activitycombobox;
        private System.Windows.Forms.DataGridView activitytable;
    }
}
