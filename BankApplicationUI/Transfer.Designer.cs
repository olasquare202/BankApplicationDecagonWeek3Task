namespace BankApplicationUI
{
    partial class Transfer
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
            this.lblOwnerAccountNumber = new System.Windows.Forms.Label();
            this.lblReceiverAccountNumber = new System.Windows.Forms.Label();
            this.txtOwnerAccountNumber = new System.Windows.Forms.TextBox();
            this.txtReceiverAccountNumber = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnGoToMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(228, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAKE A TRANSFER";
            // 
            // lblOwnerAccountNumber
            // 
            this.lblOwnerAccountNumber.AutoSize = true;
            this.lblOwnerAccountNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOwnerAccountNumber.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblOwnerAccountNumber.Location = new System.Drawing.Point(65, 120);
            this.lblOwnerAccountNumber.Name = "lblOwnerAccountNumber";
            this.lblOwnerAccountNumber.Size = new System.Drawing.Size(220, 25);
            this.lblOwnerAccountNumber.TabIndex = 1;
            this.lblOwnerAccountNumber.Text = "Owner Account Number";
            // 
            // lblReceiverAccountNumber
            // 
            this.lblReceiverAccountNumber.AutoSize = true;
            this.lblReceiverAccountNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReceiverAccountNumber.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblReceiverAccountNumber.Location = new System.Drawing.Point(49, 202);
            this.lblReceiverAccountNumber.Name = "lblReceiverAccountNumber";
            this.lblReceiverAccountNumber.Size = new System.Drawing.Size(236, 25);
            this.lblReceiverAccountNumber.TabIndex = 2;
            this.lblReceiverAccountNumber.Text = "Receiver Account Number";
            // 
            // txtOwnerAccountNumber
            // 
            this.txtOwnerAccountNumber.Location = new System.Drawing.Point(300, 120);
            this.txtOwnerAccountNumber.Name = "txtOwnerAccountNumber";
            this.txtOwnerAccountNumber.Size = new System.Drawing.Size(235, 23);
            this.txtOwnerAccountNumber.TabIndex = 3;
            // 
            // txtReceiverAccountNumber
            // 
            this.txtReceiverAccountNumber.Location = new System.Drawing.Point(300, 202);
            this.txtReceiverAccountNumber.Name = "txtReceiverAccountNumber";
            this.txtReceiverAccountNumber.Size = new System.Drawing.Size(235, 23);
            this.txtReceiverAccountNumber.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.ForeColor = System.Drawing.Color.Red;
            this.btnSubmit.Location = new System.Drawing.Point(372, 280);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 34);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // btnGoToMenu
            // 
            this.btnGoToMenu.BackColor = System.Drawing.Color.RosyBrown;
            this.btnGoToMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGoToMenu.ForeColor = System.Drawing.Color.Black;
            this.btnGoToMenu.Location = new System.Drawing.Point(357, 356);
            this.btnGoToMenu.Name = "btnGoToMenu";
            this.btnGoToMenu.Size = new System.Drawing.Size(133, 33);
            this.btnGoToMenu.TabIndex = 6;
            this.btnGoToMenu.Text = "Go To Menu";
            this.btnGoToMenu.UseVisualStyleBackColor = false;
            this.btnGoToMenu.Click += new System.EventHandler(this.btnGoToMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(248, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Invalid Account Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(289, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Invalid Account Number";
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGoToMenu);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtReceiverAccountNumber);
            this.Controls.Add(this.txtOwnerAccountNumber);
            this.Controls.Add(this.lblReceiverAccountNumber);
            this.Controls.Add(this.lblOwnerAccountNumber);
            this.Controls.Add(this.label1);
            this.Name = "Transfer";
            this.Text = "Transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblOwnerAccountNumber;
        private Label lblReceiverAccountNumber;
        private TextBox txtOwnerAccountNumber;
        private TextBox txtReceiverAccountNumber;
        private Button btnSubmit;
        private Button btnGoToMenu;
        private Label label2;
        private Label label4;
    }
}