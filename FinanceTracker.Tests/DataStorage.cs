using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace FinanceTracker.Tests
{
    /// <summary>
    /// Відповідає за збереження та завантаження транзакцій у файл в форматі JSON.
    /// </summary>
    public class DataStorage
    {
        private string filePath = "transactions.json";
        /// <summary>
        /// Серіалізує список транзакцій та зберігає його у файл в форматі JSON.
        /// </summary>
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
        /// <summary>
        /// Десеріалізує список транзакцій з файлу в форматі JSON та повертає його.
        /// </summary>
        /// <returns> Список транзакцій або новий пустий список, якщо файлу не існує </returns>
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