namespace WindowsFormsApp1
{
    partial class EditCustomer
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
            this.saveBn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cityText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.postalCodeText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.address2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.countryText = new System.Windows.Forms.TextBox();
            this.firstText = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.custId = new System.Windows.Forms.TextBox();
            this.commercialRbn = new System.Windows.Forms.RadioButton();
            this.residentialRbn = new System.Windows.Forms.RadioButton();
            this.cType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelBn
            // 
            this.cancelBn.Location = new System.Drawing.Point(292, 285);
            this.cancelBn.Name = "cancelBn";
            this.cancelBn.Size = new System.Drawing.Size(75, 23);
            this.cancelBn.TabIndex = 23;
            this.cancelBn.Text = "Cancel";
            this.cancelBn.UseVisualStyleBackColor = true;
            this.cancelBn.Click += new System.EventHandler(this.cancelBn_Click_1);
            // 
            // saveBn
            // 
            this.saveBn.Location = new System.Drawing.Point(211, 285);
            this.saveBn.Name = "saveBn";
            this.saveBn.Size = new System.Drawing.Size(75, 23);
            this.saveBn.TabIndex = 22;
            this.saveBn.Text = "Save";
            this.saveBn.UseVisualStyleBackColor = true;
            this.saveBn.Click += new System.EventHandler(this.saveBn_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(304, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "City";
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(334, 174);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(100, 20);
            this.cityText.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Zip";
            // 
            // postalCodeText
            // 
            this.postalCodeText.Location = new System.Drawing.Point(334, 211);
            this.postalCodeText.Name = "postalCodeText";
            this.postalCodeText.Size = new System.Drawing.Size(100, 20);
            this.postalCodeText.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Address 2";
            // 
            // address2
            // 
            this.address2.Location = new System.Drawing.Point(186, 211);
            this.address2.Name = "address2";
            this.address2.Size = new System.Drawing.Size(100, 20);
            this.address2.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Country";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Full Name";
            // 
            // countryText
            // 
            this.countryText.Location = new System.Drawing.Point(186, 241);
            this.countryText.Name = "countryText";
            this.countryText.Size = new System.Drawing.Size(100, 20);
            this.countryText.TabIndex = 27;
            // 
            // firstText
            // 
            this.firstText.Location = new System.Drawing.Point(186, 109);
            this.firstText.Name = "firstText";
            this.firstText.Size = new System.Drawing.Size(100, 20);
            this.firstText.TabIndex = 26;
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(186, 174);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(100, 20);
            this.addressText.TabIndex = 25;
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(186, 136);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(100, 20);
            this.phoneText.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Customer ID";
            // 
            // custId
            // 
            this.custId.Enabled = false;
            this.custId.Location = new System.Drawing.Point(334, 136);
            this.custId.Name = "custId";
            this.custId.Size = new System.Drawing.Size(100, 20);
            this.custId.TabIndex = 39;
            // 
            // commercialRbn
            // 
            this.commercialRbn.AutoSize = true;
            this.commercialRbn.Enabled = false;
            this.commercialRbn.Location = new System.Drawing.Point(160, 42);
            this.commercialRbn.Name = "commercialRbn";
            this.commercialRbn.Size = new System.Drawing.Size(79, 17);
            this.commercialRbn.TabIndex = 40;
            this.commercialRbn.TabStop = true;
            this.commercialRbn.Text = "Commercial";
            this.commercialRbn.UseVisualStyleBackColor = true;
            this.commercialRbn.CheckedChanged += new System.EventHandler(this.commercialRbn_CheckedChanged);
            // 
            // residentialRbn
            // 
            this.residentialRbn.AutoSize = true;
            this.residentialRbn.Enabled = false;
            this.residentialRbn.Location = new System.Drawing.Point(292, 42);
            this.residentialRbn.Name = "residentialRbn";
            this.residentialRbn.Size = new System.Drawing.Size(77, 17);
            this.residentialRbn.TabIndex = 41;
            this.residentialRbn.TabStop = true;
            this.residentialRbn.Text = "Residential";
            this.residentialRbn.UseVisualStyleBackColor = true;
            this.residentialRbn.CheckedChanged += new System.EventHandler(this.residentialRbn_CheckedChanged);
            // 
            // cType
            // 
            this.cType.Location = new System.Drawing.Point(95, 41);
            this.cType.Name = "cType";
            this.cType.Size = new System.Drawing.Size(33, 20);
            this.cType.TabIndex = 42;
            this.cType.Visible = false;
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 450);
            this.Controls.Add(this.cType);
            this.Controls.Add(this.residentialRbn);
            this.Controls.Add(this.commercialRbn);
            this.Controls.Add(this.custId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.postalCodeText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.address2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countryText);
            this.Controls.Add(this.firstText);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.cancelBn);
            this.Controls.Add(this.saveBn);
            this.Name = "EditCustomer";
            this.Text = "Edit Customer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditCustomer_FormClosed);
            this.Load += new System.EventHandler(this.EditCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBn;
        private System.Windows.Forms.Button saveBn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox postalCodeText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox address2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox countryText;
        private System.Windows.Forms.TextBox firstText;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox custId;
        private System.Windows.Forms.RadioButton commercialRbn;
        private System.Windows.Forms.RadioButton residentialRbn;
        private System.Windows.Forms.TextBox cType;
    }
}