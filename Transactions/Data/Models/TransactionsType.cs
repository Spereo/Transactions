using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Transactions.Data.Models
{
    public class TransactionsType
    {
        public int id { set; get; }
        [Name("tr_type")]
        public int tr_type { set; get; }
        [Name("tr_description")]
        public string tr_description { set; get; }

        //public List<Transaction> transactions { set; get; }
    }
}
