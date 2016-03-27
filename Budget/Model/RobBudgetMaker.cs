using System;
using System.Collections.Generic;
using Budget.DataAccess;

namespace Budget.Model {
    public class RobBudgetMaker {
        private int _sourceId = 0;
        private int _destinationId = 0;
        private int _incomeItemId = 0;
        private int _expenseItemId = 0;
        private IBudgetDataAccess _dataAccess;

        public double CurrentBankBalance { get; set; }


        public RobBudgetMaker(IBudgetDataAccess dataAccess)
        {
            _dataAccess = dataAccess;

            AddIncomeItems();
            AddExpenseItems();
        }

        private void AddExpenseItems() {
            var bankOfAmerica = AddExpenseDestination("Bank of America");
            var chase = AddExpenseDestination("Chase");
            var usaa = AddExpenseDestination("USAA");
            var nova = AddExpenseDestination("Nova Property");
            var aes = AddExpenseDestination("AES");
            var thecb = AddExpenseDestination("THECB");
            var uas = AddExpenseDestination("UAS");
            var ymca = AddExpenseDestination("YMCA");
            var iphone = AddExpenseDestination("iPhone");
            var irs = AddExpenseDestination("IRS");
            var hulu = AddExpenseDestination("Hulu");
            var deptOfEducation = AddExpenseDestination("Department of Education");
            var cityOfEdmond = AddExpenseDestination("City of Edmond");
            var citi = AddExpenseDestination("Citi");
            var att = AddExpenseDestination("AT&T");
            var ong = AddExpenseDestination("Oklahoma Natural Gas");
            var netflix = AddExpenseDestination("Netflix");
            var minessotaLife = AddExpenseDestination("Minessota Life");
            var bruchas = AddExpenseDestination("Dr. Bruchas");
            var jeffAndJudy = AddExpenseDestination("Jeff and Judy");

            var school = AddExpenseDestination("Washington Irving");
            var housekeeper = AddExpenseDestination("Housekeeper");
            var groceries = AddExpenseDestination("Groceries");
            var spendingMoney = AddExpenseDestination("Spending Money");
            var principal = AddExpenseDestination("Principal ICS");
            var tch = AddExpenseDestination("Texas Childrens Hospital");
            var savings = AddExpenseDestination("Savings!!!");
            var clothing = AddExpenseDestination("Clothing");
            var dates = AddExpenseDestination("Dates");
            var babysitter = AddExpenseDestination("BabySitter");
            var lawnCare = AddExpenseDestination("Lawn Care");
            var fuel = AddExpenseDestination("Fuel");
            var dollarShaveClub = AddExpenseDestination("Dollar Shave Club");

            AddExpenseItem(1800, MoneyFrequency.Monthly, nova, new DateTime(2016, 1, 1), "Rent");
            AddExpenseItem(130, MoneyFrequency.Monthly, aes, new DateTime(2016, 1, 1), "AES Loan");
            AddExpenseItem(261.69, MoneyFrequency.Monthly, thecb, new DateTime(2016, 1, 1), "THECB Loan");
            AddExpenseItem(626.08, MoneyFrequency.Monthly, usaa, new DateTime(2016, 1, 1), "Lexus Loan");
            AddExpenseItem(100, MoneyFrequency.Monthly, uas, new DateTime(2016, 1, 2), "UAS Loan");
            AddExpenseItem(180, MoneyFrequency.Monthly, bankOfAmerica, new DateTime(2016, 1, 2), "Bank of America Card");
            AddExpenseItem(350.38, MoneyFrequency.Monthly, usaa, new DateTime(2016, 1, 4), "USAA P&C");
            AddExpenseItem(120, MoneyFrequency.Weekly, ymca, new DateTime(2016, 2, 25), "YMCA After Care");
            AddExpenseItem(58.25, MoneyFrequency.Monthly, ymca, new DateTime(2016, 2, 2), "YMCA Membership");
            AddExpenseItem(44.91, MoneyFrequency.Monthly, iphone, new DateTime(2016, 1, 5), "iPhone Payment");
            AddExpenseItem(150, MoneyFrequency.Monthly, irs, new DateTime(2016, 1, 5), "IRS");
            AddExpenseItem(400.74, MoneyFrequency.Monthly, usaa, new DateTime(2016, 1, 5), "Camry Loan");
            AddExpenseItem(303, MoneyFrequency.Monthly, chase, new DateTime(2016, 1, 5), "Chase Card");
            AddExpenseItem(11.99, MoneyFrequency.Monthly, hulu, new DateTime(2016, 1, 8), "Hulu");
            AddExpenseItem(293, MoneyFrequency.Monthly, usaa, new DateTime(2016, 1, 10), "USAA Southwest Card");
            AddExpenseItem(1300, MoneyFrequency.Monthly, deptOfEducation, new DateTime(2016, 1, 10), "Department of Education Loan");
            AddExpenseItem(180, MoneyFrequency.Monthly, cityOfEdmond, new DateTime(2016, 1, 12), "City of Edmond Utilities");
            AddExpenseItem(148.01, MoneyFrequency.Monthly, principal, new DateTime(2016, 1, 1), "Principal ICS");
            AddExpenseItem(200, MoneyFrequency.Monthly, jeffAndJudy, new DateTime(2016, 1, 15), "Jeff and Judy");
            AddExpenseItem(1000, MoneyFrequency.Monthly, bruchas, new DateTime(2016, 1, 15), "Dr. Bruchas");
            AddExpenseItem(100, MoneyFrequency.Monthly, citi, new DateTime(2016, 1, 16), "Citi Card");
            AddExpenseItem(176.47, MoneyFrequency.Monthly, att, new DateTime(2016, 1, 16), "AT&T");
            AddExpenseItem(100, MoneyFrequency.Monthly, tch, new DateTime(2016, 1, 21), "TCH Owen Bill");
            AddExpenseItem(180.84, MoneyFrequency.Monthly, minessotaLife, new DateTime(2016, 1, 23), "Life Insurance");
            AddExpenseItem(65, MoneyFrequency.Monthly, ong, new DateTime(2016, 1, 23), "Natural Gas");
            AddExpenseItem(100, MoneyFrequency.Monthly, school, new DateTime(2016, 1, 23), "School Lunch Money");
            AddExpenseItem(8.65, MoneyFrequency.Monthly, netflix, new DateTime(2016, 1, 24), "Netflix");
            AddExpenseItem(100, MoneyFrequency.Monthly, clothing, new DateTime(2016, 1, 24), "Clothes");

            AddExpenseItem(100, MoneyFrequency.Weekly, housekeeper, new DateTime(2016, 3, 3), "Housekeeper");
            AddExpenseItem(200, MoneyFrequency.Weekly, spendingMoney, new DateTime(2016, 3, 3), "Spending Money");
            AddExpenseItem(250, MoneyFrequency.Weekly, groceries, new DateTime(2016, 3, 6), "Groceries");
            AddExpenseItem(200, MoneyFrequency.Monthly, dates, new DateTime(2016, 3, 6), "Dates");
            AddExpenseItem(150, MoneyFrequency.Monthly, babysitter, new DateTime(2016, 3, 6), "Babysitter");
            AddExpenseItem(25, MoneyFrequency.Weekly, lawnCare, new DateTime(2016, 3, 6), "Lawn Care");
            AddExpenseItem(200, MoneyFrequency.Monthly, fuel, new DateTime(2016, 2, 25), "Fuel (Car Gas)");
            AddExpenseItem(17, MoneyFrequency.Monthly, dollarShaveClub, new DateTime(2016, 2, 25), "Dollar Shave Club");

            //AddExpenseItem(1000, MoneyFrequency.Monthly, savings, new DateTime(2016, 2, 29), "Camp Savings");
            //AddExpenseItem(600, MoneyFrequency.Monthly, savings, new DateTime(2016, 2, 29), "Canada Savings");
            //AddExpenseItem(450, MoneyFrequency.Monthly, savings, new DateTime(2016, 2, 29), "Orlando Savings");
            //AddExpenseItem(250, MoneyFrequency.Monthly, savings, new DateTime(2016, 2, 29), "Beach Savings");
            //AddExpenseItem(250, MoneyFrequency.Monthly, savings, new DateTime(2016, 2, 29), "Emergency Savings");
            //AddExpenseItem(1700, MoneyFrequency.Monthly, savings, new DateTime(2016, 2, 29), "House Fund Savings");
        }

        private void AddIncomeItems() {
            var paycom = AddIncomeSource("Paycom");
            var oklahomaUniversity = AddIncomeSource("OUHSC");

            var paycomBiWeekly = AddIncomeItem(2900, MoneyFrequency.BiWeekly, paycom, new DateTime(2016, 3, 11), "Paycom Bi-Weekly");
            var ouhscMonthly = AddIncomeItem(6362.64, MoneyFrequency.Monthly, oklahomaUniversity, new DateTime(2016, 3, 11), "OUHSC Monthly");
            var vaBiWeekly = AddIncomeItem(762.73, MoneyFrequency.BiWeekly, oklahomaUniversity, new DateTime(2016, 3, 11), "VA Bi-Weekly");
            var ouhscBiWeekly = AddIncomeItem(1506.30, MoneyFrequency.BiWeekly, oklahomaUniversity, new DateTime(2016, 3, 4), "OUHSC Bi-Weekly");
        }

        private TransactionItem AddExpenseItem(double amount, MoneyFrequency frequency, TransactionSource destination, DateTime seedDate, string name) {
            var expenseItem = new TransactionItem() {
                Amount = amount,
                Source = destination,
                Frequency = frequency,
                Id = _expenseItemId,
                SeedDate = seedDate,
                Name = name,
                Type = TransactionType.Expense
            };

            _dataAccess.AddTransaction(expenseItem);

            _expenseItemId++;

            return expenseItem;
        }

        private TransactionItem AddIncomeItem(double amount, MoneyFrequency frequency, TransactionSource source, DateTime seedDate, string name) {
            var incomeItem = new TransactionItem() {
                Amount = amount,
                Frequency = frequency,
                Id = _incomeItemId,
                Source = source,
                SeedDate = seedDate,
                Name = name,
                Type = TransactionType.Income
            };

            _dataAccess.AddTransaction(incomeItem);

            _incomeItemId++;

            return incomeItem;
        }

        private TransactionSource AddExpenseDestination(string name) {
            var expense = new TransactionSource() { Id = this._destinationId, Name = name };
            _dataAccess.AddTransactionSource(expense);

            _destinationId++;

            return expense;
        }

        private TransactionSource AddIncomeSource(string name) {
            var source = new TransactionSource() { Id = this._sourceId, Name = name };
            _dataAccess.AddTransactionSource(source);

            _sourceId++;

            return source;
        }
    }
}