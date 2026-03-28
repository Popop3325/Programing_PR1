using FinanceTracker;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;

namespace Програмування_ПР1
{

    public class Transaction
    {
        [Required(ErrorMessage = "Необхідно вказати суму транзакції")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Введіть реальну суму транзакції")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Необхідно вказати категорію транзакції")]
        [StringLength(50, ErrorMessage = "Категорія не може бути довше 50 символів")]
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

        public bool IsValid(out string errorMessage){
            var results = new List<ValidationResult>();
            var context = new ValidationContext(this);
            bool isValid = Validator.TryValidateObject(this, context, results, true);

            errorMessage = isValid ? "" : results[0].ErrorMessage;
            return isValid;
        }
    }
}
