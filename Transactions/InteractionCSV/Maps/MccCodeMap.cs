using CsvHelper.Configuration;
using System.Globalization;
using Transactions.Data.Models;

namespace Transactions.InteractionCSV.Maps
{
    public class MccCodeMap : ClassMap<MccCode>
    {
        public MccCodeMap()
        {
            AutoMap(CultureInfo.InvariantCulture);
            Map(m => m.id).Ignore();
        }
    }
}
