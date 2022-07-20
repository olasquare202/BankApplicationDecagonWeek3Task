using BankApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApplication.DataBase;

namespace BankApplication.Services
{
    public class TransactionService : ITransactionService
    {


        private IRepository? _repository;

        public IRepository repository
        {
            get => _repository ??= new Repository();
        }
        public bool SaveTransaction(Transaction transaction)
        {
            return repository.CreateTransaction(transaction);
        }

        public List<Transaction> GetTransactionstByAccountId(int accountId)
        {
            return _repository.GetTransactionstByAccountId(accountId);
        }

    }
}
