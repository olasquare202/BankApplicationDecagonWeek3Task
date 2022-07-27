using BankApplication.Models;
using BankApplication.Services;
using BankApplication.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplicationUI
{
    public partial class Deposit : Form
    {

        private static IBankAccountService _bankAccountService;
        private Customer _customer;

        public static IBankAccountService bankAccountService
        {
            get => _bankAccountService ??= new BankAccountService();
        }
        public Deposit()
        {
            InitializeComponent();
        }

        private void btnAccountNumber_Click(object sender, EventArgs e)
        {
            txtAccountNumber.Text = new string(txtAccountNumber.Text);
            bool isValid = true;
            if (!bankAccountService.VerifyBankAccountByAccountNumber(txtAccountNumber.Text))
            {
                lblAccountNumber.Visible = false;
                IsAccessible = false;
            }
            else
            {
                lblAccountNumber.Visible = true;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(_customer);
            menu.Show();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            string? amount = txtDeposit.Text;
            if (!Validation.IsValidAmount(amount))
            {
                lblInvalidAmount.Visible = true;
            }
            else
            {
                
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var bankAccount = bankAccountService.GetBankAccountByAccountNumber(txtAcc.Text);
            if (bankAccount == null)
            {
                lblInvalidAccountNumber.Visible = true;
            }
            else
            {
                lblAcc.Visible = false;
                txtAcc.Visible = false;
                btnEnter.Visible = false;
                lblDeposit.Visible = true;
                txtDeposit.Visible = true;
                btnDeposit.Visible = true;
                if(bankAccount != null)
                {
                    lblInvalidAccountNumber.Visible = false;
                }
                else
                {
                    lblAcc.Visible = true;
                    txtAcc.Visible = true;
                    btnEnter.Visible=true;
                    lblDeposit.Visible=false;
                    txtDeposit.Visible=false;
                    btnDeposit.Visible=false;
                }
            }
        }

        private void lblInvalidAmount_Click(object sender, EventArgs e)
        {

        }
    }
}


//Console.Write("Enter Account Number: ");
//string? accountNumber = Console.ReadLine();
//if (!bankAccountService.VerifyBankAccountByAccountNumber(accountNumber))
//{
//    Console.WriteLine("Account number does not exist");
//    Console.ReadLine();
//}
//else
//{
//    BankAccount? bankAccount = bankAccountService.GetBankAccountByAccountNumber(accountNumber);
//    while (bankAccount.CustomerId != customer.Id)
//    {
//        Console.WriteLine("Unauthorized to check account balance of another customer");
//        accountNumber = Console.ReadLine();
//        bankAccount = bankAccountService.GetBankAccountByAccountNumber(accountNumber);
//    }
//    Console.Write("Enter amount: ");
//    string amount = Console.ReadLine();
//    while (!Validation.IsValidAmount(amount))
//    {
//        Console.WriteLine("{0} is invalid, Please be reasonable");
//        amount = Console.ReadLine();
//    }
//    if (Convert.ToDecimal(amount) <= 0)
//    {
//        Console.WriteLine("Invalid amount");
//        Console.Read();
//    }
//    bankAccount = bankAccountService.DepositIntoAccount(bankAccount, Convert.ToDecimal(amount));
//    if (bankAccount != null)
//    {
//        Transaction transaction = new Transaction(bankAccount.Id, "Deposit", Convert.ToDecimal(amount), TransactionType.Deposit, DateTime.Now, bankAccount.AccountBalance);
//        transactionService.SaveTransaction(transaction);
//        Console.WriteLine("Transaction successful");
//        Console.WriteLine("\n\nPress Enter to Continue");
//        Console.ReadLine();
//    }
//    else
//    {
//        Console.WriteLine("Transaction failed");
//        Console.WriteLine("\n\nPress Enter to Continue");
//        Console.ReadLine();

//    }
//}
//Menu(customer);
//            }