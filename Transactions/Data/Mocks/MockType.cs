using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transactions.Data.Interfaces;
using Transactions.Data.Models;

namespace Transactions.Data.Mocks
{
    public class MockType : ITransactionsType
    {
        public IEnumerable<TransactionsType> AllTypes
        {
            get
            {
                return new List<TransactionsType>
                {
                    new TransactionsType { id = 3200, tr_description = "Плата за предоставление услуг посредством мобильной связи"},
                    new TransactionsType { id = 3210, tr_description = "Плата за предоставление отчета по счету карты почтой"}
                };
            }
        }
    }
}
