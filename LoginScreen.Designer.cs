namespace WindowsFormsApp1
{
    partial class LoginScreen
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
            this.userlogintext = new System.Windows.Forms.TextBox();
            this.userpasswordtext = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.userPassLabel = new System.Windows.Forms.Label();
            this.cancelBn = new System.Windows.Forms.Button();
            this.loginBn = new System.Windows.Forms.Button();
            this.please = new System.Windows.Forms.Label();
            this.invalidMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userlogintext
            // 
            this.userlogintext.Location = new System.Drawing.Point(239, 125);
            this.userlogintext.Name = "userlogintext";
            this.userlogintext.Size = new System.Drawing.Size(160, 20);
            this.userlogintext.TabIndex = 0;
            // 
            // userpasswordtext
            // 
            this.userpasswordtext.Location = new System.Drawing.Point(239, 169);
            this.userpasswordtext.Name = "userpasswordtext";
            this.userpasswordtext.Size = new System.Drawing.Size(160, 20);
            this.userpasswordtext.TabIndex = 1;
            this.userpasswordtext.TextChanged += new System.EventHandler(this.userpasswordtext_TextChanged);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(136, 125);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(63, 13);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "User Name:";
            // 
            // userPassLabel
            // 
            this.userPassLabel.AutoSize = true;
            this.userPassLabel.Location = new System.Drawing.Point(136, 169);
            this.userPassLabel.Name = "userPassLabel";
            this.userPassLabel.Size = new System.Drawing.Size(56, 13);
            this.userPassLabel.TabIndex = 3;
            this.userPassLabel.Text = "Password:";
            // 
            // cancelBn
            // 
            this.cancelBn.Location = new System.Drawing.Point(324, 207);
            this.cancelBn.Name = "cancelBn";
            this.cancelBn.Size = new System.Drawing.Size(75, 23);
            this.cancelBn.TabIndex = 4;
            this.cancelBn.Text = "Cancel";
            this.cancelBn.UseVisualStyleBackColor = true;
            this.cancelBn.Click += new System.EventHandler(this.cancelBn_Click);
            // 
            // loginBn
            // 
            this.loginBn.AutoSize = true;
            this.loginBn.Location = new System.Drawing.Point(239, 207);
            this.loginBn.Name = "loginBn";
            this.loginBn.Size = new System.Drawing.Size(75, 23);
            this.loginBn.TabIndex = 5;
            this.loginBn.Text = "Log In";
            this.loginBn.UseVisualStyleBackColor = true;
            this.loginBn.Click += new System.EventHandler(this.loginBn_Click);
            // 
            // please
            // 
            this.please.AutoSize = true;
            this.please.Location = new System.Drawing.Point(236, 91);
            this.please.Name = "please";
            this.please.Size = new System.Drawing.Size(171, 13);
            this.please.TabIndex = 6;
            this.please.Text = "Please enter your log in credentials";
            // 
            // invalidMessage
            // 
            this.invalidMessage.AutoSize = true;
            this.invalidMessage.Location = new System.Drawing.Point(218, 243);
            this.invalidMessage.Name = "invalidMessage";
            this.invalidMessage.Size = new System.Drawing.Size(35, 13);
            this.invalidMessage.TabIndex = 7;
            this.invalidMessage.Text = "label1";
            this.invalidMessage.Visible = false;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.invalidMessage);
            this.Controls.Add(this.please);
            this.Controls.Add(this.loginBn);
            this.Controls.Add(this.cancelBn);
            this.Controls.Add(this.userPassLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.userpasswordtext);
            this.Controls.Add(this.userlogintext);
            this.Name = "LoginScreen";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userlogintext;
        private System.Windows.Forms.TextBox userpasswordtext;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label userPassLabel;
        private System.Windows.Forms.Button cancelBn;
        private System.Windows.Forms.Button loginBn;
        private System.Windows.Forms.Label please;
        private System.Windows.Forms.Label invalidMessage;
    }
}