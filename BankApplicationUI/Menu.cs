using BankApplication.Models;
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
    public partial class Menu : Form
    {
        private readonly Customer _customer;
        public Menu(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountType accountType = new AccountType(_customer);
            accountType.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Buttons_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            deposit.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckBalance checkBalance = new CheckBalance();
            checkBalance.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw(_customer);
            withdraw.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Transfer transfer = new Transfer(_customer);
            transfer.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
