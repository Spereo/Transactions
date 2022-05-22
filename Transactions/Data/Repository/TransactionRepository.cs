using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transactions.Data.Interfaces;
using Transactions.Data.Models;

namespace Transactions.Data.Repository
{
    public class TransactionRepository : IAllTransactions
    {
        private readonly AppDBContent appDBContent;

        public TransactionRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Transaction> Transactions => appDBContent.Transaction/*.Include(c => c.Customer)*/;

        public IEnumerable<Transaction> getFullfilledTransactions => appDBContent.Transaction/*.Include(c => c.Customer)*/;
    }
}
