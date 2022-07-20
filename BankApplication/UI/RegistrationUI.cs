using BankApplication.Models;
using BankApplication.Services;
using BankApplication.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.UI
{
    public class RegistrationUI
    {
        private static ICustomerService? _customerService;

        public static ICustomerService customerService
        {
            get => _customerService ??= new CustomerService();
        }
        public static string PhoneNumber { get; private set; }

        public static void Register()
        {
            Console.Write("Enter firstname: ");
            string? firstName = Console.ReadLine();
            while (!Validation.IsValidName(firstName))
            {
                Console.WriteLine("{0} is not valid! First character must be uppercase and letters only", firstName);
                Console.Write("Enter firstname: ");
                firstName = Console.ReadLine();
            }
            Console.Write("Enter lastname: ");
            string? lastName = Console.ReadLine();
            while (!Validation.IsValidName(lastName))
            {
                Console.WriteLine("{0} is not valid! First character must be uppercase and letters only", lastName);
                Console.WriteLine("Enter lastname: ");
                lastName = Console.ReadLine();
            }
            Console.Write("Enter email: ");
            string? email = Console.ReadLine();
            while (!Validation.IsValidEmail(email))
            {
                Console.WriteLine("{0} is not valid! something@gmail.com", email);
                Console.Write("Enter email: ");
                email = Console.ReadLine();
            }

            Console.Write("Enter Phone Number: ");
            string? phone = Console.ReadLine();
            while (!Validation.IsValidPhoneNumber(phone))
            {
                Console.WriteLine("{0} is not valid! Shon wine mi ni?", phone);
                Console.Write("Enter Phone Number: ");
                phone = Console.ReadLine();
            }

            Console.Write("Enter password: ");
            string? password = Console.ReadLine();
            while (!Validation.IsValidPassword(password))
            {
                Console.WriteLine("{0} is not valid! Let your password start with Uppercase and alphanumeric with special character", password);
                Console.Write("Enter Password: ");
                password = Console.ReadLine();
            }
            Console.Write("Enter confirm password: ");
            string? confirmPassword = Console.ReadLine();
            while (!Validation.IsValidPassword(confirmPassword))
            {
                Console.WriteLine("{0} is not valid", confirmPassword);
                Console.Write("Enter Confirm Password: ");
                confirmPassword = Console.ReadLine();
            }
            while (!Validation.IsComfirmedPassword(password, confirmPassword))
            {
                Console.WriteLine("Passord mismatch");
                Console.Write("Enter Confirm Password: ");
                confirmPassword = Console.ReadLine();
            }
            Customer customer = new Customer(firstName, lastName, email, password, phone);
            customerService.Registeration(customer);
            Console.Clear();
            MenuUI.Menu(customer);
            
           
        }
    }
}
