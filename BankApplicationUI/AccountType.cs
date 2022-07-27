using BankApplication.Models;
using BankApplication.Services;
using BankApplication.Utilities;

namespace BankApplicationUI
{
    public partial class AccountType : Form
    {
        private readonly Customer _customer;

        private static IBankAccountService _bankAccountService;

        public static IBankAccountService bankAccountService
        {
            get => _bankAccountService ??= new BankAccountService();
        }
        private static ITransactionService? _transactionService;


        public static ITransactionService transactionService
        {
            get => _transactionService ??= new TransactionService();
        }
        private int _id;
        private string _accountNumber;
        private AccountTypes _accountType;
        public AccountType(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
        }
        private void AccountType_Load(object sender, EventArgs e)
        {
            string accountNumber = AccountNumberGenerator.AccountGenerator();
            BankAccount bankAccount = new BankAccount(_customer.Id, accountNumber, AccountTypes.Savings);
        }

        private void btnAccountType_Click(object sender, EventArgs e)
        {

        }

        private void btnSavings_Click(object sender, EventArgs e)
        {
            lblInitialDeposit.Visible = true;
            txtInitialDeposit.Visible = true;
            btnDeposit.Visible = true;
            btnCurrent.Visible = btnSavings.Visible = false;
            _accountType = AccountTypes.Savings;
        }

        private void AccountType_Load_1(object sender, EventArgs e)
        {

        }

        private void btnCurrent_Click(object sender, EventArgs e)
        {
            lblInitialDeposit.Visible = true;
            txtInitialDeposit.Visible = true;
            btnDeposit.Visible = true;
            btnCurrent.Visible = btnSavings.Visible = false;
            _accountType = AccountTypes.Current;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            string accountNumber = AccountNumberGenerator.AccountGenerator();
            BankAccount bankAccount = new BankAccount(_customer.Id, accountNumber, _accountType);

            string? amount = txtInitialDeposit.Text;
            if (!Validation.IsValidAmount(amount))
            {
                lblInvalidAmount.Visible = true;
            }
            else
            {
                bankAccount.AccountBalance = Convert.ToDecimal(amount);
                lblSuccessful.Visible = true;
                btnDeposit.Visible = false;
                txtInitialDeposit.Visible = false;
                lblInitialDeposit.Visible = false;
                lblAccountNumber.Text = accountNumber;
                lblAcc.Visible = true;
                lblAccountNumber.Visible = true;
                bankAccountService.CreateBankAccount(bankAccount);
                var transaction = new BankApplication.Models.Transaction(bankAccount.Id, "Initial Deposit", bankAccount.AccountBalance, TransactionType.Deposit, DateTime.Now, bankAccount.AccountBalance);
                bool successful = transactionService.SaveTransaction(transaction);
            }
        }

        private void btnGoToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(_customer);
            menu.Show();
        }
    }
}



