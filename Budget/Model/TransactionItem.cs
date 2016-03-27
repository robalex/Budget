using System;
using System.Security.AccessControl;

namespace Budget.Model {
    public class TransactionItem {

        public int Id { get; set; }

        public MoneyFrequency Frequency { get; set; }

        public double Amount { get; set; }

        public DateTime SeedDate { get; set; }

        public string Name { get; set; }

        public TransactionType Type { get; set; }

        public TransactionSource Source { get; set; }

        public bool IsPayDate(DateTime date) {
            var result = false;
            var daysBetweenDateAndSeed = (int)date.Date.Subtract(SeedDate.Date).TotalDays;

            switch (Frequency) {
                case MoneyFrequency.Once:
                    result = date == SeedDate;
                    break;
                case MoneyFrequency.Yearly:
                    result = date.Month == SeedDate.Month && date.Day == SeedDate.Day;
                    break;
                case MoneyFrequency.Monthly:
                    result = date.Day == SeedDate.Day;
                    break;
                case MoneyFrequency.BiWeekly:
                    result = daysBetweenDateAndSeed % 14 == 0;
                    break;
                case MoneyFrequency.Weekly:
                    result = daysBetweenDateAndSeed % 7 == 0;
                    break;
                default:
                    result = false;
                    break;
            }

            return result;
        }

    }
}
