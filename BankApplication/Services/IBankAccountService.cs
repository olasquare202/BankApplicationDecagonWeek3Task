using BankApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Services
{
    public interface IBankAccountService
    {
        public bool CreateBankAccount(BankAccount account);
        BankAccount DepositIntoAccount(BankAccount bankAccount, decimal amount);

        BankAccount WithdrawFromBankAccount(BankAccount bankAccount, decimal amount);
        bool VerifyBankAccountByAccountNumber(string accountNumber);
        public BankAccount? GetBankAccountByAccountNumber(string accountNumber);
         bool VerifyAccountBelongToCustomer(string accountNumber, int customerId);

        bool BankAccountTransfer(BankAccount sender, BankAccount receiver, decimal amount);
        List<BankAccount> GetAllBankAccountByCustomerId(int customerId);
    }
}
