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
            try
            {
                string json = JsonSerializer.Serialize(transactions);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка при збереженні у файл: {ex.Message}");
            }
        }
        public List<Transaction> GetTransactions()
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    return new List<Transaction>();
                }
                string json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<Transaction>>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка при завантаженні файлу: {ex.Message}");
                return new List<Transaction>();
            }
        }

    }
}