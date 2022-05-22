using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transactions.Data.Models;

namespace Transactions.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<MccCode> MccCode { get; set; }
        public DbSet<TransactionsType> Type { get; set; }
    }
}
