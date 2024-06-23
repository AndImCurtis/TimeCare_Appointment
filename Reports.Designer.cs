namespace WindowsFormsApp1
{
    partial class Reports
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
            this.cancelBn = new System.Windows.Forms.Button();
            this.genBn = new System.Windows.Forms.Button();
            this.cRbn = new System.Windows.Forms.RadioButton();
            this.apptRbn = new System.Windows.Forms.RadioButton();
            this.consulRbn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBn
            // 
            this.cancelBn.Location = new System.Drawing.Point(768, 298);
            this.cancelBn.Name = "cancelBn";
            this.cancelBn.Size = new System.Drawing.Size(75, 23);
            this.cancelBn.TabIndex = 1;
            this.cancelBn.Text = "Cancel";
            this.cancelBn.UseVisualStyleBackColor = true;
            this.cancelBn.Click += new System.EventHandler(this.cancelBn_Click);
            // 
            // genBn
            // 
            this.genBn.Location = new System.Drawing.Point(105, 162);
            this.genBn.Name = "genBn";
            this.genBn.Size = new System.Drawing.Size(75, 31);
            this.genBn.TabIndex = 4;
            this.genBn.Text = "Generate";
            this.genBn.UseVisualStyleBackColor = true;
            this.genBn.Click += new System.EventHandler(this.genBn_Click);
            // 
            // cRbn
            // 
            this.cRbn.AutoSize = true;
            this.cRbn.Location = new System.Drawing.Point(12, 90);
            this.cRbn.Name = "cRbn";
            this.cRbn.Size = new System.Drawing.Size(161, 17);
            this.cRbn.TabIndex = 5;
            this.cRbn.TabStop = true;
            this.cRbn.Text = "Active Tickets By Consultant";
            this.cRbn.UseVisualStyleBackColor = true;
            this.cRbn.CheckedChanged += new System.EventHandler(this.cRbn_CheckedChanged);
            // 
            // apptRbn
            // 
            this.apptRbn.AutoSize = true;
            this.apptRbn.Location = new System.Drawing.Point(12, 113);
            this.apptRbn.Name = "apptRbn";
            this.apptRbn.Size = new System.Drawing.Size(111, 17);
            this.apptRbn.TabIndex = 6;
            this.apptRbn.TabStop = true;
            this.apptRbn.Text = "Appointment Type";
            this.apptRbn.UseVisualStyleBackColor = true;
            this.apptRbn.CheckedChanged += new System.EventHandler(this.apptRbn_CheckedChanged);
            // 
            // consulRbn
            // 
            this.consulRbn.AutoSize = true;
            this.consulRbn.Location = new System.Drawing.Point(49, 247);
            this.consulRbn.Name = "consulRbn";
            this.consulRbn.Size = new System.Drawing.Size(14, 13);
            this.consulRbn.TabIndex = 7;
            this.consulRbn.TabStop = true;
            this.consulRbn.UseVisualStyleBackColor = true;
            this.consulRbn.Visible = false;
            this.consulRbn.CheckedChanged += new System.EventHandler(this.consulRbn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Report";
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToResizeColumns = false;
            this.dgvReport.AllowUserToResizeRows = false;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(357, 58);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersVisible = false;
            this.dgvReport.RowTemplate.ReadOnly = true;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.Size = new System.Drawing.Size(486, 219);
            this.dgvReport.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "January",
            "Feburary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboBox1.Location = new System.Drawing.Point(129, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Please select a month.";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.consulRbn);
            this.Controls.Add(this.apptRbn);
            this.Controls.Add(this.cRbn);
            this.Controls.Add(this.genBn);
            this.Controls.Add(this.cancelBn);
            this.Name = "Reports";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelBn;
        private System.Windows.Forms.Button genBn;
        private System.Windows.Forms.RadioButton cRbn;
        private System.Windows.Forms.RadioButton apptRbn;
        private System.Windows.Forms.RadioButton consulRbn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}