using System;
using System.Collections.Generic;
using System.Linq;
using Budget.Helper;
using Budget.Model;

namespace Budget.DataAccess {
    public class BudgetMemoryDataAccess : IBudgetDataAccess
    {
        private List<TransactionItem> _transactions;
        private List<TransactionSource> _sources; 
        private int _nextItemId;
        private int _nextSourceId;

        public BudgetMemoryDataAccess()
        {
            _transactions = new List<TransactionItem>();
            _sources = new List<TransactionSource>();
            _nextItemId = 1;
            _nextSourceId = 1;
        }

        public IList<TransactionItem> GetTransactionsForDay(DateTime date)
        {
            return _transactions.Where(transaction => DateHelper.IsPayDateForMoneyItem(date, transaction)).ToList();
        }

        public void AddTransaction(TransactionItem item)
        {
            item.Id = _nextItemId;
            _nextItemId++;
        }

        public void DeleteTransaction(int id)
        {
            for (var i = 0; i < _transactions.Count; i++)
            {
                if (_transactions[i].Id == id)
                {
                    _transactions.RemoveAt(i);
                    break;
                }
            }
        }

        public void AddTransactionSource(TransactionSource source)
        {
            source.Id = _nextSourceId;
            _sources.Add(source);
            _nextSourceId++;
        }
    }
}
