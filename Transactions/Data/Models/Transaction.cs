using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Transactions.Data.Models
{
    public class Transaction
    {
        public int id { set; get; }
        [Name("customer_id")]
        public int customer_id { set; get; }
        [Name("tr_datetime")]
        public string tr_datetime { set; get; }
        [Name("mcc_code")]
        public int mcc_code { set; get; }
        [Name("tr_type")]
        public int tr_type { set; get; }
        [Name("amount")]
        public double amount { set; get; }
        [Name("term_id")]
        public string term_id { set; get; }

        //public virtual Customer Customer { set; get; }

        //public virtual MccCode MccCode { set; get; }

        //public virtual TransactionsType TransactionType { set; get; }

        public string TermPresent(string term_id)
        {
            if (string.IsNullOrEmpty(term_id))
                return "отсутствует";
            return term_id;
        }
    }
}
