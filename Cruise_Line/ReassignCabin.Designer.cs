namespace Cruise_Line
{
    partial class ReassignCabin
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
            this.emptyCabinsGrid = new System.Windows.Forms.DataGridView();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.cabinIdLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.cabinsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.emptyCabinsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // emptyCabinsGrid
            // 
            this.emptyCabinsGrid.AllowUserToAddRows = false;
            this.emptyCabinsGrid.AllowUserToDeleteRows = false;
            this.emptyCabinsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emptyCabinsGrid.Location = new System.Drawing.Point(101, 96);
            this.emptyCabinsGrid.Name = "emptyCabinsGrid";
            this.emptyCabinsGrid.ReadOnly = true;
            this.emptyCabinsGrid.RowHeadersWidth = 62;
            this.emptyCabinsGrid.RowTemplate.Height = 28;
            this.emptyCabinsGrid.Size = new System.Drawing.Size(775, 476);
            this.emptyCabinsGrid.TabIndex = 0;
            this.emptyCabinsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.emptyCabinsGrid_CellContentClick);
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Location = new System.Drawing.Point(121, 44);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(84, 20);
            this.fullnameLabel.TabIndex = 1;
            this.fullnameLabel.Text = "Full Name:";
            // 
            // cabinIdLabel
            // 
            this.cabinIdLabel.AutoSize = true;
            this.cabinIdLabel.Location = new System.Drawing.Point(521, 44);
            this.cabinIdLabel.Name = "cabinIdLabel";
            this.cabinIdLabel.Size = new System.Drawing.Size(114, 20);
            this.cabinIdLabel.TabIndex = 2;
            this.cabinIdLabel.Text = "Cabin Number:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(779, 35);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(135, 38);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // cabinsLabel
            // 
            this.cabinsLabel.AutoSize = true;
            this.cabinsLabel.ForeColor = System.Drawing.Color.Red;
            this.cabinsLabel.Location = new System.Drawing.Point(121, 73);
            this.cabinsLabel.Name = "cabinsLabel";
            this.cabinsLabel.Size = new System.Drawing.Size(51, 20);
            this.cabinsLabel.TabIndex = 4;
            this.cabinsLabel.Text = "label1";
            // 
            // ReassignCabin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cabinsLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.cabinIdLabel);
            this.Controls.Add(this.fullnameLabel);
            this.Controls.Add(this.emptyCabinsGrid);
            this.Name = "ReassignCabin";
            this.Size = new System.Drawing.Size(1002, 614);
            this.Load += new System.EventHandler(this.ReassignCabin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emptyCabinsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView emptyCabinsGrid;
        private System.Windows.Forms.Label fullnameLabel;
        private System.Windows.Forms.Label cabinIdLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label cabinsLabel;
    }
}
