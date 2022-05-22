using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transactions.Data.Interfaces;
using Transactions.Data.Models;
using Transactions.ViewModels;

namespace Transactions.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllTransactions _allTransactions;
        private readonly ITransactionsCustomer _allCustomers;
        private readonly ITransactionsMccCode _allMccCodes;
        private readonly ITransactionsType _allTypes;

        public HomeController(IAllTransactions iAllTransactions, ITransactionsCustomer iTransactionsCustomer, ITransactionsMccCode iTransactionsMccCode, ITransactionsType iTransactionsType)
        {
            _allTransactions = iAllTransactions;
            _allCustomers = iTransactionsCustomer;
            _allMccCodes = iTransactionsMccCode;
            _allTypes = iTransactionsType;
        }

        public ViewResult Index(int id)
        {
            ViewBag.Title = "Страница с транзакциями";
            TransactionListViewModel obj = new TransactionListViewModel();
            obj.allTransactions = _allTransactions.Transactions;
            obj.currCategory = "Транзакции";
            return View(obj);
        }
    }
}
