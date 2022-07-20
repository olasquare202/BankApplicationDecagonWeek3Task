using BankApplication.Models;

namespace BankApplication.DataBase
{
    public interface IRepository
    {
        bool CreateCustomer(Customer customer);
        Customer? GetCustomerById(int id);
        Customer? GetCustomerByEmail(string email);
        bool CreateBankAccount(BankAccount bankAccount);
        BankAccount? GetBankAccountById(int id);
        BankAccount? GetBankAccountByAccountNumber(string accountNumber);
        bool CreateTransaction(Transaction transaction);
        Transaction? GetTransactionById(int id);
        bool UpdateBankAccount(BankAccount bankAccount);
        List<BankAccount> GetAllBankAccountById(int customerId);
        List<Transaction> GetTransactionstByAccountId(int accountId);
    }
}