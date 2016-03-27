using System;
using Budget.DataAccess;
using Budget.Model;
using Budget.Helper;

namespace Budget {
    class Program {
        static void Main(string[] args) {
            var dataAccess = new BudgetMemoryDataAccess();
            var budgetMaker = new RobBudgetMaker(dataAccess);
            budgetMaker.CurrentBankBalance = 4867.06;


            var start = new DateTime(2016, 3, 19);
            var checkDate = new DateTime(2016, 5, 15);

            Console.WriteLine("Starting Balance on " + start.ToShortDateString() + ": $" + budgetMaker.CurrentBankBalance);
            budgetMaker.CurrentBankBalance -= 1000;
            Console.WriteLine("Starting Balance after taking out $1000 for Dr Bruchas on " + start.ToShortDateString() + ": $" + budgetMaker.CurrentBankBalance);
            Console.WriteLine();
            Console.WriteLine();

          /*  var date = start;
            while(date < checkDate) {
                foreach(var item in budgetMaker.IncomeItems) {
                    if(DateHelper.IsPayDateForMoneyItem(date, item)) {
                        budgetMaker.CurrentBankBalance += item.Amount;
                        Console.WriteLine("Income: $" + item.Amount + " from " + item.Name);
                    }
                }

                foreach(var item in budgetMaker.ExpenseItems) {
                    if(DateHelper.IsPayDateForMoneyItem(date, item)) {
                        budgetMaker.CurrentBankBalance -= item.Amount;
                        Console.WriteLine("Expense: $" + item.Amount + " for " + item.Name);
                    }
                }

                Console.WriteLine("New Total: $" + budgetMaker.CurrentBankBalance + " on " + date.ToShortDateString());
                Console.WriteLine();
                Console.WriteLine();
                date = date.AddDays(1);
            }
*/
            Console.WriteLine("Money in account on " + checkDate.ToShortDateString() + " is $" + budgetMaker.CurrentBankBalance);
            //for (var i = 1; i < 31; i++) {
            //    var date = start.AddDays(i);
            //    foreach (var item in budgetMaker.IncomeItems) {
            //        if (DateHelper.IsPayDateForMoneyItem(date, item)) {
            //            var output = string.Format("{0}: {1} on {2}", item.Name, item.Amount, date.Date.ToShortDateString());
            //            Console.WriteLine(output);
            //        }
            //    }
            //}

            Console.WriteLine();
            Console.WriteLine();

            //for(var i = 1; i < 31; i++) {
            //    var date = start.AddDays(i);
            //    foreach(var item in budgetMaker.ExpenseItems) {
            //        if(DateHelper.IsPayDateForMoneyItem(date, item)) {
            //            var output = string.Format("{0}: {1} on {2}", item.Name, item.Amount, date.Date.ToShortDateString());
            //            Console.WriteLine(output);
            //        }
            //    }
            //}

            Console.ReadLine();
        }

        
    }
}


