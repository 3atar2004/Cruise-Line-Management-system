namespace Cruise_Line
{
    partial class AddCruise
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.departureTextbox = new System.Windows.Forms.TextBox();
            this.DestinationTextbox = new System.Windows.Forms.TextBox();
            this.shipCombobox = new System.Windows.Forms.ComboBox();
            this.desctextbox = new System.Windows.Forms.RichTextBox();
            this.InsertCruiseButton = new System.Windows.Forms.Button();
            this.gobackbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cruise Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "start date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "end date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Deperature";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Destination";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Available Ships:";
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(181, 58);
            this.nametextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(212, 26);
            this.nametextbox.TabIndex = 7;
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Location = new System.Drawing.Point(181, 118);
            this.StartDatePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(210, 26);
            this.StartDatePicker.TabIndex = 8;
            this.StartDatePicker.ValueChanged += new System.EventHandler(this.StartDatePicker_ValueChanged);
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Location = new System.Drawing.Point(502, 118);
            this.EndDatePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(210, 26);
            this.EndDatePicker.TabIndex = 9;
            this.EndDatePicker.ValueChanged += new System.EventHandler(this.EndDatePicker_ValueChanged);
            // 
            // departureTextbox
            // 
            this.departureTextbox.Location = new System.Drawing.Point(181, 186);
            this.departureTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.departureTextbox.Name = "departureTextbox";
            this.departureTextbox.Size = new System.Drawing.Size(208, 26);
            this.departureTextbox.TabIndex = 10;
            // 
            // DestinationTextbox
            // 
            this.DestinationTextbox.Location = new System.Drawing.Point(502, 186);
            this.DestinationTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DestinationTextbox.Name = "DestinationTextbox";
            this.DestinationTextbox.Size = new System.Drawing.Size(208, 26);
            this.DestinationTextbox.TabIndex = 11;
            // 
            // shipCombobox
            // 
            this.shipCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shipCombobox.FormattingEnabled = true;
            this.shipCombobox.Location = new System.Drawing.Point(213, 262);
            this.shipCombobox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.shipCombobox.Name = "shipCombobox";
            this.shipCombobox.Size = new System.Drawing.Size(210, 28);
            this.shipCombobox.TabIndex = 12;
            this.shipCombobox.SelectedIndexChanged += new System.EventHandler(this.shipCombobox_SelectedIndexChanged);
            // 
            // desctextbox
            // 
            this.desctextbox.Location = new System.Drawing.Point(181, 334);
            this.desctextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.desctextbox.Name = "desctextbox";
            this.desctextbox.Size = new System.Drawing.Size(339, 76);
            this.desctextbox.TabIndex = 13;
            this.desctextbox.Text = "";
            // 
            // InsertCruiseButton
            // 
            this.InsertCruiseButton.Location = new System.Drawing.Point(260, 440);
            this.InsertCruiseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InsertCruiseButton.Name = "InsertCruiseButton";
            this.InsertCruiseButton.Size = new System.Drawing.Size(199, 59);
            this.InsertCruiseButton.TabIndex = 14;
            this.InsertCruiseButton.Text = "Add Cruise";
            this.InsertCruiseButton.UseVisualStyleBackColor = true;
            this.InsertCruiseButton.Click += new System.EventHandler(this.InsertCruiseButton_Click);
            // 
            // gobackbtn
            // 
            this.gobackbtn.Location = new System.Drawing.Point(583, 440);
            this.gobackbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gobackbtn.Name = "gobackbtn";
            this.gobackbtn.Size = new System.Drawing.Size(104, 59);
            this.gobackbtn.TabIndex = 15;
            this.gobackbtn.Text = "Go Back";
            this.gobackbtn.UseVisualStyleBackColor = true;
            this.gobackbtn.Click += new System.EventHandler(this.gobackbtn_Click);
            // 
            // AddCruise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gobackbtn);
            this.Controls.Add(this.InsertCruiseButton);
            this.Controls.Add(this.desctextbox);
            this.Controls.Add(this.shipCombobox);
            this.Controls.Add(this.DestinationTextbox);
            this.Controls.Add(this.departureTextbox);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.nametextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddCruise";
            this.Size = new System.Drawing.Size(870, 550);
            this.Load += new System.EventHandler(this.AddCruise_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.TextBox departureTextbox;
        private System.Windows.Forms.TextBox DestinationTextbox;
        private System.Windows.Forms.ComboBox shipCombobox;
        private System.Windows.Forms.RichTextBox desctextbox;
        private System.Windows.Forms.Button InsertCruiseButton;
        private System.Windows.Forms.Button gobackbtn;
    }
}
