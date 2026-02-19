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

        public Transaction(decimal amount, string category)
        {
            Amount = amount;
            Category = category;
            Date = DateTime.Now;
        }
    }
}
