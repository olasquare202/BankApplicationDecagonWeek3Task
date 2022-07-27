namespace BankApplicationUI
{
    partial class Deposit
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
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.btnAccountNumber = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblInvalidAmount = new System.Windows.Forms.Label();
            this.lblInvalidAccountNumber = new System.Windows.Forms.Label();
            this.lblAcc = new System.Windows.Forms.Label();
            this.txtAcc = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(74, 124);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(51, 15);
            this.lblDeposit.TabIndex = 0;
            this.lblDeposit.Text = "Amount";
            this.lblDeposit.Visible = false;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(208, 84);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(95, 15);
            this.lblAccountNumber.TabIndex = 0;
            this.lblAccountNumber.Text = "Accoun Number";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(343, 81);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(170, 23);
            this.txtAccountNumber.TabIndex = 1;
            // 
            // btnAccountNumber
            // 
            this.btnAccountNumber.Location = new System.Drawing.Point(552, 84);
            this.btnAccountNumber.Name = "btnAccountNumber";
            this.btnAccountNumber.Size = new System.Drawing.Size(113, 23);
            this.btnAccountNumber.TabIndex = 2;
            this.btnAccountNumber.Text = "Deposit";
            this.btnAccountNumber.UseVisualStyleBackColor = true;
            this.btnAccountNumber.Click += new System.EventHandler(this.btnAccountNumber_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Invalid account number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Deposit Successful";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Go To Menu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(202, 116);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(194, 23);
            this.txtDeposit.TabIndex = 1;
            this.txtDeposit.Visible = false;
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDeposit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeposit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDeposit.Location = new System.Drawing.Point(439, 116);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(92, 37);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Visible = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenu.Location = new System.Drawing.Point(227, 357);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(131, 43);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "Go To Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblInvalidAmount
            // 
            this.lblInvalidAmount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblInvalidAmount.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidAmount.Location = new System.Drawing.Point(183, 226);
            this.lblInvalidAmount.Name = "lblInvalidAmount";
            this.lblInvalidAmount.Size = new System.Drawing.Size(179, 23);
            this.lblInvalidAmount.TabIndex = 9;
            this.lblInvalidAmount.Text = "Invalid Amount";
            this.lblInvalidAmount.Visible = false;
            this.lblInvalidAmount.Click += new System.EventHandler(this.lblInvalidAmount_Click);
            // 
            // lblInvalidAccountNumber
            // 
            this.lblInvalidAccountNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblInvalidAccountNumber.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidAccountNumber.Location = new System.Drawing.Point(162, 141);
            this.lblInvalidAccountNumber.Name = "lblInvalidAccountNumber";
            this.lblInvalidAccountNumber.Size = new System.Drawing.Size(179, 23);
            this.lblInvalidAccountNumber.TabIndex = 10;
            this.lblInvalidAccountNumber.Text = "Account number is not correct";
            this.lblInvalidAccountNumber.Visible = false;
            // 
            // lblAcc
            // 
            this.lblAcc.AutoSize = true;
            this.lblAcc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAcc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAcc.Location = new System.Drawing.Point(56, 120);
            this.lblAcc.Name = "lblAcc";
            this.lblAcc.Size = new System.Drawing.Size(140, 21);
            this.lblAcc.TabIndex = 11;
            this.lblAcc.Text = "Account Number:";
            // 
            // txtAcc
            // 
            this.txtAcc.Location = new System.Drawing.Point(202, 117);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Size = new System.Drawing.Size(194, 23);
            this.txtAcc.TabIndex = 12;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.RosyBrown;
            this.btnEnter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnter.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEnter.Location = new System.Drawing.Point(419, 250);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(92, 30);
            this.btnEnter.TabIndex = 13;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(183, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "MAKE A DEPOSIT";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAmount.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAmount.Location = new System.Drawing.Point(74, 202);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(73, 21);
            this.lblAmount.TabIndex = 15;
            this.lblAmount.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(202, 200);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(194, 23);
            this.txtAmount.TabIndex = 16;
            // 
            // Deposit
            // 
            this.ClientSize = new System.Drawing.Size(637, 519);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtAcc);
            this.Controls.Add(this.lblAcc);
            this.Controls.Add(this.lblInvalidAccountNumber);
            this.Controls.Add(this.lblInvalidAmount);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.lblDeposit);
            this.Name = "Deposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAccountNumber;
        private TextBox txtAccountNumber;
        private Button btnAccountNumber;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label lblDeposit;
        private TextBox txtDeposit;
        private Button btnDeposit;
        private Button btnMenu;
        private Label lblInvalidAmount;
        private Label lblInvalidAccountNumber;
        private Label lblAcc;
        private TextBox txtAcc;
        private Button btnEnter;
        private Label label3;
        private Label lblAmount;
        private TextBox txtAmount;
    }
}