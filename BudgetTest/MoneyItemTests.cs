using System;
using Budget.Model;
using Xunit;

namespace BudgetTest
{
    public class MoneyItemTests
    {
        [Theory]
        [InlineData("2016-01-01")]
        [InlineData("2017-01-01")]
        [InlineData("9999-01-01")]
        public void YearlyOnCorrectDateShouldReturnTrue(string date)
        {
            var item = new TransactionItem {
                SeedDate = new DateTime(2016, 1, 1),
                Frequency = MoneyFrequency.Yearly
            };

            var validDate = DateTime.ParseExact(date, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            var result = item.IsPayDate(validDate);

            Assert.True(result, "IsPayDate returned incorrect result for the correct day");
        }

        [Theory]
        [InlineData("2016-01-02")]
        [InlineData("2017-01-02")]
        [InlineData("2016-01-08")]
        [InlineData("2016-01-15")]
        [InlineData("2016-02-01")]
        public void YearlyOnWrongDateShouldReturnFalse(string date)
        {
            var item = new TransactionItem
            {
                SeedDate = new DateTime(2016, 1, 1),
                Frequency = MoneyFrequency.Yearly
            };

            var invalidDate = DateTime.ParseExact(date, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            var result = item.IsPayDate(invalidDate);

            Assert.False(result, "IsPayDate returned incorrect result for yearly pay on the wrong day of next year");
        }

        [Fact]
        public void OnceOnSameDateShouldReturnTrue()
        {
            var item = new TransactionItem {
                SeedDate = new DateTime(2016, 1, 1),
                Frequency = MoneyFrequency.Once
            };

            var yearFromDate = new DateTime(2016, 1, 1);
            var result = item.IsPayDate(yearFromDate);

            Assert.True(result, "IsPayDate returned incorrect result for once pay on the same day");
        }

        [Theory]
        [InlineData("2016-01-02")]
        [InlineData("2016-01-08")]
        [InlineData("2016-01-15")]
        [InlineData("2016-02-01")]
        [InlineData("2017-01-01")]
        public void OnceOnWrongDateShouldReturnFalse(string date) {
            var item = new TransactionItem {
                SeedDate = new DateTime(2016, 1, 1),
                Frequency = MoneyFrequency.Once
            };

            var invalidDate = DateTime.ParseExact(date, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            var result = item.IsPayDate(invalidDate);

            Assert.False(result, "IsPayDate returned incorrect result for once pay on the wrong day");
        }

        [Theory]
        [InlineData("2016-01-01")]
        [InlineData("2016-01-08")]
        [InlineData("2016-01-15")]
        [InlineData("2016-01-22")]
        [InlineData("2016-06-24")]
        [InlineData("2017-01-06")]
        public void WeeklyOnCorrectDateShouldReturnTrue(string date)
        {
            var item = new TransactionItem {
                SeedDate = new DateTime(2016, 1, 1),
                Frequency = MoneyFrequency.Weekly
            };

            var validDate = DateTime.ParseExact(date, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            var result = item.IsPayDate(validDate);

            Assert.True(result, "IsPayDate returned incorrect result for weekly pay on the correct day");
        }

        [Theory]
        [InlineData("2016-01-02")]
        [InlineData("2016-02-01")]
        [InlineData("2017-01-01")]
        public void WeeklyOnIncorrectDateShouldReturnFalse(string date)
        {
            var item = new TransactionItem {
                SeedDate = new DateTime(2016, 1, 1),
                Frequency = MoneyFrequency.Weekly
            };

            var validDate = DateTime.ParseExact(date, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            var result = item.IsPayDate(validDate);

            Assert.False(result, "IsPayDate returned incorrect result for weekly pay on the wrong day");
        }

        [Theory]
        [InlineData("2016-01-01")]
        [InlineData("2016-02-01")]
        [InlineData("2016-06-01")]
        [InlineData("2017-01-01")]
        [InlineData("2017-06-01")]
        public void MonthlyOnCorrectDateShouldReturnTrue(string date)
        {
            var item = new TransactionItem {
                SeedDate = new DateTime(2016, 1, 1),
                Frequency = MoneyFrequency.Monthly
            };

            var validDate = DateTime.ParseExact(date, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            var result = item.IsPayDate(validDate);

            Assert.True(result, "IsPayDate returned incorrect result for monthly pay on the correct day");
        }

        [Theory]
        [InlineData("2016-01-02")]
        [InlineData("2016-01-08")]
        [InlineData("2016-01-15")]
        [InlineData("2016-02-02")]
        public void MonthlyOnIncorrectDateShouldReturnFalse(string date)
        {
            var item = new TransactionItem {
                SeedDate = new DateTime(2016, 1, 1),
                Frequency = MoneyFrequency.Monthly
            };

            var validDate = DateTime.ParseExact(date, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            var result = item.IsPayDate(validDate);

            Assert.False(result, "IsPayDate returned incorrect result for monthly pay on the wrong day");
        }
        
        [Theory]
        [InlineData("2016-01-01")]
        [InlineData("2016-01-15")]
        [InlineData("2016-01-29")]
        [InlineData("2016-03-25")]
        [InlineData("2017-01-13")]
        public void BiWeeklyOnCorrectDateShouldReturnTrue(string date)
        {
            var item = new TransactionItem {
                SeedDate = new DateTime(2016, 1, 1),
                Frequency = MoneyFrequency.BiWeekly
            };

            var validDate = DateTime.ParseExact(date, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            var result = item.IsPayDate(validDate);

            Assert.True(result, "IsPayDate returned incorrect result for bi-weekly pay on the correct day");
        }

        [Theory]
        [InlineData("2016-01-02")]
        [InlineData("2016-02-01")]
        [InlineData("2016-01-08")]
        [InlineData("2016-01-22")]
        [InlineData("2017-01-06")]
        public void BiWeeklyOnIncorrectDateShouldReturnFalse(string date)
        {
            var item = new TransactionItem {
                SeedDate = new DateTime(2016, 1, 1),
                Frequency = MoneyFrequency.BiWeekly
            };

            var validDate = DateTime.ParseExact(date, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            var result = item.IsPayDate(validDate);

            Assert.False(result, "IsPayDate returned incorrect result for bi-weekly pay on the wrong day");
        }
    }
}
