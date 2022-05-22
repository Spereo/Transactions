using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transactions.Data.Models;

namespace Transactions.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if(!content.Customer.Any())
            {
                content.Customer.AddRange(Customers.Select(c => c.Value));
            }

            if(!content.MccCode.Any())
            {
                content.MccCode.AddRange(MccCodes.Select(c => c.Value));
            }

            if (!content.Type.Any())
            {
                content.Type.AddRange(TransactionsTypes.Select(c => c.Value));
            }

            if (!content.Transaction.Any())
            {
                content.AddRange(
                    new Transaction { customer_id = 39026145, tr_datetime = "0 10:23:26", mcc_code = 4814, tr_type = 3210, amount = -2245.92, term_id = "111"/*, Customer = Customers[39026145], MccCode = MccCodes[742], TransactionType = TransactionsTypes[3200]*/ },
                    new Transaction { customer_id = 39026146, tr_datetime = "1 12:54:37", mcc_code = 4815, tr_type = 3200, amount = -500.69, term_id = "112"/*, Customer = Customers[39026146], MccCode = MccCodes[1711], TransactionType = TransactionsTypes[3210]*/ }
                    );
            }

            content.SaveChanges();
        }

        private static Dictionary<int, Customer> customer;
        public static Dictionary<int, Customer> Customers
        {
            get
            {
                if (customer == null)
                {
                    var list = new Customer[]
                    {
                        new Customer { customer_id = 39026145, gender = 0},
                        new Customer { customer_id = 39026146, gender = 1}
                    };

                    customer = new Dictionary<int, Customer>();
                    foreach (Customer el in list)
                    {
                        customer.Add(el.customer_id, el);
                    }
                }

                return customer;
            }
        }

        private static Dictionary<int, MccCode> mccCode;
        public static Dictionary<int, MccCode> MccCodes
        {
            get
            {
                if (mccCode == null)
                {
                    var list = new MccCode[]
                    {
                        new MccCode { mcc_code = 742, mcc_description = "Ветеринарные услуги"},
                        new MccCode { mcc_code = 1711, mcc_description = "Генеральные подрядчики по вентиляции, теплоснабжению, и водопроводу"}
                    };

                    mccCode = new Dictionary<int, MccCode>();
                    foreach (MccCode el in list)
                    {
                        mccCode.Add(el.mcc_code, el);
                    }
                }

                return mccCode;
            }
        }

        private static Dictionary<int, TransactionsType> transactionsType;
        public static Dictionary<int, TransactionsType> TransactionsTypes
        {
            get
            {
                if (transactionsType == null)
                {
                    var list = new TransactionsType[]
                    {
                        new TransactionsType { tr_type = 3200, tr_description = "Плата за предоставление услуг посредством мобильной связи"},
                        new TransactionsType { tr_type = 3210, tr_description = "Плата за предоставление отчета по счету карты почтой"}
                    };

                    transactionsType = new Dictionary<int, TransactionsType>();
                    foreach (TransactionsType el in list)
                    {
                        transactionsType.Add(el.tr_type, el);
                    }
                }

                return transactionsType;
            }
        }

    }
}
