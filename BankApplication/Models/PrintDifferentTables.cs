/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Models
{


    public static class PrintDifferentTables
    {
        public static object PrintTables { get; private set; }

        public static void DisplayDifferentTables(List<AccountType> Savings, List<AccountType> Current)
        {
            string[] yesOrNo = { "yes", "no" };
            string AccountNumber = string.Empty;
            string AccountType = string.Empty;

            while (true)
            {
                Options2();
                var input = Console.ReadLine();

                if (input == "0")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    PrintTables.AccountType(Savings, Current);
                    Console.ResetColor();
                }

                if (input == "1")
                {
                    Console.Write("Enter Your Account Number:  ");
                    AccountNumber = Console.ReadLine().Trim();

                    Console.WriteLine("Select Account Type:  ");
                    Console.WriteLine("1 - Savings");
                    Console.WriteLine("2 - Current");
                    AccountType = Console.ReadLine().Trim();

                    if (AccountType == "1")
                    {
                        foreach (var account in Savings)
                        {
                            if (BankAccount.AccountNumber == AccountNumber)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                PrintTables.bankAccount(Savings);
                                Console.ResetColor();
                            }
                        }
                    }

                    if (AccountType == "2")
                    {
                        foreach (var account in Current)
                        {
                            if (BankAccount.AccountNumber == AccountNumber)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                PrintTables.AccountDetails(Current);
                                Console.ResetColor();
                            }
                        }
                    }
                }

                if (input == "2")
                {
                    Environment.Exit(0);
                }

                var decision = string.Empty;
                while (true)
                {
                    Console.WriteLine("Enter \"yes\" to perform another operation or \"no\" to continue: ");
                    decision = Console.ReadLine().Trim().ToLower();

                    if (yesOrNo.Contains(decision))
                        break;
                }

                if (decision == "yes")
                    continue;

                if (decision == "no")
                    break;
            }
        }

        private static void Options2()
        {
            StringBuilder options = new StringBuilder();

            options.Append("What operation would you like perform?")
                .AppendLine()
                .Append("Enter 0 to Print Account Details Table")
                .AppendLine()
                .Append("Enter 1 to Print Transaction History Table")
                .AppendLine()
                .Append("Enter 2 to Exit")
                .AppendLine();

            Console.WriteLine(options);
        }
    }
}
}
*/