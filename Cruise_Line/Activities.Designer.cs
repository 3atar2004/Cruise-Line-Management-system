namespace Cruise_Line
{
    partial class Activities
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ActivitynameCombobox = new System.Windows.Forms.ComboBox();
            this.bookActivitybutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numofParticicpationstextbox = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Reservedactivitylabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(498, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(718, 203);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(741, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Activities";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Activity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Activity Name";
            // 
            // ActivitynameCombobox
            // 
            this.ActivitynameCombobox.BackColor = System.Drawing.Color.Gold;
            this.ActivitynameCombobox.FormattingEnabled = true;
            this.ActivitynameCombobox.Location = new System.Drawing.Point(194, 86);
            this.ActivitynameCombobox.Name = "ActivitynameCombobox";
            this.ActivitynameCombobox.Size = new System.Drawing.Size(155, 24);
            this.ActivitynameCombobox.TabIndex = 4;
            // 
            // bookActivitybutton
            // 
            this.bookActivitybutton.BackColor = System.Drawing.Color.Gold;
            this.bookActivitybutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookActivitybutton.Location = new System.Drawing.Point(498, 474);
            this.bookActivitybutton.Name = "bookActivitybutton";
            this.bookActivitybutton.Size = new System.Drawing.Size(277, 86);
            this.bookActivitybutton.TabIndex = 5;
            this.bookActivitybutton.Text = "Book New Activity";
            this.bookActivitybutton.UseVisualStyleBackColor = false;
            this.bookActivitybutton.Click += new System.EventHandler(this.bookActivitybutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of Participations";
            // 
            // numofParticicpationstextbox
            // 
            this.numofParticicpationstextbox.BackColor = System.Drawing.Color.Gold;
            this.numofParticicpationstextbox.Location = new System.Drawing.Point(318, 147);
            this.numofParticicpationstextbox.Name = "numofParticicpationstextbox";
            this.numofParticicpationstextbox.Size = new System.Drawing.Size(174, 22);
            this.numofParticicpationstextbox.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(29, 332);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1116, 136);
            this.dataGridView2.TabIndex = 8;
            // 
            // Reservedactivitylabel
            // 
            this.Reservedactivitylabel.AutoSize = true;
            this.Reservedactivitylabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.Reservedactivitylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reservedactivitylabel.Location = new System.Drawing.Point(38, 297);
            this.Reservedactivitylabel.Name = "Reservedactivitylabel";
            this.Reservedactivitylabel.Size = new System.Drawing.Size(213, 29);
            this.Reservedactivitylabel.TabIndex = 9;
            this.Reservedactivitylabel.Text = "Reserved Activity";
            // 
            // Activities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cruise_Line.Properties.Resources.ship32;
            this.ClientSize = new System.Drawing.Size(1219, 555);
            this.Controls.Add(this.Reservedactivitylabel);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.numofParticicpationstextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bookActivitybutton);
            this.Controls.Add(this.ActivitynameCombobox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Activities";
            this.Text = "Activities";
            this.Load += new System.EventHandler(this.Activities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ActivitynameCombobox;
        private System.Windows.Forms.Button bookActivitybutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numofParticicpationstextbox;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label Reservedactivitylabel;
    }
}