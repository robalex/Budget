using Budget.Model;
using System;

namespace Budget.Helper {
    class DateHelper {

        public static bool IsPayDateForMoneyItem(DateTime date, TransactionItem incomeItem) {
            var result = false;
            var daysBetweenDateAndSeed = (int)date.Date.Subtract(incomeItem.SeedDate.Date).TotalDays;

            switch (incomeItem.Frequency) {
                case MoneyFrequency.Monthly:
                    result = date.Day == incomeItem.SeedDate.Day;
                    break;
                case MoneyFrequency.BiWeekly:
                    result = daysBetweenDateAndSeed % 14 == 0;
                    break;
                case MoneyFrequency.Weekly:
                    result = daysBetweenDateAndSeed % 7 == 0;
                    break;
            }

            return result;
        }

    }
}
