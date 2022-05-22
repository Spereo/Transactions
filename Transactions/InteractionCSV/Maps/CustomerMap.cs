using CsvHelper.Configuration;
using System.Globalization;
using Transactions.Data.Models;

namespace Transactions.InteractionCSV.Maps
{
    public class CustomerMap : ClassMap<Customer>
    {
        public CustomerMap()
        {
            AutoMap(CultureInfo.InvariantCulture);
            Map(m => m.id).Ignore();
        }
    }
}
