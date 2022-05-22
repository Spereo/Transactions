using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Transactions.Data.Models
{
    public class MccCode
    {
        public int id { set; get; }
        [Name("mcc_code")]
        public int mcc_code { set; get; }
        [Name("mcc_description")]
        public string mcc_description { set; get; }

        //public List<Transaction> transactions { set; get; }
    }
}
