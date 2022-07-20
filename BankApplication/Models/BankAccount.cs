using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Models
{
    public class BankAccount
    {
        public bool IsActive { get; set; }
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string AccountNmuber { get; set; }
        public decimal AccountBalance { get; set; }
        public AccountType AccountType { get; set; }
        public static string AccountNumber { get; internal set; }

        public static int _id;
        public BankAccount(int customerId, string accountNumber, AccountType accountType)
        {
            Id = ++_id;
            IsActive = true;
            CustomerId = customerId;
            AccountNmuber = accountNumber;
            AccountType = accountType;
        }

    }
}
