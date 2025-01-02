namespace Cruise_Line
{
    partial class viewcabinsavailable
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
            this.cruisescombobox = new System.Windows.Forms.ComboBox();
            this.availablecabinstable = new System.Windows.Forms.DataGridView();
            this.getcabinsbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firstnameTextbox = new System.Windows.Forms.TextBox();
            this.lastnameTextbox = new System.Windows.Forms.TextBox();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.availablecabinstable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Cruise";
            // 
            // cruisescombobox
            // 
            this.cruisescombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cruisescombobox.FormattingEnabled = true;
            this.cruisescombobox.Location = new System.Drawing.Point(196, 61);
            this.cruisescombobox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cruisescombobox.Name = "cruisescombobox";
            this.cruisescombobox.Size = new System.Drawing.Size(136, 28);
            this.cruisescombobox.TabIndex = 1;
            this.cruisescombobox.SelectedIndexChanged += new System.EventHandler(this.cruisescombobox_SelectedIndexChanged);
            // 
            // availablecabinstable
            // 
            this.availablecabinstable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availablecabinstable.Location = new System.Drawing.Point(75, 181);
            this.availablecabinstable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.availablecabinstable.Name = "availablecabinstable";
            this.availablecabinstable.RowHeadersWidth = 51;
            this.availablecabinstable.RowTemplate.Height = 24;
            this.availablecabinstable.Size = new System.Drawing.Size(918, 475);
            this.availablecabinstable.TabIndex = 2;
            this.availablecabinstable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.availablecabinstable_CellContentClick);
            // 
            // getcabinsbtn
            // 
            this.getcabinsbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.getcabinsbtn.Location = new System.Drawing.Point(710, 32);
            this.getcabinsbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.getcabinsbtn.Name = "getcabinsbtn";
            this.getcabinsbtn.Size = new System.Drawing.Size(155, 57);
            this.getcabinsbtn.TabIndex = 3;
            this.getcabinsbtn.Text = "Search Cabins";
            this.getcabinsbtn.UseVisualStyleBackColor = false;
            this.getcabinsbtn.Click += new System.EventHandler(this.getcabinsbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name:";
            // 
            // firstnameTextbox
            // 
            this.firstnameTextbox.Location = new System.Drawing.Point(196, 105);
            this.firstnameTextbox.Name = "firstnameTextbox";
            this.firstnameTextbox.Size = new System.Drawing.Size(136, 26);
            this.firstnameTextbox.TabIndex = 6;
            // 
            // lastnameTextbox
            // 
            this.lastnameTextbox.Location = new System.Drawing.Point(196, 143);
            this.lastnameTextbox.Name = "lastnameTextbox";
            this.lastnameTextbox.Size = new System.Drawing.Size(136, 26);
            this.lastnameTextbox.TabIndex = 7;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(732, 107);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(117, 36);
            this.refreshButton.TabIndex = 8;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // viewcabinsavailable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.lastnameTextbox);
            this.Controls.Add(this.firstnameTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.getcabinsbtn);
            this.Controls.Add(this.availablecabinstable);
            this.Controls.Add(this.cruisescombobox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "viewcabinsavailable";
            this.Size = new System.Drawing.Size(1056, 703);
            ((System.ComponentModel.ISupportInitialize)(this.availablecabinstable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cruisescombobox;
        private System.Windows.Forms.DataGridView availablecabinstable;
        private System.Windows.Forms.Button getcabinsbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstnameTextbox;
        private System.Windows.Forms.TextBox lastnameTextbox;
        private System.Windows.Forms.Button refreshButton;
    }
}
