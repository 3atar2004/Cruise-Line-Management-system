namespace Cruise_Line
{
    partial class viewassigned
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
            this.scheduledcruises = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scheduledcruises)).BeginInit();
            this.SuspendLayout();
            // 
            // scheduledcruises
            // 
            this.scheduledcruises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduledcruises.Location = new System.Drawing.Point(55, 108);
            this.scheduledcruises.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scheduledcruises.Name = "scheduledcruises";
            this.scheduledcruises.RowHeadersWidth = 51;
            this.scheduledcruises.RowTemplate.Height = 24;
            this.scheduledcruises.Size = new System.Drawing.Size(676, 460);
            this.scheduledcruises.TabIndex = 0;
            this.scheduledcruises.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(65, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Assigned Cruises";
            // 
            // viewassigned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scheduledcruises);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "viewassigned";
            this.Size = new System.Drawing.Size(795, 612);
            ((System.ComponentModel.ISupportInitialize)(this.scheduledcruises)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView scheduledcruises;
        private System.Windows.Forms.Label label1;
    }
}
