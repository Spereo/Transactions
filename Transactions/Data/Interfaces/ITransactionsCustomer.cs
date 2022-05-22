using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transactions.Data.Models;

namespace Transactions.Data.Interfaces
{
    public interface ITransactionsCustomer
    {
        IEnumerable<Customer> AllCustomers { get;  }
    }
}
