namespace Cruise_Line
{
    partial class BookingForm
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
            this.CabinChoiceComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberOfCabins = new System.Windows.Forms.NumericUpDown();
            this.AddCabinsButton = new System.Windows.Forms.Button();
            this.NumberError = new System.Windows.Forms.Label();
            this.TobeBookedDataGrid = new System.Windows.Forms.DataGridView();
            this.GoToCheckout = new System.Windows.Forms.Button();
            this.SelectionError = new System.Windows.Forms.Label();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.PricePerNightLabel = new System.Windows.Forms.Label();
            this.InvoiceLabel = new System.Windows.Forms.Label();
            this.TermsLabel = new System.Windows.Forms.Label();
            this.PayButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NewDiscountedPrice = new System.Windows.Forms.Label();
            this.PayLater = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfCabins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TobeBookedDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CabinChoiceComboBox
            // 
            this.CabinChoiceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CabinChoiceComboBox.FormattingEnabled = true;
            this.CabinChoiceComboBox.Location = new System.Drawing.Point(206, 204);
            this.CabinChoiceComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CabinChoiceComboBox.Name = "CabinChoiceComboBox";
            this.CabinChoiceComboBox.Size = new System.Drawing.Size(136, 28);
            this.CabinChoiceComboBox.TabIndex = 0;
            this.CabinChoiceComboBox.SelectedIndexChanged += new System.EventHandler(this.CabinChoiceComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Cabin Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Cabins to Book";
            // 
            // NumberOfCabins
            // 
            this.NumberOfCabins.Location = new System.Drawing.Point(280, 260);
            this.NumberOfCabins.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumberOfCabins.Name = "NumberOfCabins";
            this.NumberOfCabins.Size = new System.Drawing.Size(62, 26);
            this.NumberOfCabins.TabIndex = 3;
            // 
            // AddCabinsButton
            // 
            this.AddCabinsButton.Location = new System.Drawing.Point(258, 305);
            this.AddCabinsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddCabinsButton.Name = "AddCabinsButton";
            this.AddCabinsButton.Size = new System.Drawing.Size(84, 48);
            this.AddCabinsButton.TabIndex = 4;
            this.AddCabinsButton.Text = "Book";
            this.AddCabinsButton.UseVisualStyleBackColor = true;
            this.AddCabinsButton.Click += new System.EventHandler(this.AddCabinsButton_Click);
            // 
            // NumberError
            // 
            this.NumberError.AutoSize = true;
            this.NumberError.ForeColor = System.Drawing.Color.Crimson;
            this.NumberError.Location = new System.Drawing.Point(28, 305);
            this.NumberError.Name = "NumberError";
            this.NumberError.Size = new System.Drawing.Size(241, 20);
            this.NumberError.TabIndex = 5;
            this.NumberError.Text = "Please Specify Number of Cabns";
            // 
            // TobeBookedDataGrid
            // 
            this.TobeBookedDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TobeBookedDataGrid.Location = new System.Drawing.Point(623, -1);
            this.TobeBookedDataGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TobeBookedDataGrid.Name = "TobeBookedDataGrid";
            this.TobeBookedDataGrid.RowHeadersWidth = 51;
            this.TobeBookedDataGrid.RowTemplate.Height = 24;
            this.TobeBookedDataGrid.Size = new System.Drawing.Size(641, 432);
            this.TobeBookedDataGrid.TabIndex = 6;
            this.TobeBookedDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TobeBookedDataGrid_CellContentClick);
            // 
            // GoToCheckout
            // 
            this.GoToCheckout.Location = new System.Drawing.Point(91, 610);
            this.GoToCheckout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GoToCheckout.Name = "GoToCheckout";
            this.GoToCheckout.Size = new System.Drawing.Size(251, 78);
            this.GoToCheckout.TabIndex = 7;
            this.GoToCheckout.Text = "Go To Checkout";
            this.GoToCheckout.UseVisualStyleBackColor = true;
            this.GoToCheckout.Click += new System.EventHandler(this.GoToCheckout_Click);
            // 
            // SelectionError
            // 
            this.SelectionError.AutoSize = true;
            this.SelectionError.ForeColor = System.Drawing.Color.Crimson;
            this.SelectionError.Location = new System.Drawing.Point(57, 240);
            this.SelectionError.Name = "SelectionError";
            this.SelectionError.Size = new System.Drawing.Size(188, 20);
            this.SelectionError.TabIndex = 8;
            this.SelectionError.Text = "Please Select Cabin SIze";
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(14, 15);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(106, 45);
            this.GoBackButton.TabIndex = 9;
            this.GoBackButton.Text = "Go Back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.Location = new System.Drawing.Point(186, 11);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(57, 20);
            this.InfoLabel.TabIndex = 10;
            this.InfoLabel.Text = "label3";
            // 
            // PricePerNightLabel
            // 
            this.PricePerNightLabel.AutoSize = true;
            this.PricePerNightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PricePerNightLabel.Location = new System.Drawing.Point(410, 204);
            this.PricePerNightLabel.Name = "PricePerNightLabel";
            this.PricePerNightLabel.Size = new System.Drawing.Size(121, 20);
            this.PricePerNightLabel.TabIndex = 11;
            this.PricePerNightLabel.Text = "Price Per Night: ";
            // 
            // InvoiceLabel
            // 
            this.InvoiceLabel.AutoSize = true;
            this.InvoiceLabel.Location = new System.Drawing.Point(28, 429);
            this.InvoiceLabel.Name = "InvoiceLabel";
            this.InvoiceLabel.Size = new System.Drawing.Size(51, 20);
            this.InvoiceLabel.TabIndex = 12;
            this.InvoiceLabel.Text = "label3";
            // 
            // TermsLabel
            // 
            this.TermsLabel.AutoSize = true;
            this.TermsLabel.Location = new System.Drawing.Point(240, 475);
            this.TermsLabel.Name = "TermsLabel";
            this.TermsLabel.Size = new System.Drawing.Size(92, 20);
            this.TermsLabel.TabIndex = 13;
            this.TermsLabel.Text = "TermsLabel";
            // 
            // PayButton
            // 
            this.PayButton.Location = new System.Drawing.Point(413, 610);
            this.PayButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(187, 78);
            this.PayButton.TabIndex = 14;
            this.PayButton.Text = "Pay";
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.ForeColor = System.Drawing.Color.Red;
            this.CancelButton.Location = new System.Drawing.Point(858, 610);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(140, 78);
            this.CancelButton.TabIndex = 15;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NewDiscountedPrice
            // 
            this.NewDiscountedPrice.AutoSize = true;
            this.NewDiscountedPrice.Location = new System.Drawing.Point(28, 462);
            this.NewDiscountedPrice.Name = "NewDiscountedPrice";
            this.NewDiscountedPrice.Size = new System.Drawing.Size(51, 20);
            this.NewDiscountedPrice.TabIndex = 16;
            this.NewDiscountedPrice.Text = "label3";
            // 
            // PayLater
            // 
            this.PayLater.Location = new System.Drawing.Point(654, 610);
            this.PayLater.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PayLater.Name = "PayLater";
            this.PayLater.Size = new System.Drawing.Size(156, 78);
            this.PayLater.TabIndex = 17;
            this.PayLater.Text = "Book and Pay Later";
            this.PayLater.UseVisualStyleBackColor = true;
            this.PayLater.Click += new System.EventHandler(this.PayLater_Click);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 702);
            this.Controls.Add(this.PayLater);
            this.Controls.Add(this.NewDiscountedPrice);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.TermsLabel);
            this.Controls.Add(this.InvoiceLabel);
            this.Controls.Add(this.PricePerNightLabel);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.SelectionError);
            this.Controls.Add(this.GoToCheckout);
            this.Controls.Add(this.TobeBookedDataGrid);
            this.Controls.Add(this.NumberError);
            this.Controls.Add(this.AddCabinsButton);
            this.Controls.Add(this.NumberOfCabins);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CabinChoiceComboBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BookingForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfCabins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TobeBookedDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CabinChoiceComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumberOfCabins;
        private System.Windows.Forms.Button AddCabinsButton;
        private System.Windows.Forms.Label NumberError;
        private System.Windows.Forms.DataGridView TobeBookedDataGrid;
        private System.Windows.Forms.Button GoToCheckout;
        private System.Windows.Forms.Label SelectionError;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label PricePerNightLabel;
        private System.Windows.Forms.Label InvoiceLabel;
        private System.Windows.Forms.Label TermsLabel;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label NewDiscountedPrice;
        private System.Windows.Forms.Button PayLater;
    }
}