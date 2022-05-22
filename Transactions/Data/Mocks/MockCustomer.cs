using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transactions.Data.Interfaces;
using Transactions.Data.Models;

namespace Transactions.Data.Mocks
{
    public class MockCustomer : ITransactionsCustomer
    {
        public IEnumerable<Customer> AllCustomers
        {
            get
            {
                return new List<Customer>
                {
                    new Customer { id = 1, gender = 0},
                    new Customer { id = 2, gender = 0}
                };
            }
        }
    }
}
