using System.Collections.Generic;

namespace Програмування_ПР1
{
    /// <summary>
    /// Описує базовий інтерфейс для роботи з колекцією об'єктів типу T.
    /// </summary>
    internal interface IRepository<T>
    {
        void Add(T item);
        void Remove(T item);
        void Update(T item, int id);
        T GetById(int id);
        List<T> GetAll();

    }
}
