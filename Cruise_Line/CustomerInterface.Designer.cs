namespace Cruise_Line
{
    partial class CustomerInterface
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
            this.ViewUserInfoButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.BookingGridView = new System.Windows.Forms.DataGridView();
            this.DepatureComboBox = new System.Windows.Forms.ComboBox();
            this.ArrivalComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MaxPriceTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ViewBookedCruises = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BookingGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewUserInfoButton
            // 
            this.ViewUserInfoButton.Location = new System.Drawing.Point(1058, 61);
            this.ViewUserInfoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ViewUserInfoButton.Name = "ViewUserInfoButton";
            this.ViewUserInfoButton.Size = new System.Drawing.Size(198, 42);
            this.ViewUserInfoButton.TabIndex = 0;
            this.ViewUserInfoButton.Text = "View Customer Info";
            this.ViewUserInfoButton.UseVisualStyleBackColor = true;
            this.ViewUserInfoButton.Click += new System.EventHandler(this.ViewUserInfoButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.ForeColor = System.Drawing.Color.Red;
            this.LogoutButton.Location = new System.Drawing.Point(1058, 110);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(198, 42);
            this.LogoutButton.TabIndex = 1;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // BookingGridView
            // 
            this.BookingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookingGridView.Location = new System.Drawing.Point(52, 248);
            this.BookingGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BookingGridView.Name = "BookingGridView";
            this.BookingGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.BookingGridView.RowTemplate.Height = 24;
            this.BookingGridView.Size = new System.Drawing.Size(1237, 312);
            this.BookingGridView.TabIndex = 2;
            // 
            // DepatureComboBox
            // 
            this.DepatureComboBox.FormattingEnabled = true;
            this.DepatureComboBox.Location = new System.Drawing.Point(257, 118);
            this.DepatureComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DepatureComboBox.Name = "DepatureComboBox";
            this.DepatureComboBox.Size = new System.Drawing.Size(136, 28);
            this.DepatureComboBox.TabIndex = 3;
            // 
            // ArrivalComboBox
            // 
            this.ArrivalComboBox.FormattingEnabled = true;
            this.ArrivalComboBox.Location = new System.Drawing.Point(605, 118);
            this.ArrivalComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ArrivalComboBox.Name = "ArrivalComboBox";
            this.ArrivalComboBox.Size = new System.Drawing.Size(136, 28);
            this.ArrivalComboBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Desired Departure ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Desired Destination";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Maximum Price Per Night";
            // 
            // MaxPriceTextBox
            // 
            this.MaxPriceTextBox.Location = new System.Drawing.Point(272, 194);
            this.MaxPriceTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaxPriceTextBox.Name = "MaxPriceTextBox";
            this.MaxPriceTextBox.Size = new System.Drawing.Size(112, 26);
            this.MaxPriceTextBox.TabIndex = 13;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(813, 117);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(84, 29);
            this.SearchButton.TabIndex = 14;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1037, 191);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 48);
            this.button1.TabIndex = 15;
            this.button1.Text = "View Activities";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewBookedCruises
            // 
            this.ViewBookedCruises.Location = new System.Drawing.Point(224, 601);
            this.ViewBookedCruises.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewBookedCruises.Name = "ViewBookedCruises";
            this.ViewBookedCruises.Size = new System.Drawing.Size(182, 55);
            this.ViewBookedCruises.TabIndex = 15;
            this.ViewBookedCruises.Text = "View Booked Cruises";
            this.ViewBookedCruises.UseVisualStyleBackColor = true;
            this.ViewBookedCruises.Click += new System.EventHandler(this.ViewBookedCruises_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(642, 601);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 55);
            this.button2.TabIndex = 16;
            this.button2.Text = "View Payments";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1069, 601);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 55);
            this.button3.TabIndex = 17;
            this.button3.Text = "View Activities";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CustomerInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 688);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ViewBookedCruises);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.MaxPriceTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArrivalComboBox);
            this.Controls.Add(this.DepatureComboBox);
            this.Controls.Add(this.BookingGridView);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.ViewUserInfoButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomerInterface";
            this.Text = "CustomerInterface";
            ((System.ComponentModel.ISupportInitialize)(this.BookingGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ViewUserInfoButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.DataGridView BookingGridView;
        private System.Windows.Forms.ComboBox DepatureComboBox;
        private System.Windows.Forms.ComboBox ArrivalComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox MaxPriceTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ViewBookedCruises;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}