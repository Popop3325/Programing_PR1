using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Text.Json;
using System.IO;

namespace Програмування_ПР1
{
    public class DataStorage
    {
       private string filePath = "transactions.json";
       
        public void Save(List<Transaction> transactions)
        {
            string json = JsonSerializer.Serialize(transactions);
            File.WriteAllText(filePath, json);
        }
        public List<Transaction> GetTransactions()
        {
            if (!File.Exists(filePath))
            {
                return new List<Transaction>();
            }
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Transaction>>(json);
        }

    }
}