using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transactions.Data.Interfaces;
using Transactions.Data.Models;

namespace Transactions.Data.Repository
{
    public class CustomerRepository : ITransactionsCustomer
    {
        private readonly AppDBContent appDBContent;

        public CustomerRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Customer> AllCustomers => appDBContent.Customer;
    }
}
