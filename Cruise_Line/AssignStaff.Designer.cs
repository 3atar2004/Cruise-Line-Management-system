namespace Cruise_Line
{
    partial class AssignStaff
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CruiseCombobox = new System.Windows.Forms.ComboBox();
            this.RoleCombobox = new System.Windows.Forms.ComboBox();
            this.AvailableDatagrid = new System.Windows.Forms.DataGridView();
            this.AssignedDatagrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableDatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssignedDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cruise:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Role:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Available Staff";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Assigned Staff";
            // 
            // CruiseCombobox
            // 
            this.CruiseCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CruiseCombobox.FormattingEnabled = true;
            this.CruiseCombobox.Location = new System.Drawing.Point(204, 41);
            this.CruiseCombobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CruiseCombobox.Name = "CruiseCombobox";
            this.CruiseCombobox.Size = new System.Drawing.Size(121, 28);
            this.CruiseCombobox.TabIndex = 4;
            this.CruiseCombobox.SelectedIndexChanged += new System.EventHandler(this.CruiseCombobox_SelectedIndexChanged);
            // 
            // RoleCombobox
            // 
            this.RoleCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleCombobox.FormattingEnabled = true;
            this.RoleCombobox.Location = new System.Drawing.Point(204, 90);
            this.RoleCombobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RoleCombobox.Name = "RoleCombobox";
            this.RoleCombobox.Size = new System.Drawing.Size(121, 28);
            this.RoleCombobox.TabIndex = 5;
            this.RoleCombobox.SelectedIndexChanged += new System.EventHandler(this.RoleCombobox_SelectedIndexChanged);
            // 
            // AvailableDatagrid
            // 
            this.AvailableDatagrid.AllowDrop = true;
            this.AvailableDatagrid.AllowUserToAddRows = false;
            this.AvailableDatagrid.AllowUserToDeleteRows = false;
            this.AvailableDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvailableDatagrid.Location = new System.Drawing.Point(119, 211);
            this.AvailableDatagrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AvailableDatagrid.Name = "AvailableDatagrid";
            this.AvailableDatagrid.RowHeadersWidth = 62;
            this.AvailableDatagrid.RowTemplate.Height = 28;
            this.AvailableDatagrid.Size = new System.Drawing.Size(378, 368);
            this.AvailableDatagrid.TabIndex = 6;
            this.AvailableDatagrid.DragDrop += new System.Windows.Forms.DragEventHandler(this.AvailableDatagrid_DragDrop);
            this.AvailableDatagrid.DragOver += new System.Windows.Forms.DragEventHandler(this.AvailableDatagrid_DragOver);
            this.AvailableDatagrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AvailableDatagrid_MouseDown);
            // 
            // AssignedDatagrid
            // 
            this.AssignedDatagrid.AllowDrop = true;
            this.AssignedDatagrid.AllowUserToAddRows = false;
            this.AssignedDatagrid.AllowUserToDeleteRows = false;
            this.AssignedDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssignedDatagrid.Location = new System.Drawing.Point(623, 211);
            this.AssignedDatagrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AssignedDatagrid.Name = "AssignedDatagrid";
            this.AssignedDatagrid.RowHeadersWidth = 62;
            this.AssignedDatagrid.RowTemplate.Height = 28;
            this.AssignedDatagrid.Size = new System.Drawing.Size(356, 368);
            this.AssignedDatagrid.TabIndex = 7;
            this.AssignedDatagrid.DragDrop += new System.Windows.Forms.DragEventHandler(this.AssignedDatagrid_DragDrop);
            this.AssignedDatagrid.DragOver += new System.Windows.Forms.DragEventHandler(this.AssignedDatagrid_DragOver);
            this.AssignedDatagrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AssignedDatagrid_MouseDown);
            // 
            // AssignStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AssignedDatagrid);
            this.Controls.Add(this.AvailableDatagrid);
            this.Controls.Add(this.RoleCombobox);
            this.Controls.Add(this.CruiseCombobox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AssignStaff";
            this.Size = new System.Drawing.Size(999, 678);
            ((System.ComponentModel.ISupportInitialize)(this.AvailableDatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssignedDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CruiseCombobox;
        private System.Windows.Forms.ComboBox RoleCombobox;
        private System.Windows.Forms.DataGridView AvailableDatagrid;
        private System.Windows.Forms.DataGridView AssignedDatagrid;
    }
}
