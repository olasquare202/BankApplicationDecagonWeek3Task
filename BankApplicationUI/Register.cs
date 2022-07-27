using BankApplication.Models;
using BankApplication.Services;
using BankApplication.Utilities;

namespace BankApplicationUI
{
    public partial class Register : Form
    {
        private static ICustomerService? _customerService;

        public static ICustomerService customerService
        {
            get => _customerService ??= new CustomerService();
        }
        public Register()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            bool isValid = false;
            Customer customer = null;
            if (!Validation.IsValidName(firstNameTxt.Text))
            {
                invalidFirstName.Visible = true;
            }
            else
            {
                invalidFirstName.Visible = false;
                isValid = true;
            }
            if (!Validation.IsValidName(lastNameTxt.Text))
            {
                invalidLastName.Visible = true;
            }
            else
            {
                invalidLastName.Visible = false;
                isValid = true;
            }
            if (!Validation.IsValidEmail(emailTxt.Text))
            {
                invalidEmail.Visible = true;
            }
            else
            {
                invalidEmail.Visible = false;
                isValid = true;
            }
            if (!Validation.IsValidPhoneNumber(phoneNumberTxt.Text))
            {
                invalidPhoneNumber.Visible = true;
            }
            else
            {
                isValid = true;
            }
            if (!Validation.IsValidPassword(passwordTxt.Text))
            {
                invalidEmail.Visible = false;
                invalidPassword.Visible = true;
            }
            else
            {
                isValid = true;
            }
            if (!Validation.IsValidPassword(confirmPasswordTxt.Text))
            {
                invalidConfirmPassword.Visible = true;
            }
            if(passwordTxt.Text != confirmPasswordTxt.Text)
            {
                mismatchPasswordtxt.Visible = true;
            }
            else
            {
                isValid = true;
            }
            if (isValid)
            {
                customer = new Customer(firstNameLbl.Text,lastNameLbl.Text,emailLbl.Text,passwordLbl.Text,phoneNumberLbl.Text);
                customerService.Registeration(customer);

            }
            Menu menu = new Menu(customer);
           
            this.Hide();
            menu.Show();

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void firstNameLbl_Click(object sender, EventArgs e)
        {

        }
    }
}