using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transactions.Data.Interfaces;
using Transactions.Data.Models;

namespace Transactions.Data.Mocks
{
    public class MockMccCode : ITransactionsMccCode
    {
        public IEnumerable<MccCode> AllMccCodes
        {
            get
            {
                return new List<MccCode>
                {
                    new MccCode { id = 742, mcc_description = "Ветеринарные услуги"},
                    new MccCode { id = 1711, mcc_description = "Генеральные подрядчики по вентиляции, теплоснабжению, и водопроводу"}
                };
            }
        }
    }
}
