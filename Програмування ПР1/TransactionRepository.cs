using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Програмування_ПР1
{
    internal class TransactionRepository<T> : IRepository<T>
    {
        private List<T> transactions = new List<T>();

        public void Add(T item)
        {
            transactions.Add(item);
        }
        public void Remove(T item)
        {
            transactions.Remove(item);
        }
        public T GetById(int id)
        {
            if (id >= 0 && id < transactions.Count)
            {
                return transactions[id];
            }
            return default;
        }

        public IEnumerable<T> GetAll
        {
            get { return transactions; }
        }
        public void Update(T item, int id)
        {
            if (id >= 0 && id < transactions.Count)
                transactions[id] = item;
        }
    }
}
