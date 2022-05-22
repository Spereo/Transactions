using CsvHelper;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Transactions.Data.Models;
using Transactions.InteractionCSV.Maps;

namespace Transactions.InteractionCSV
{
    public class Parser
    {
        public static void Read(string path, ref List<Customer> customers)
        {
            using (var streamReader = new StreamReader(path))
            {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    csvReader.Context.RegisterClassMap<CustomerMap>();
                    var records = csvReader.GetRecords<Customer>().ToList();
                    customers.AddRange(records);
                }
            }
        }

        public static void Read(string path, ref List<MccCode> mccCodes)
        {
            using (var streamReader = new StreamReader(path))
            {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    csvReader.Context.RegisterClassMap<MccCodeMap>();
                    var records = csvReader.GetRecords<MccCode>().ToList();
                    mccCodes.AddRange(records);
                }
            }
        }

        public static void Read(string path, ref List<TransactionsType> transactionsTypes)
        {
            using (var streamReader = new StreamReader(path))
            {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    csvReader.Context.RegisterClassMap<TransactionsTypeMap>();
                    var records = csvReader.GetRecords<TransactionsType>().ToList();
                    transactionsTypes.AddRange(records);
                }
            }
        }

        public static void Read(string path, ref List<Transaction> transactions)
        {
            using (var streamReader = new StreamReader(path))
            {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    csvReader.Context.RegisterClassMap<TransactionMap>();
                    var records = csvReader.GetRecords<Transaction>().ToList();
                    transactions.AddRange(records);
                }
            }
        }
    }
}
