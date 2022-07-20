using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Models
{
    public class Transaction
    {
        private int _id;

        public int Id { get; set; }
        public int BankAccountId { get; set; }
        public string? Description { get; set; }
        public decimal Amount { get; set; }
        public TransactionType TransactionType { get; set; }
        public decimal Balance { get; set; }
        public DateTime CreatedDate { get; set; }


        public Transaction(int bankaccountid, string description, decimal amount, TransactionType transactionType, DateTime dateTime, decimal balance)
        {
            Id = ++_id;
            BankAccountId = bankaccountid;
            Description = description;
            Amount = amount;
            TransactionType = transactionType;
            CreatedDate = dateTime;
            Balance = balance;
        }
    }
}



