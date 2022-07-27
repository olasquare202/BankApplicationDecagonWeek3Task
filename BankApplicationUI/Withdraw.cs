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
    public partial class Withdraw : Form
    {
        private static IBankAccountService _bankAccountService;
        private Customer _customer;

        public static IBankAccountService bankAccountService
        {
            get => _bankAccountService ??= new BankAccountService();
        }
        //public readonly IServiceProvider ServiceProvider;

        public Withdraw(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
        }

        private async  void btnWithdraw_Click(object sender, EventArgs e)
        {
            if(!_bankAccountService.VerifyBankAccountByAccountNumber(txtWithdraw.Text))
            {
                lblInvalid.Visible = true;
            }
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            Menu menu = new Menu(_customer);
            menu.Show();
        }
    }
}
