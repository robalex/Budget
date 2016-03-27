using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.Model {
    public class AccountDay {
        public float StartBalance { get; set; }
        public float EndBalance { get; set; }
        public List<TransactionItem> Transactions { get; set; }
    }
}
