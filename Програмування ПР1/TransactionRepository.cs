using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Програмування_ПР1
{
    internal class TransactionRepository : IRepository<Transaction>
    {
        private List<Transaction> transactions = new List<Transaction>();

        public void Add(Transaction item)
        {
            transactions.Add(item);
        }
        public void Remove(Transaction item)
        {
            transactions.Remove(item);
        }
        public Transaction GetById(int id)
        {
            if (id >= 0 && id < transactions.Count)
            {
                return transactions[id];
            }
            return null;
        }

        public IEnumerable<Transaction> GetAll
        {
            get { return transactions; }
        }
        public void Update(Transaction item, int id)
        {
            if (id >= 0 && id < transactions.Count)
                transactions[id] = item;
        }
    }
}
