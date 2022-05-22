using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transactions.Data.Interfaces;
using Transactions.Data.Models;

namespace Transactions.Data.Mocks
{
    public class MockTransaction : IAllTransactions
    {
        private readonly ITransactionsCustomer _transactionsCustomer = new MockCustomer();
        private readonly ITransactionsMccCode _transactionsMccCode = new MockMccCode();
        private readonly ITransactionsType _transactionsType = new MockType();

        public IEnumerable<Transaction> Transactions
        {
            get
            {
                return new List<Transaction>
                {
                    new Transaction { customer_id = 39026145, tr_datetime = "0 10:23:26", mcc_code = 4814, tr_type = 3210, amount = -2245.92, term_id = "111"/*, Customer = _transactionsCustomer.AllCustomers.First(), MccCode = _transactionsMccCode.AllMccCodes.First(), TransactionType = _transactionsType.AllTypes.First()*/},
                    new Transaction { customer_id = 39026146, tr_datetime = "1 12:54:37", mcc_code = 4815, tr_type = 3200, amount = -500.69, term_id = "112"/*, Customer = _transactionsCustomer.AllCustomers.Last(), MccCode = _transactionsMccCode.AllMccCodes.Last(), TransactionType = _transactionsType.AllTypes.Last()*/}
                };
            }
        }

        public IEnumerable<Transaction> getFullfilledTransactions { get; set; }
    }
}
