namespace BankApplicationUI
{
    partial class Withdraw
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
            this.lblInvalid = new System.Windows.Forms.Label();
            this.lblWithdraw = new System.Windows.Forms.Label();
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(215, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAKE A WITHDRAW";
            // 
            // lblInvalid
            // 
            this.lblInvalid.AutoSize = true;
            this.lblInvalid.Location = new System.Drawing.Point(256, 245);
            this.lblInvalid.Name = "lblInvalid";
            this.lblInvalid.Size = new System.Drawing.Size(137, 15);
            this.lblInvalid.TabIndex = 1;
            this.lblInvalid.Text = "Invalid Account Number";
            this.lblInvalid.Visible = false;
            // 
            // lblWithdraw
            // 
            this.lblWithdraw.AutoSize = true;
            this.lblWithdraw.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWithdraw.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblWithdraw.Location = new System.Drawing.Point(139, 208);
            this.lblWithdraw.Name = "lblWithdraw";
            this.lblWithdraw.Size = new System.Drawing.Size(135, 21);
            this.lblWithdraw.TabIndex = 2;
            this.lblWithdraw.Text = "Account Number";
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.Location = new System.Drawing.Point(304, 208);
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.Size = new System.Drawing.Size(194, 23);
            this.txtWithdraw.TabIndex = 3;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(551, 206);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(92, 23);
            this.btnWithdraw.TabIndex = 4;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(336, 302);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(131, 23);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "Go To Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click_1);
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.txtWithdraw);
            this.Controls.Add(this.lblWithdraw);
            this.Controls.Add(this.lblInvalid);
            this.Controls.Add(this.label1);
            this.Name = "Withdraw";
            this.Text = "Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblInvalid;
        private Label lblWithdraw;
        private TextBox txtWithdraw;
        private Button btnWithdraw;
        private Button btnMenu;
    }
}