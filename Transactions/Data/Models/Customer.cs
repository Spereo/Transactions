using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Transactions.Data.Models
{
    public class Customer
    {
        public int id { set; get; }
        [Name("customer_id")]
        public int customer_id { set; get; }
        [Name("gender")]
        public int gender { set; get; }

        //public List<Transaction> transactions { set; get; }
    }
}
