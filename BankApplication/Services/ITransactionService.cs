﻿using BankApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Services
{
    public interface ITransactionService
    {
        bool SaveTransaction(Transaction transaction);
        List<Transaction> GetTransactionstByAccountId(int accountId);
    }
}
