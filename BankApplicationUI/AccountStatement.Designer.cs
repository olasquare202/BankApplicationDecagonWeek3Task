namespace BankApplicationUI
{
    partial class AccountStatement
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
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnGoToMenu = new System.Windows.Forms.Button();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(134, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRINT YOUR ACCOUNT STATEMENT";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAccountNumber.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAccountNumber.Location = new System.Drawing.Point(143, 115);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(140, 21);
            this.lblAccountNumber.TabIndex = 1;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(361, 218);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 29);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnGoToMenu
            // 
            this.btnGoToMenu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGoToMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGoToMenu.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnGoToMenu.Location = new System.Drawing.Point(340, 306);
            this.btnGoToMenu.Name = "btnGoToMenu";
            this.btnGoToMenu.Size = new System.Drawing.Size(119, 32);
            this.btnGoToMenu.TabIndex = 3;
            this.btnGoToMenu.Text = "Go To Menu";
            this.btnGoToMenu.UseVisualStyleBackColor = false;
            this.btnGoToMenu.Click += new System.EventHandler(this.btnGoToMenu_Click);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(306, 113);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(273, 23);
            this.txtAccountNumber.TabIndex = 4;
            this.txtAccountNumber.TextChanged += new System.EventHandler(this.txtAccountNumber_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(262, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Invalid Account Number";
            this.label3.Visible = false;
            // 
            // AccountStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.btnGoToMenu);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.label1);
            this.Name = "AccountStatement";
            this.Text = "AccountStatement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblAccountNumber;
        private Button btnSubmit;
        private Button btnGoToMenu;
        private TextBox txtAccountNumber;
        private Label label3;
    }
}