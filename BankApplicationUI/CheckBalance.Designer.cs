namespace BankApplicationUI
{
    partial class CheckBalance
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
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.textAccountNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnGoToMenu = new System.Windows.Forms.Button();
            this.lblInvalidAccountNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAccountNumber.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAccountNumber.Location = new System.Drawing.Point(88, 109);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(140, 21);
            this.lblAccountNumber.TabIndex = 0;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // textAccountNumber
            // 
            this.textAccountNumber.Location = new System.Drawing.Point(232, 109);
            this.textAccountNumber.Name = "textAccountNumber";
            this.textAccountNumber.Size = new System.Drawing.Size(246, 23);
            this.textAccountNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(188, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "CHECK ACCOUNT BALANCE";
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEnter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnter.Location = new System.Drawing.Point(503, 106);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(90, 40);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnGoToMenu
            // 
            this.btnGoToMenu.BackColor = System.Drawing.Color.LightCoral;
            this.btnGoToMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGoToMenu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnGoToMenu.Location = new System.Drawing.Point(298, 235);
            this.btnGoToMenu.Name = "btnGoToMenu";
            this.btnGoToMenu.Size = new System.Drawing.Size(149, 42);
            this.btnGoToMenu.TabIndex = 4;
            this.btnGoToMenu.Text = "Go To Menu";
            this.btnGoToMenu.UseVisualStyleBackColor = false;
            this.btnGoToMenu.Click += new System.EventHandler(this.btnGoToMenu_Click);
            // 
            // lblInvalidAccountNumber
            // 
            this.lblInvalidAccountNumber.AutoSize = true;
            this.lblInvalidAccountNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblInvalidAccountNumber.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidAccountNumber.Location = new System.Drawing.Point(221, 139);
            this.lblInvalidAccountNumber.Name = "lblInvalidAccountNumber";
            this.lblInvalidAccountNumber.Size = new System.Drawing.Size(160, 20);
            this.lblInvalidAccountNumber.TabIndex = 5;
            this.lblInvalidAccountNumber.Text = "Invalid account number";
            // 
            // CheckBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInvalidAccountNumber);
            this.Controls.Add(this.btnGoToMenu);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textAccountNumber);
            this.Controls.Add(this.lblAccountNumber);
            this.Name = "CheckBalance";
            this.Text = "CheckBalance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAccountNumber;
        private TextBox textAccountNumber;
        private Label label2;
        private Button btnEnter;
        private Button btnGoToMenu;
        private Label lblInvalidAccountNumber;
    }
}