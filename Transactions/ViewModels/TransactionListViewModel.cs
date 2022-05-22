using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transactions.Data.Models;

namespace Transactions.ViewModels
{
    public class TransactionListViewModel
    {
        public IEnumerable<Transaction> allTransactions { get; set; }

        public string currCategory { get; set; }
    }
}
