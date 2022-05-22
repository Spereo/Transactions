using CsvHelper.Configuration;
using System.Globalization;
using Transactions.Data.Models;

namespace Transactions.InteractionCSV.Maps
{
    public class TransactionsTypeMap : ClassMap<TransactionsType>
    {
        public TransactionsTypeMap()
        {
            AutoMap(CultureInfo.InvariantCulture);
            Map(m => m.id).Ignore();
        }
    }
}
