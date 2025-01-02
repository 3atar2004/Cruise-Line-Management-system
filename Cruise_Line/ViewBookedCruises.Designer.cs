namespace Cruise_Line
{
    partial class ViewBookedCruises
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
            this.GoBackButton = new System.Windows.Forms.Button();
            this.CabinIDs = new System.Windows.Forms.DataGridView();
            this.CruiseNameCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowCabinIDs = new System.Windows.Forms.CheckBox();
            this.Search = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CabinIDs)).BeginInit();
            this.SuspendLayout();
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(35, 35);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(84, 29);
            this.GoBackButton.TabIndex = 1;
            this.GoBackButton.Text = "Go Back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // CabinIDs
            // 
            this.CabinIDs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CabinIDs.Location = new System.Drawing.Point(107, 182);
            this.CabinIDs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CabinIDs.Name = "CabinIDs";
            this.CabinIDs.RowHeadersWidth = 51;
            this.CabinIDs.RowTemplate.Height = 24;
            this.CabinIDs.Size = new System.Drawing.Size(829, 351);
            this.CabinIDs.TabIndex = 2;
            // 
            // CruiseNameCombo
            // 
            this.CruiseNameCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CruiseNameCombo.FormattingEnabled = true;
            this.CruiseNameCombo.Location = new System.Drawing.Point(206, 108);
            this.CruiseNameCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CruiseNameCombo.Name = "CruiseNameCombo";
            this.CruiseNameCombo.Size = new System.Drawing.Size(136, 28);
            this.CruiseNameCombo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cruise Name";
            // 
            // ShowCabinIDs
            // 
            this.ShowCabinIDs.AutoSize = true;
            this.ShowCabinIDs.Location = new System.Drawing.Point(376, 110);
            this.ShowCabinIDs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowCabinIDs.Name = "ShowCabinIDs";
            this.ShowCabinIDs.Size = new System.Drawing.Size(149, 24);
            this.ShowCabinIDs.TabIndex = 5;
            this.ShowCabinIDs.Text = "Show Cabin IDs";
            this.ShowCabinIDs.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(554, 106);
            this.Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(84, 29);
            this.Search.TabIndex = 6;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.ForeColor = System.Drawing.Color.Red;
            this.Error.Location = new System.Drawing.Point(87, 148);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(51, 20);
            this.Error.TabIndex = 7;
            this.Error.Text = "label2";
            // 
            // ViewBookedCruises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 549);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.ShowCabinIDs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CruiseNameCombo);
            this.Controls.Add(this.CabinIDs);
            this.Controls.Add(this.GoBackButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewBookedCruises";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.CabinIDs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.DataGridView CabinIDs;
        private System.Windows.Forms.ComboBox CruiseNameCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ShowCabinIDs;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label Error;
    }
}