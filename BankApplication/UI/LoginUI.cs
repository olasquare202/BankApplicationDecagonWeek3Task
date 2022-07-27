using BankApplication.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.UI
{
    public class LoginUI
    {
        public static void Authentication()
        {
            Console.Write("Enter email: ");
            string? email = Console.ReadLine();
            while (!Validation.IsValidEmail(email))
            {
                Console.WriteLine("{0} is not valid! Please be guided", email);
                Console.Write("Enter email: ");
                email = Console.ReadLine();
            }
            Console.Write("Enter password: ");
            string? password = Console.ReadLine();
            while (!Validation.IsValidPassword(password))
            {
                Console.WriteLine("{0} is not valid! Let your password start with Uppercase and alphanumeric with special character", password);
                Console.Write("Enter Password: ");
                password = Console.ReadLine();
            }
        }     
    }
}
