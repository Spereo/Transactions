using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transactions.Data.Interfaces;
using Transactions.Data.Models;

namespace Transactions.Data.Repository
{
    public class MccCodeRepository : ITransactionsMccCode
    {
        private readonly AppDBContent appDBContent;

        public MccCodeRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<MccCode> AllMccCodes => appDBContent.MccCode;
    }
}
