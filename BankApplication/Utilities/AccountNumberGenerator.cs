using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Utilities
{
    public class AccountNumberGenerator
    {
        public static string AccountGenerator()
        {
            var random = new Random();
            string accountNumber = string.Empty;
            for (int i = 0; i < 10; i++)
                accountNumber = String.Concat(accountNumber, random.Next(10).ToString());
            return accountNumber;
        }
    }
}
