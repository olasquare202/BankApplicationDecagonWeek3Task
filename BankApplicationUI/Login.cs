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
    public partial class Login : Form
    {
        public ICustomerService _customerService;
        public  ICustomerService customerService
        {
            get => _customerService ??= new CustomerService();
        }
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isValid = false;
            if (!Validation.IsValidEmail(txtEmail.Text))
            {
                lblInvalidEmail.Visible = true;
                isValid = true;
            }
            else
            {
                lblInvalidEmail.Visible = false;
                
            }
            if (!Validation.IsValidPassword(txtPassword.Text))
            {
                lblInvalidPassword.Visible = true;
                isValid = true;
            }
            else
            {
                lblInvalidPassword.Visible = false;
            }
            if (isValid)
            {

                Customer customer = customerService.Login(txtEmail.Text,txtPassword.Text);
                Menu menu = new Menu(customer);


            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           Register register = new Register();
            this.Hide();
            register.Show();
        }
    }
}



