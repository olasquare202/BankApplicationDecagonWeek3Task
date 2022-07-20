using BankApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.DataBase
{
    public class Repository : IRepository
    {
        private static  List<Customer> _customers = new List<Customer>();
        private static List<BankAccount> _bankAccounts = new List<BankAccount>();
        private static List<Transaction> _transactions = new List<Transaction>();

        public bool CreateCustomer(Customer customer)
        {
            int numberOfCustomer = _customers.Count;
            _customers.Add(customer);
            return _bankAccounts.Count > numberOfCustomer;
        }


        public Customer? GetCustomerById(int id)
        {
            return _customers.Find(x => x.Id == id);
        }

        public Customer? GetCustomerByEmail(string email)
        {
            return _customers.Find(x => x.Email == email);
        }

        public bool CreateBankAccount(BankAccount bankAccount)
        {
            int numberOfBankAccount = _bankAccounts.Count;
            _bankAccounts.Add(bankAccount);
            return _bankAccounts.Count > numberOfBankAccount;
        }


        public BankAccount? GetBankAccountById(int id)
        {
            return _bankAccounts.Find(x => x.CustomerId == id);
        }
        public BankAccount? GetBankAccountByAccountNumber(string accountNumber)
        {
            return _bankAccounts.Find(x => x.AccountNmuber == accountNumber);
        }
        public List<BankAccount> GetAllBankAccountById(int customerId)
        {
            return _bankAccounts.FindAll(x => x.CustomerId == customerId);
        }
        public bool CreateTransaction(Transaction transaction)
        {
            int numberOfTransaction = _transactions.Count;
            _transactions.Add(transaction);
            return _transactions.Count > numberOfTransaction;
        }

        public Transaction? GetTransactionById(int id)
        {
            return _transactions.Find(x => x.Id == id);
        }
        public List<Transaction> GetTransactionstByAccountId(int accountId)
        {
            return _transactions.FindAll(x => x.BankAccountId == accountId);
        }
        public bool UpdateBankAccount(BankAccount bankAccount)
        {
            foreach(var account in _bankAccounts)
            {
                if (account.Equals(bankAccount))
                {
                    bankAccount.AccountBalance = bankAccount.AccountBalance;
                    return true;
                }
            }
            return false;
        }
      
    }

}   
