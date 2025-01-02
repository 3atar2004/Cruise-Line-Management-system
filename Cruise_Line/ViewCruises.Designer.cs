namespace Cruise_Line
{
    partial class ViewCruises
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
            this.CruisesGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DepatureComboBox = new System.Windows.Forms.ComboBox();
            this.ArrivalComboBox = new System.Windows.Forms.ComboBox();
            this.MaxPriceTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CruisesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CruisesGrid
            // 
            this.CruisesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CruisesGrid.Location = new System.Drawing.Point(98, 153);
            this.CruisesGrid.Name = "CruisesGrid";
            this.CruisesGrid.RowHeadersWidth = 62;
            this.CruisesGrid.RowTemplate.Height = 28;
            this.CruisesGrid.Size = new System.Drawing.Size(856, 408);
            this.CruisesGrid.TabIndex = 0;
            this.CruisesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CruisesGrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Destination";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max price per night";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Departure:";
            // 
            // DepatureComboBox
            // 
            this.DepatureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepatureComboBox.FormattingEnabled = true;
            this.DepatureComboBox.Location = new System.Drawing.Point(211, 44);
            this.DepatureComboBox.Name = "DepatureComboBox";
            this.DepatureComboBox.Size = new System.Drawing.Size(121, 28);
            this.DepatureComboBox.TabIndex = 4;
            // 
            // ArrivalComboBox
            // 
            this.ArrivalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ArrivalComboBox.FormattingEnabled = true;
            this.ArrivalComboBox.Location = new System.Drawing.Point(472, 44);
            this.ArrivalComboBox.Name = "ArrivalComboBox";
            this.ArrivalComboBox.Size = new System.Drawing.Size(121, 28);
            this.ArrivalComboBox.TabIndex = 5;
            // 
            // MaxPriceTextBox
            // 
            this.MaxPriceTextBox.Location = new System.Drawing.Point(290, 95);
            this.MaxPriceTextBox.Name = "MaxPriceTextBox";
            this.MaxPriceTextBox.Size = new System.Drawing.Size(100, 26);
            this.MaxPriceTextBox.TabIndex = 6;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(734, 60);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(167, 37);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ViewCruises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.MaxPriceTextBox);
            this.Controls.Add(this.ArrivalComboBox);
            this.Controls.Add(this.DepatureComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CruisesGrid);
            this.Name = "ViewCruises";
            this.Size = new System.Drawing.Size(1042, 617);
            ((System.ComponentModel.ISupportInitialize)(this.CruisesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CruisesGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DepatureComboBox;
        private System.Windows.Forms.ComboBox ArrivalComboBox;
        private System.Windows.Forms.TextBox MaxPriceTextBox;
        private System.Windows.Forms.Button SearchButton;
    }
}
