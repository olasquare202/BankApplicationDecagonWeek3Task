using BankApplication.Models;
using System;
using BankApplication.DataBase;

namespace BankApplication.Services
{
    public class BankAccountService : IBankAccountService
    {

        private IRepository? _repository;
        private ITransactionService? _transactionService;
        
        public IRepository repository
        {
            get => _repository ??= new Repository();
        }

        public ITransactionService transactionService
        {
            get => _transactionService ??= new TransactionService();
        }
        public bool CreateBankAccount(BankAccount account)
        {
            if (account == null)
            {
                return false;
            }

            return repository.CreateBankAccount(account);
        }

        public BankAccount DepositIntoAccount(BankAccount bankAccount, decimal amount)
        {
            
           if(amount > 0)
            {
                bankAccount.AccountBalance += amount;
                if (repository.UpdateBankAccount(bankAccount))
                {
                    return bankAccount;
                }
            }
           return bankAccount = null;
        }

        public BankAccount WithdrawFromBankAccount(BankAccount bankAccount, decimal amount)
        {
            
            if (bankAccount.AccountType == AccountType.Current)
            {
                if (amount > 0 && bankAccount.AccountBalance - amount > 1000)
                {
                    bankAccount.AccountBalance -= amount;
                     repository.UpdateBankAccount(bankAccount);
                    return bankAccount; 
                }
            }
            else
            {
                if (amount > 0 && bankAccount.AccountBalance - amount >= 0)
                {
                    bankAccount.AccountBalance -= amount;
                     repository.UpdateBankAccount(bankAccount);
                    return bankAccount;
                }
            }
            return bankAccount = null;
        }


        public bool VerifyBankAccountByAccountNumber(string accountNumber)
        {
            BankAccount? account = repository.GetBankAccountByAccountNumber(accountNumber);
            return account != null;
        }

        public BankAccount? GetBankAccountByAccountNumber(string accountNumber)
        {

            BankAccount? account = repository.GetBankAccountByAccountNumber(accountNumber);
            return account;
        }
        public List<BankAccount> GetAllBankAccountByCustomerId(int customerId)
        {
            return repository.GetAllBankAccountById(customerId);
        }
        public bool VerifyAccountBelongToCustomer(string accountNumber, int customerId)
        {
            BankAccount? account = repository.GetBankAccountByAccountNumber(accountNumber);

            return account.CustomerId == customerId;
        }

         public bool BankAccountTransfer(BankAccount sender, BankAccount receiver, decimal amount)
        {
            DepositIntoAccount(receiver, amount);
            WithdrawFromBankAccount(sender, amount);
            if(WithdrawFromBankAccount != null)
            {
                return true;
            }
            return false;
        }
    }
}
