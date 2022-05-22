using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transactions.Data.Interfaces;
using Transactions.Data.Models;

namespace Transactions.Data.Repository
{
    public class TypeRepository : ITransactionsType
    {
        private readonly AppDBContent appDBContent;

        public TypeRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<TransactionsType> AllTypes => appDBContent.Type;
    }
}
