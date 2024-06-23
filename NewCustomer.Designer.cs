namespace WindowsFormsApp1
{
    partial class NewCustomer
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
            this.phoneText = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.firstText = new System.Windows.Forms.TextBox();
            this.countryText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveBn = new System.Windows.Forms.Button();
            this.cancelBn = new System.Windows.Forms.Button();
            this.address2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.postalCodeText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cityText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.commercialRbn = new System.Windows.Forms.RadioButton();
            this.residentialRbn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(128, 142);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(100, 20);
            this.phoneText.TabIndex = 0;
            this.phoneText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneText_KeyPress);
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(128, 180);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(100, 20);
            this.addressText.TabIndex = 1;
            // 
            // firstText
            // 
            this.firstText.Location = new System.Drawing.Point(128, 115);
            this.firstText.Name = "firstText";
            this.firstText.Size = new System.Drawing.Size(100, 20);
            this.firstText.TabIndex = 2;
            // 
            // countryText
            // 
            this.countryText.Location = new System.Drawing.Point(128, 247);
            this.countryText.Name = "countryText";
            this.countryText.Size = new System.Drawing.Size(100, 20);
            this.countryText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Country";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // saveBn
            // 
            this.saveBn.Location = new System.Drawing.Point(195, 361);
            this.saveBn.Name = "saveBn";
            this.saveBn.Size = new System.Drawing.Size(75, 23);
            this.saveBn.TabIndex = 10;
            this.saveBn.Text = "Save";
            this.saveBn.UseVisualStyleBackColor = true;
            this.saveBn.Click += new System.EventHandler(this.saveBn_Click);
            // 
            // cancelBn
            // 
            this.cancelBn.Location = new System.Drawing.Point(276, 361);
            this.cancelBn.Name = "cancelBn";
            this.cancelBn.Size = new System.Drawing.Size(75, 23);
            this.cancelBn.TabIndex = 11;
            this.cancelBn.Text = "Cancel";
            this.cancelBn.UseVisualStyleBackColor = true;
            this.cancelBn.Click += new System.EventHandler(this.cancelBn_Click);
            // 
            // address2
            // 
            this.address2.Location = new System.Drawing.Point(128, 217);
            this.address2.Name = "address2";
            this.address2.Size = new System.Drawing.Size(100, 20);
            this.address2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Address 2";
            // 
            // postalCodeText
            // 
            this.postalCodeText.Location = new System.Drawing.Point(276, 217);
            this.postalCodeText.Name = "postalCodeText";
            this.postalCodeText.Size = new System.Drawing.Size(100, 20);
            this.postalCodeText.TabIndex = 14;
            this.postalCodeText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.postalCodeText_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Zip";
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(276, 180);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(100, 20);
            this.cityText.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "City";
            // 
            // commercialRbn
            // 
            this.commercialRbn.AutoSize = true;
            this.commercialRbn.Location = new System.Drawing.Point(128, 46);
            this.commercialRbn.Name = "commercialRbn";
            this.commercialRbn.Size = new System.Drawing.Size(79, 17);
            this.commercialRbn.TabIndex = 18;
            this.commercialRbn.TabStop = true;
            this.commercialRbn.Text = "Commercial";
            this.commercialRbn.UseVisualStyleBackColor = true;
            this.commercialRbn.CheckedChanged += new System.EventHandler(this.commercialRbn_CheckedChanged);
            // 
            // residentialRbn
            // 
            this.residentialRbn.AutoSize = true;
            this.residentialRbn.Location = new System.Drawing.Point(276, 46);
            this.residentialRbn.Name = "residentialRbn";
            this.residentialRbn.Size = new System.Drawing.Size(77, 17);
            this.residentialRbn.TabIndex = 19;
            this.residentialRbn.TabStop = true;
            this.residentialRbn.Text = "Residential";
            this.residentialRbn.UseVisualStyleBackColor = true;
            this.residentialRbn.CheckedChanged += new System.EventHandler(this.residentialRbn_CheckedChanged);
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.residentialRbn);
            this.Controls.Add(this.commercialRbn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.postalCodeText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.address2);
            this.Controls.Add(this.cancelBn);
            this.Controls.Add(this.saveBn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countryText);
            this.Controls.Add(this.firstText);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.phoneText);
            this.Name = "NewCustomer";
            this.Text = "New Customer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewCustomer_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.TextBox firstText;
        private System.Windows.Forms.TextBox countryText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveBn;
        private System.Windows.Forms.Button cancelBn;
        private System.Windows.Forms.TextBox address2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox postalCodeText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton commercialRbn;
        private System.Windows.Forms.RadioButton residentialRbn;
    }
}