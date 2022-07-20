using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.UI
{
    public class IndexUI
    {
        public static void Header()
        {
            Console.WriteLine();
            Console.WriteLine("**************************************** WELCOME TO SOLUTION BANK PLC ****************************************");
        }
        public static void Run()
        {
            Header();
            Console.WriteLine();
            Console.WriteLine("Would you like to Register with us? Kindly Press 1");
            Console.WriteLine("Would you like to Login into your account? Kindly Press 2");
            string option = Console.ReadLine();
            if(option == "1")
            {
                Console.Clear();
                Header();
                RegistrationUI.Register();
            }
            else if (option == "2")
            {
                Console.Clear();
                Header();
                LoginUI.Authentication();
            }
        }
    }
}
