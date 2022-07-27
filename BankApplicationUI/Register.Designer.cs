namespace BankApplicationUI
{
    partial class Register
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.phoneNumberTxt = new System.Windows.Forms.TextBox();
            this.confirmPasswordTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.phoneNumberLbl = new System.Windows.Forms.Label();
            this.confirmPasswordLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.invalidFirstName = new System.Windows.Forms.Label();
            this.invalidLastName = new System.Windows.Forms.Label();
            this.invalidEmail = new System.Windows.Forms.Label();
            this.invalidPhoneNumber = new System.Windows.Forms.Label();
            this.invalidPassword = new System.Windows.Forms.Label();
            this.invalidConfirmPassword = new System.Windows.Forms.Label();
            this.mismatchPasswordtxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.firstNameLbl.CausesValidation = false;
            this.firstNameLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstNameLbl.Location = new System.Drawing.Point(219, 59);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(100, 23);
            this.firstNameLbl.TabIndex = 0;
            this.firstNameLbl.Text = "Firstname";
            this.firstNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.firstNameLbl.Click += new System.EventHandler(this.firstNameLbl_Click);
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Location = new System.Drawing.Point(336, 59);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(195, 23);
            this.firstNameTxt.TabIndex = 1;
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lastNameLbl.CausesValidation = false;
            this.lastNameLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lastNameLbl.Location = new System.Drawing.Point(218, 103);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(100, 23);
            this.lastNameLbl.TabIndex = 2;
            this.lastNameLbl.Text = "Lastname";
            this.lastNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(336, 103);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(195, 23);
            this.lastNameTxt.TabIndex = 3;
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(336, 155);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(195, 23);
            this.emailTxt.TabIndex = 4;
            // 
            // phoneNumberTxt
            // 
            this.phoneNumberTxt.Location = new System.Drawing.Point(336, 205);
            this.phoneNumberTxt.Name = "phoneNumberTxt";
            this.phoneNumberTxt.Size = new System.Drawing.Size(195, 23);
            this.phoneNumberTxt.TabIndex = 5;
            // 
            // confirmPasswordTxt
            // 
            this.confirmPasswordTxt.Location = new System.Drawing.Point(336, 304);
            this.confirmPasswordTxt.Name = "confirmPasswordTxt";
            this.confirmPasswordTxt.Size = new System.Drawing.Size(195, 23);
            this.confirmPasswordTxt.TabIndex = 6;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(336, 253);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(195, 23);
            this.passwordTxt.TabIndex = 7;
            // 
            // phoneNumberLbl
            // 
            this.phoneNumberLbl.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.phoneNumberLbl.CausesValidation = false;
            this.phoneNumberLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.phoneNumberLbl.Location = new System.Drawing.Point(219, 205);
            this.phoneNumberLbl.Name = "phoneNumberLbl";
            this.phoneNumberLbl.Size = new System.Drawing.Size(100, 23);
            this.phoneNumberLbl.TabIndex = 8;
            this.phoneNumberLbl.Text = "Phone Number";
            this.phoneNumberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmPasswordLbl
            // 
            this.confirmPasswordLbl.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.confirmPasswordLbl.CausesValidation = false;
            this.confirmPasswordLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmPasswordLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.confirmPasswordLbl.Location = new System.Drawing.Point(218, 303);
            this.confirmPasswordLbl.Name = "confirmPasswordLbl";
            this.confirmPasswordLbl.Size = new System.Drawing.Size(100, 23);
            this.confirmPasswordLbl.TabIndex = 9;
            this.confirmPasswordLbl.Text = "ConfirmPassword";
            this.confirmPasswordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLbl
            // 
            this.passwordLbl.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.passwordLbl.CausesValidation = false;
            this.passwordLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.passwordLbl.Location = new System.Drawing.Point(219, 253);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(100, 23);
            this.passwordLbl.TabIndex = 10;
            this.passwordLbl.Text = "Password";
            this.passwordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailLbl
            // 
            this.emailLbl.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.emailLbl.CausesValidation = false;
            this.emailLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.emailLbl.Location = new System.Drawing.Point(219, 155);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(100, 23);
            this.emailLbl.TabIndex = 11;
            this.emailLbl.Text = "Email";
            this.emailLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(325, 356);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(75, 23);
            this.register.TabIndex = 12;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(406, 395);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(37, 15);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Login";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Already have an account?";
            // 
            // invalidFirstName
            // 
            this.invalidFirstName.AutoSize = true;
            this.invalidFirstName.ForeColor = System.Drawing.Color.Red;
            this.invalidFirstName.Location = new System.Drawing.Point(336, 85);
            this.invalidFirstName.Name = "invalidFirstName";
            this.invalidFirstName.Size = new System.Drawing.Size(114, 15);
            this.invalidFirstName.TabIndex = 15;
            this.invalidFirstName.Text = "Invalid name format";
            this.invalidFirstName.Visible = false;
            // 
            // invalidLastName
            // 
            this.invalidLastName.AutoSize = true;
            this.invalidLastName.ForeColor = System.Drawing.Color.Red;
            this.invalidLastName.Location = new System.Drawing.Point(336, 129);
            this.invalidLastName.Name = "invalidLastName";
            this.invalidLastName.Size = new System.Drawing.Size(114, 15);
            this.invalidLastName.TabIndex = 16;
            this.invalidLastName.Text = "Invalid name format";
            this.invalidLastName.Visible = false;
            // 
            // invalidEmail
            // 
            this.invalidEmail.AutoSize = true;
            this.invalidEmail.ForeColor = System.Drawing.Color.Red;
            this.invalidEmail.Location = new System.Drawing.Point(336, 181);
            this.invalidEmail.Name = "invalidEmail";
            this.invalidEmail.Size = new System.Drawing.Size(113, 15);
            this.invalidEmail.TabIndex = 17;
            this.invalidEmail.Text = "Invalid email format";
            this.invalidEmail.Visible = false;
            // 
            // invalidPhoneNumber
            // 
            this.invalidPhoneNumber.AutoSize = true;
            this.invalidPhoneNumber.ForeColor = System.Drawing.Color.Red;
            this.invalidPhoneNumber.Location = new System.Drawing.Point(336, 231);
            this.invalidPhoneNumber.Name = "invalidPhoneNumber";
            this.invalidPhoneNumber.Size = new System.Drawing.Size(163, 15);
            this.invalidPhoneNumber.TabIndex = 18;
            this.invalidPhoneNumber.Text = "Invalid phone number format";
            this.invalidPhoneNumber.Visible = false;
            // 
            // invalidPassword
            // 
            this.invalidPassword.AutoSize = true;
            this.invalidPassword.ForeColor = System.Drawing.Color.Red;
            this.invalidPassword.Location = new System.Drawing.Point(336, 279);
            this.invalidPassword.Name = "invalidPassword";
            this.invalidPassword.Size = new System.Drawing.Size(134, 15);
            this.invalidPassword.TabIndex = 19;
            this.invalidPassword.Text = "Invalid password format";
            this.invalidPassword.Visible = false;
            // 
            // invalidConfirmPassword
            // 
            this.invalidConfirmPassword.AutoSize = true;
            this.invalidConfirmPassword.ForeColor = System.Drawing.Color.Red;
            this.invalidConfirmPassword.Location = new System.Drawing.Point(336, 329);
            this.invalidConfirmPassword.Name = "invalidConfirmPassword";
            this.invalidConfirmPassword.Size = new System.Drawing.Size(114, 15);
            this.invalidConfirmPassword.TabIndex = 20;
            this.invalidConfirmPassword.Text = "Invalid name format";
            this.invalidConfirmPassword.Visible = false;
            // 
            // mismatchPasswordtxt
            // 
            this.mismatchPasswordtxt.ForeColor = System.Drawing.Color.Red;
            this.mismatchPasswordtxt.Location = new System.Drawing.Point(336, 329);
            this.mismatchPasswordtxt.Name = "mismatchPasswordtxt";
            this.mismatchPasswordtxt.Size = new System.Drawing.Size(135, 15);
            this.mismatchPasswordtxt.TabIndex = 21;
            this.mismatchPasswordtxt.Text = "Incorrect password";
            this.mismatchPasswordtxt.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 749);
            this.Controls.Add(this.mismatchPasswordtxt);
            this.Controls.Add(this.invalidConfirmPassword);
            this.Controls.Add(this.invalidPassword);
            this.Controls.Add(this.invalidPhoneNumber);
            this.Controls.Add(this.invalidEmail);
            this.Controls.Add(this.invalidLastName);
            this.Controls.Add(this.invalidFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.register);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.confirmPasswordLbl);
            this.Controls.Add(this.phoneNumberLbl);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.confirmPasswordTxt);
            this.Controls.Add(this.phoneNumberTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.firstNameTxt);
            this.Controls.Add(this.firstNameLbl);
            this.Name = "Form1";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label firstNameLbl;
        private TextBox firstNameTxt;
        private Label lastNameLbl;
        private TextBox lastNameTxt;
        private TextBox emailTxt;
        private TextBox phoneNumberTxt;
        private TextBox confirmPasswordTxt;
        private TextBox passwordTxt;
        private Label phoneNumberLbl;
        private Label confirmPasswordLbl;
        private Label passwordLbl;
        private Label emailLbl;
        private Button register;
        private LinkLabel linkLabel1;
        private Label label1;
        private Label invalidFirstName;
        private Label invalidLastName;
        private Label invalidEmail;
        private Label invalidPhoneNumber;
        private Label invalidPassword;
        private Label invalidConfirmPassword;
        private Label mismatchPasswordtxt;
    }
}