using FinanceTracker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Програмування_ПР1
{

    public class Transaction
    {
        public decimal Amount { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public TransactionType TransType { get; set; }

        public Transaction(decimal amount, string category, TransactionType transType)
        {
            Amount = amount;
            Category = category;
            Date = DateTime.Now;
            TransType = transType;
        }
    }
}
