using BankApplication.Models;
using BankApplication.Services;
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
    public partial class CheckBalance : Form
    {
        private IBankAccountService _accountService;
        private Customer _customer;
        public IBankAccountService AccountService
        {
            get => _accountService ??= new BankAccountService();
        }
        public CheckBalance()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var bankAccount = AccountService.GetBankAccountByAccountNumber(textAccountNumber.Text);
            if (bankAccount == null)
            {
                lblInvalidAccountNumber.Visible = true;
            }
            else
            {
                lblAccountNumber.Visible = false;;
                if (bankAccount != null)
                {
                    lblInvalidAccountNumber.Visible = false;
                }
                else
                {
                    lblAccountNumber.Visible = true;
                    textAccountNumber.Visible = true;
                    btnEnter.Visible = true;
                }
            }
        }

        private void btnGoToMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(_customer);
            menu.Show();
        }
    }
}

//private static IBankAccountService _bankAccountService;
//private Customer _customer;