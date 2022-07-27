namespace BankApplicationUI
{
    partial class AccountType
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.amounttxt = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSavings = new System.Windows.Forms.Button();
            this.btnCurrent = new System.Windows.Forms.Button();
            this.lblInitialDeposit = new System.Windows.Forms.Label();
            this.txtInitialDeposit = new System.Windows.Forms.TextBox();
            this.lblSuccessful = new System.Windows.Forms.Label();
            this.btnGoToMenu = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.lblInvalidAmount = new System.Windows.Forms.Label();
            this.lblAcc = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(132, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "What type of account would you like to open ?";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(252, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Savings";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // amounttxt
            // 
            this.amounttxt.Location = new System.Drawing.Point(0, 0);
            this.amounttxt.Name = "amounttxt";
            this.amounttxt.Size = new System.Drawing.Size(100, 23);
            this.amounttxt.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(308, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "CREATE BANK ACCOUNT";
            // 
            // btnSavings
            // 
            this.btnSavings.Location = new System.Drawing.Point(356, 106);
            this.btnSavings.Name = "btnSavings";
            this.btnSavings.Size = new System.Drawing.Size(75, 23);
            this.btnSavings.TabIndex = 1;
            this.btnSavings.Text = "Savings";
            this.btnSavings.UseVisualStyleBackColor = true;
            this.btnSavings.Click += new System.EventHandler(this.btnSavings_Click);
            // 
            // btnCurrent
            // 
            this.btnCurrent.Location = new System.Drawing.Point(356, 239);
            this.btnCurrent.Name = "btnCurrent";
            this.btnCurrent.Size = new System.Drawing.Size(75, 23);
            this.btnCurrent.TabIndex = 2;
            this.btnCurrent.Text = "Current";
            this.btnCurrent.UseVisualStyleBackColor = true;
            this.btnCurrent.Click += new System.EventHandler(this.btnCurrent_Click);
            // 
            // lblInitialDeposit
            // 
            this.lblInitialDeposit.AutoSize = true;
            this.lblInitialDeposit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInitialDeposit.ForeColor = System.Drawing.Color.Blue;
            this.lblInitialDeposit.Location = new System.Drawing.Point(196, 148);
            this.lblInitialDeposit.Name = "lblInitialDeposit";
            this.lblInitialDeposit.Size = new System.Drawing.Size(111, 21);
            this.lblInitialDeposit.TabIndex = 3;
            this.lblInitialDeposit.Text = "Initial Deposit";
            this.lblInitialDeposit.Visible = false;
            // 
            // txtInitialDeposit
            // 
            this.txtInitialDeposit.Location = new System.Drawing.Point(334, 149);
            this.txtInitialDeposit.Name = "txtInitialDeposit";
            this.txtInitialDeposit.Size = new System.Drawing.Size(146, 23);
            this.txtInitialDeposit.TabIndex = 4;
            this.txtInitialDeposit.Visible = false;
            // 
            // lblSuccessful
            // 
            this.lblSuccessful.AutoSize = true;
            this.lblSuccessful.Location = new System.Drawing.Point(248, 184);
            this.lblSuccessful.Name = "lblSuccessful";
            this.lblSuccessful.Size = new System.Drawing.Size(183, 15);
            this.lblSuccessful.TabIndex = 5;
            this.lblSuccessful.Text = "Account was successfully created";
            this.lblSuccessful.Visible = false;
            // 
            // btnGoToMenu
            // 
            this.btnGoToMenu.Location = new System.Drawing.Point(334, 340);
            this.btnGoToMenu.Name = "btnGoToMenu";
            this.btnGoToMenu.Size = new System.Drawing.Size(112, 23);
            this.btnGoToMenu.TabIndex = 6;
            this.btnGoToMenu.Text = "Go To Menu";
            this.btnGoToMenu.UseVisualStyleBackColor = true;
            this.btnGoToMenu.Click += new System.EventHandler(this.btnGoToMenu_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.AutoEllipsis = true;
            this.btnDeposit.Location = new System.Drawing.Point(496, 148);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 7;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Visible = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // lblInvalidAmount
            // 
            this.lblInvalidAmount.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidAmount.Location = new System.Drawing.Point(252, 239);
            this.lblInvalidAmount.Name = "lblInvalidAmount";
            this.lblInvalidAmount.Size = new System.Drawing.Size(179, 23);
            this.lblInvalidAmount.TabIndex = 8;
            this.lblInvalidAmount.Text = "Invalid Amount";
            this.lblInvalidAmount.Visible = false;
            // 
            // lblAcc
            // 
            this.lblAcc.AutoSize = true;
            this.lblAcc.Location = new System.Drawing.Point(256, 207);
            this.lblAcc.Name = "lblAcc";
            this.lblAcc.Size = new System.Drawing.Size(103, 15);
            this.lblAcc.TabIndex = 9;
            this.lblAcc.Text = "Account number: ";
            this.lblAcc.Visible = false;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(374, 207);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(38, 15);
            this.lblAccountNumber.TabIndex = 10;
            this.lblAccountNumber.Text = "label7";
            this.lblAccountNumber.Visible = false;
            // 
            // AccountType
            // 
            this.ClientSize = new System.Drawing.Size(822, 461);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.lblAcc);
            this.Controls.Add(this.lblInvalidAmount);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnGoToMenu);
            this.Controls.Add(this.lblSuccessful);
            this.Controls.Add(this.txtInitialDeposit);
            this.Controls.Add(this.lblInitialDeposit);
            this.Controls.Add(this.btnCurrent);
            this.Controls.Add(this.btnSavings);
            this.Controls.Add(this.label5);
            this.Name = "AccountType";
            this.Load += new System.EventHandler(this.AccountType_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private TextBox amounttxt;
        private Button button3;
        private Label label4;
        private Label label5;
        private Button btnSavings;
        private Button btnCurrent;
        private Label lblInitialDeposit;
        private TextBox txtInitialDeposit;
        private Label lblSuccessful;
        private Button btnGoToMenu;
        private Button btnDeposit;
        private Label lblInvalidAmount;
        private Label lblAcc;
        private Label lblAccountNumber;
    }
}