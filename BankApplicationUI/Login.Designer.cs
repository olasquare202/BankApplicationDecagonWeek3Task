namespace BankApplicationUI
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblInvalid = new System.Windows.Forms.Label();
            this.lblInvalidEmail = new System.Windows.Forms.Label();
            this.lblInvalidPassword = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(223, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(315, 128);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(214, 23);
            this.txtEmail.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPassword.Location = new System.Drawing.Point(223, 208);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 21);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(315, 206);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(214, 23);
            this.txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.Red;
            this.btnLogin.Location = new System.Drawing.Point(374, 273);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(84, 34);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblInvalid
            // 
            this.lblInvalid.AutoSize = true;
            this.lblInvalid.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInvalid.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblInvalid.Location = new System.Drawing.Point(374, 24);
            this.lblInvalid.Name = "lblInvalid";
            this.lblInvalid.Size = new System.Drawing.Size(154, 37);
            this.lblInvalid.TabIndex = 5;
            this.lblInvalid.Text = "User Login";
            // 
            // lblInvalidEmail
            // 
            this.lblInvalidEmail.AutoSize = true;
            this.lblInvalidEmail.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidEmail.Location = new System.Drawing.Point(315, 164);
            this.lblInvalidEmail.Name = "lblInvalidEmail";
            this.lblInvalidEmail.Size = new System.Drawing.Size(113, 15);
            this.lblInvalidEmail.TabIndex = 18;
            this.lblInvalidEmail.Text = "Invalid email format";
            this.lblInvalidEmail.Visible = false;
            // 
            // lblInvalidPassword
            // 
            this.lblInvalidPassword.AutoSize = true;
            this.lblInvalidPassword.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidPassword.Location = new System.Drawing.Point(315, 246);
            this.lblInvalidPassword.Name = "lblInvalidPassword";
            this.lblInvalidPassword.Size = new System.Drawing.Size(134, 15);
            this.lblInvalidPassword.TabIndex = 20;
            this.lblInvalidPassword.Text = "Invalid password format";
            this.lblInvalidPassword.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Don\'t have an account?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(444, 335);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(65, 15);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Register";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInvalidPassword);
            this.Controls.Add(this.lblInvalidEmail);
            this.Controls.Add(this.lblInvalid);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblInvalid;
        private Label lblInvalidEmail;
        private Label lblInvalidPassword;
        private Label label2;
        private LinkLabel linkLabel1;
    }
}