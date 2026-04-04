using Xunit;
using FinanceTracker;
namespace FinanceTracker.Tests
{
    public class TrasactionTests
    {
        [Fact]
        public void IsValid_NegativeAmount_ReturnsFalse()
        {
            // Arrange
            var transaction = new Transaction(-100, "Food", TransactionType.Expense);

            // Act
            bool result = transaction.IsValid(out string errorMessage);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsValid_NullAmount_ReturnsFalse()
        {
            var transaction = new Transaction(0, "Food", TransactionType.Expense);
            bool result = transaction.IsValid(out string errorMessage);
            Assert.False(result);
        }

        [Fact]
        public void IsValid_NoCategory_ReturnsFalse()
        {
            var transaction = new Transaction(100, "", TransactionType.Expense);
            bool result = transaction.IsValid(out string errorMessage);
            Assert.False(result);
        }

        [Fact]
        public void IsValid_ValidTransaction_ReturnsTrue()
        {
            var transaction = new Transaction(100, "Food", TransactionType.Expense);
            bool result = transaction.IsValid(out string errorMessage);
            Assert.True(result);
        }
    }

    public class DataStorageTests
    {
        [Fact]
        public void SaveAndGetTransactions_ReturnsSameCountOfTransactions()
        {
            var Storage = new DataStorage();
            var transactions = new List<Transaction>
        {
            new Transaction(100, "Food", TransactionType.Expense),
            new Transaction(200, "Salary", TransactionType.Income)
        };
            Storage.Save(transactions);
            var loadedTransactions = Storage.GetTransactions();
            Assert.Equal(transactions.Count, loadedTransactions.Count);
        }
    }
}