/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Models
{
    internal class SavingAccount
    {
        public object Transactions { get; private set; }

        public class SavingsAccount : BankInfo, IBankApp
        {
            public object Transactions { get; private set; }
            public decimal Balance { get; private set; }

            public SavingsAccount()
            {

            }
            public SavingsAccount(decimal amount, DateTime date, string description)
                : base()
            {
                DepositFund(amount, date, description);
            }
            
            public void DepositFund(decimal amount, DateTime date, string description)
            {
                if (amount <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(amount), "Amount cannot be 0 or less than N500");
                }
                var transaction = new Transactions(id, bankaccountid, description, amount, dateTime);
                Transactions.Add(transaction);
            }

            public void TransferFund(decimal amount, DateTime date, string description, SavingAccount account)
            {
                if (amount <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(amount), "Amount cannot be less than 1");
                }

                if (Balance - amount <= 1000)
                {
                    throw new InvalidOperationException("Insufficient Fund");
                }

                var savingsTransaction = new Transactions(-amount, date, description);
                var currentTransaction = new Transactions(amount, date, description);

                Transactions.Add(savingsTransaction);
                account.Transactions.Add(currentTransaction);
            }

            public void TransferFund(decimal amount, DateTime date, string description, SavingsAccount account)
            {
                if (amount <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(amount), "Amount cannot be less than 1");
                }

                if (Balance - amount <= 1000)
                {
                    throw new InvalidOperationException("Insufficient Fund");
                }

                var savingsTransaction = new Transactions(-amount, date, description);
                var currentTransaction = new Transactions(amount, date, descripyion);

                Transactions.Add(savingsTransaction);
                account.Transactions.Add(currentTransaction);
            }

            public void WithdrawFund(decimal amount, DateTime date, string description)
            {
                if (amount <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(amount), "Amount cannot be 0 or less than 0");
                }

                if (Balance - amount <= 1000)
                {
                    throw new InvalidOperationException("Insufficient Fund");
                }

                var transaction = new Transactions(-amount, date, description);
                Transactions.Add(transaction);
            }
            public void DisplayTransactionHistory()
            {

            }

            public void WithdrawFund(decimal amount, DateTime date, string description, decimal price)
            {
                throw new NotImplementedException();
            }
        }

    }
}
*/