using System;
using System.Collections.Generic;

namespace Budget.Model {
    public class AccountSchedule {
        public float BalanceStart { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime StartDate { get; set; }
        public List<AccountDay> CalendarDays { get; set; }

        public AccountSchedule(DateTime startDate, DateTime endDate, float balanceStart)
        {
            StartDate = startDate;
            EndDate = endDate;
            BalanceStart = balanceStart;
        }

        public void GenerateCalendarDays()
        {
            var currentDay = StartDate.Date;
            while (currentDay < EndDate.Date)
            {
                var accountDay = new AccountDay();

                currentDay.AddDays(1);
            }
        }
    }
}
