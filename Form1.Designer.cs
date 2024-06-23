namespace WindowsFormsApp1
{
    partial class Form1
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
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.closeBn = new System.Windows.Forms.Button();
            this.reportsBn = new System.Windows.Forms.Button();
            this.newCustbn = new System.Windows.Forms.Button();
            this.editCustbn = new System.Windows.Forms.Button();
            this.labCust = new System.Windows.Forms.Label();
            this.labAppt = new System.Windows.Forms.Label();
            this.newApptbn = new System.Windows.Forms.Button();
            this.editApptbn = new System.Windows.Forms.Button();
            this.delApptbn = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.allBn = new System.Windows.Forms.Button();
            this.monthBn = new System.Windows.Forms.Button();
            this.CustDelBn = new System.Windows.Forms.Button();
            this.custRB = new System.Windows.Forms.RadioButton();
            this.apptRB = new System.Windows.Forms.RadioButton();
            this.weekBn = new System.Windows.Forms.Button();
            this.apptAllBn = new System.Windows.Forms.Button();
            this.searchTxt = new System.Windows.Forms.RichTextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToResizeColumns = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(254, 74);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowTemplate.ReadOnly = true;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(666, 219);
            this.dgvMain.TabIndex = 0;
            this.dgvMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellClick);
            this.dgvMain.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvMain_DataBindingComplete);
            // 
            // closeBn
            // 
            this.closeBn.Location = new System.Drawing.Point(845, 309);
            this.closeBn.Name = "closeBn";
            this.closeBn.Size = new System.Drawing.Size(75, 23);
            this.closeBn.TabIndex = 1;
            this.closeBn.Text = "Close";
            this.closeBn.UseVisualStyleBackColor = true;
            this.closeBn.Click += new System.EventHandler(this.closeBn_Click);
            // 
            // reportsBn
            // 
            this.reportsBn.Location = new System.Drawing.Point(335, 309);
            this.reportsBn.Name = "reportsBn";
            this.reportsBn.Size = new System.Drawing.Size(75, 23);
            this.reportsBn.TabIndex = 2;
            this.reportsBn.Text = "Reports";
            this.reportsBn.UseVisualStyleBackColor = true;
            this.reportsBn.Click += new System.EventHandler(this.reportsBn_Click);
            // 
            // newCustbn
            // 
            this.newCustbn.Location = new System.Drawing.Point(48, 89);
            this.newCustbn.Name = "newCustbn";
            this.newCustbn.Size = new System.Drawing.Size(75, 23);
            this.newCustbn.TabIndex = 3;
            this.newCustbn.Text = "New";
            this.newCustbn.UseVisualStyleBackColor = true;
            this.newCustbn.Click += new System.EventHandler(this.newCustbn_Click);
            // 
            // editCustbn
            // 
            this.editCustbn.Location = new System.Drawing.Point(129, 60);
            this.editCustbn.Name = "editCustbn";
            this.editCustbn.Size = new System.Drawing.Size(75, 23);
            this.editCustbn.TabIndex = 4;
            this.editCustbn.Text = "Edit";
            this.editCustbn.UseVisualStyleBackColor = true;
            this.editCustbn.Click += new System.EventHandler(this.editCustbn_Click);
            // 
            // labCust
            // 
            this.labCust.AutoSize = true;
            this.labCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCust.Location = new System.Drawing.Point(87, 37);
            this.labCust.Name = "labCust";
            this.labCust.Size = new System.Drawing.Size(86, 20);
            this.labCust.TabIndex = 5;
            this.labCust.Text = "Customer";
            // 
            // labAppt
            // 
            this.labAppt.AutoSize = true;
            this.labAppt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAppt.Location = new System.Drawing.Point(72, 160);
            this.labAppt.Name = "labAppt";
            this.labAppt.Size = new System.Drawing.Size(120, 20);
            this.labAppt.TabIndex = 6;
            this.labAppt.Text = "Appointments";
            // 
            // newApptbn
            // 
            this.newApptbn.Location = new System.Drawing.Point(48, 223);
            this.newApptbn.Name = "newApptbn";
            this.newApptbn.Size = new System.Drawing.Size(75, 23);
            this.newApptbn.TabIndex = 7;
            this.newApptbn.Text = "New";
            this.newApptbn.UseVisualStyleBackColor = true;
            this.newApptbn.Click += new System.EventHandler(this.newApptbn_Click);
            // 
            // editApptbn
            // 
            this.editApptbn.Location = new System.Drawing.Point(129, 193);
            this.editApptbn.Name = "editApptbn";
            this.editApptbn.Size = new System.Drawing.Size(75, 23);
            this.editApptbn.TabIndex = 8;
            this.editApptbn.Text = "Edit";
            this.editApptbn.UseVisualStyleBackColor = true;
            this.editApptbn.Click += new System.EventHandler(this.editApptbn_Click);
            // 
            // delApptbn
            // 
            this.delApptbn.Location = new System.Drawing.Point(129, 223);
            this.delApptbn.Name = "delApptbn";
            this.delApptbn.Size = new System.Drawing.Size(75, 23);
            this.delApptbn.TabIndex = 9;
            this.delApptbn.Text = "Delete";
            this.delApptbn.UseVisualStyleBackColor = true;
            this.delApptbn.Click += new System.EventHandler(this.delApptbn_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(15, 258);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // allBn
            // 
            this.allBn.Location = new System.Drawing.Point(48, 60);
            this.allBn.Name = "allBn";
            this.allBn.Size = new System.Drawing.Size(75, 23);
            this.allBn.TabIndex = 11;
            this.allBn.Text = "Show All";
            this.allBn.UseVisualStyleBackColor = true;
            this.allBn.Click += new System.EventHandler(this.allBn_Click);
            // 
            // monthBn
            // 
            this.monthBn.Location = new System.Drawing.Point(254, 309);
            this.monthBn.Name = "monthBn";
            this.monthBn.Size = new System.Drawing.Size(75, 23);
            this.monthBn.TabIndex = 12;
            this.monthBn.Text = "View Month";
            this.monthBn.UseVisualStyleBackColor = true;
            this.monthBn.Click += new System.EventHandler(this.monthBn_Click);
            // 
            // CustDelBn
            // 
            this.CustDelBn.Location = new System.Drawing.Point(129, 89);
            this.CustDelBn.Name = "CustDelBn";
            this.CustDelBn.Size = new System.Drawing.Size(75, 23);
            this.CustDelBn.TabIndex = 13;
            this.CustDelBn.Text = "Delete";
            this.CustDelBn.UseVisualStyleBackColor = true;
            this.CustDelBn.Click += new System.EventHandler(this.CustDelBn_Click);
            // 
            // custRB
            // 
            this.custRB.AutoSize = true;
            this.custRB.Location = new System.Drawing.Point(379, 51);
            this.custRB.Name = "custRB";
            this.custRB.Size = new System.Drawing.Size(74, 17);
            this.custRB.TabIndex = 14;
            this.custRB.TabStop = true;
            this.custRB.Text = "Customers";
            this.custRB.UseVisualStyleBackColor = true;
            this.custRB.CheckedChanged += new System.EventHandler(this.custRB_CheckedChanged);
            // 
            // apptRB
            // 
            this.apptRB.AutoSize = true;
            this.apptRB.Location = new System.Drawing.Point(254, 51);
            this.apptRB.Name = "apptRB";
            this.apptRB.Size = new System.Drawing.Size(89, 17);
            this.apptRB.TabIndex = 15;
            this.apptRB.TabStop = true;
            this.apptRB.Text = "Appointments";
            this.apptRB.UseVisualStyleBackColor = true;
            this.apptRB.CheckedChanged += new System.EventHandler(this.apptRB_CheckedChanged);
            // 
            // weekBn
            // 
            this.weekBn.Location = new System.Drawing.Point(254, 338);
            this.weekBn.Name = "weekBn";
            this.weekBn.Size = new System.Drawing.Size(75, 23);
            this.weekBn.TabIndex = 16;
            this.weekBn.Text = "View Week";
            this.weekBn.UseVisualStyleBackColor = true;
            this.weekBn.Click += new System.EventHandler(this.weekBn_Click);
            // 
            // apptAllBn
            // 
            this.apptAllBn.Location = new System.Drawing.Point(48, 193);
            this.apptAllBn.Name = "apptAllBn";
            this.apptAllBn.Size = new System.Drawing.Size(75, 23);
            this.apptAllBn.TabIndex = 17;
            this.apptAllBn.Text = "Show All";
            this.apptAllBn.UseVisualStyleBackColor = true;
            this.apptAllBn.Click += new System.EventHandler(this.apptAllBn_Click);
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(631, 39);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(184, 20);
            this.searchTxt.TabIndex = 18;
            this.searchTxt.Text = "";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(821, 39);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 19;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 450);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.apptAllBn);
            this.Controls.Add(this.weekBn);
            this.Controls.Add(this.apptRB);
            this.Controls.Add(this.custRB);
            this.Controls.Add(this.CustDelBn);
            this.Controls.Add(this.monthBn);
            this.Controls.Add(this.allBn);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.delApptbn);
            this.Controls.Add(this.editApptbn);
            this.Controls.Add(this.newApptbn);
            this.Controls.Add(this.labAppt);
            this.Controls.Add(this.labCust);
            this.Controls.Add(this.editCustbn);
            this.Controls.Add(this.newCustbn);
            this.Controls.Add(this.reportsBn);
            this.Controls.Add(this.closeBn);
            this.Controls.Add(this.dgvMain);
            this.Name = "Form1";
            this.Text = "Main Screen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button closeBn;
        private System.Windows.Forms.Button reportsBn;
        private System.Windows.Forms.Button newCustbn;
        private System.Windows.Forms.Button editCustbn;
        private System.Windows.Forms.Label labCust;
        private System.Windows.Forms.Label labAppt;
        private System.Windows.Forms.Button newApptbn;
        private System.Windows.Forms.Button editApptbn;
        private System.Windows.Forms.Button delApptbn;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button allBn;
        private System.Windows.Forms.Button monthBn;
        private System.Windows.Forms.Button CustDelBn;
        private System.Windows.Forms.RadioButton custRB;
        private System.Windows.Forms.RadioButton apptRB;
        private System.Windows.Forms.Button weekBn;
        private System.Windows.Forms.Button apptAllBn;
        private System.Windows.Forms.RichTextBox searchTxt;
        private System.Windows.Forms.Button searchBtn;
    }
}

