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
    public partial class Transfer : Form
    {
        private IBankAccountService _bankAccountService;
        private Customer _customer;
        public IBankAccountService BankAccountService
        {
            get => _bankAccountService ??= new BankAccountService();
        }

       // private Customer _customer;
        public Transfer(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
        }

        private void btnGoToMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(_customer);
            menu.Show();
        }
    }
}

//public partial class AccountStatement : Form
//{
//    private IBankAccountService _bankAccountService;
//    private BankApplication.Models.Customer _customer;
//    public IBankAccountService BankAccountService
//    {
//        get => _bankAccountService ??= new BankAccountService();
//    }
//    public AccountStatement()
//    {
//        InitializeComponent();
//    }

//    private void btnGoToMenu_Click(object sender, EventArgs e)
//    {
//        Menu menu = new Menu(_customer);
//        menu.Show();
//    }

    //private void txtAccountNumber_TextChanged(object sender, EventArgs e)
    //{

    //}