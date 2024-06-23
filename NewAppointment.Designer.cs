namespace WindowsFormsApp1
{
    partial class NewAppointment
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cName = new System.Windows.Forms.TextBox();
            this.apptType = new System.Windows.Forms.TextBox();
            this.cId = new System.Windows.Forms.TextBox();
            this.saveBn = new System.Windows.Forms.Button();
            this.cancelBn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(218, 84);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cName
            // 
            this.cName.Enabled = false;
            this.cName.Location = new System.Drawing.Point(218, 143);
            this.cName.Name = "cName";
            this.cName.Size = new System.Drawing.Size(100, 20);
            this.cName.TabIndex = 3;
            // 
            // apptType
            // 
            this.apptType.Location = new System.Drawing.Point(218, 177);
            this.apptType.Name = "apptType";
            this.apptType.Size = new System.Drawing.Size(100, 20);
            this.apptType.TabIndex = 4;
            // 
            // cId
            // 
            this.cId.Enabled = false;
            this.cId.Location = new System.Drawing.Point(375, 143);
            this.cId.Name = "cId";
            this.cId.Size = new System.Drawing.Size(43, 20);
            this.cId.TabIndex = 5;
            // 
            // saveBn
            // 
            this.saveBn.Location = new System.Drawing.Point(218, 224);
            this.saveBn.Name = "saveBn";
            this.saveBn.Size = new System.Drawing.Size(75, 23);
            this.saveBn.TabIndex = 6;
            this.saveBn.Text = "Save";
            this.saveBn.UseVisualStyleBackColor = true;
            this.saveBn.Click += new System.EventHandler(this.saveBn_Click);
            // 
            // cancelBn
            // 
            this.cancelBn.Location = new System.Drawing.Point(299, 224);
            this.cancelBn.Name = "cancelBn";
            this.cancelBn.Size = new System.Drawing.Size(75, 23);
            this.cancelBn.TabIndex = 7;
            this.cancelBn.Text = "Cancel";
            this.cancelBn.UseVisualStyleBackColor = true;
            this.cancelBn.Click += new System.EventHandler(this.cancelBn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "All appointments are scheduled for 45 minutes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Start Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Appointment Type";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Customer Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Please adjust appointment Time before saving";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(152, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(253, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Business Hours are from 8:00AM to 8:00PM";
            // 
            // cType
            // 
            this.cType.Location = new System.Drawing.Point(45, 53);
            this.cType.Name = "cType";
            this.cType.Size = new System.Drawing.Size(42, 20);
            this.cType.TabIndex = 28;
            this.cType.Visible = false;
            // 
            // NewAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 450);
            this.Controls.Add(this.cType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBn);
            this.Controls.Add(this.saveBn);
            this.Controls.Add(this.cId);
            this.Controls.Add(this.apptType);
            this.Controls.Add(this.cName);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "NewAppointment";
            this.Text = "New Appointment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewAppointment_FormClosed);
            this.Load += new System.EventHandler(this.NewAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox cName;
        private System.Windows.Forms.TextBox apptType;
        private System.Windows.Forms.TextBox cId;
        private System.Windows.Forms.Button saveBn;
        private System.Windows.Forms.Button cancelBn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cType;
    }
}