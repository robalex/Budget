using System;
using System.Collections.Generic;
using Budget.Model;

namespace Budget.DataAccess {
    public interface IBudgetDataAccess
    {
        IList<TransactionItem> GetTransactionsForDay(DateTime date);
        void AddTransaction(TransactionItem item);
        void DeleteTransaction(int id);
        void AddTransactionSource(TransactionSource source);
    }
}
