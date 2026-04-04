using FinanceTracker;
using System;
using System.Windows.Forms;

namespace Програмування_ПР1
{
    public partial class TransactionEdit : Form
    {

        public TransactionEdit(Transaction t)
        {
            InitializeComponent();
            sumEdit.Text = t.Amount.ToString("F2");
            catEdit.SelectedItem = t.Category;
            rbIncomeEdit.Checked = t.TransType == TransactionType.Income;
            rbExpenseEdit.Checked = t.TransType == TransactionType.Expense;
        }

        private Transaction transaction;
        private void buttonSaveEdit_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(sumEdit.Text, out decimal amount))
            {
                MessageBox.Show("Введіть коректне число!");
                return;
            }
            string category = catEdit.SelectedItem?.ToString() ?? catEdit.Text;
            TransactionType transType = rbIncomeEdit.Checked ? TransactionType.Income : TransactionType.Expense;

            Transaction temp = new Transaction(amount, category, transType);

            if (!temp.IsValid(out string errorMessage))
            {
                MessageBox.Show(errorMessage);
                return;
            }

            transaction = temp;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public Transaction GetEditedTransaction()
        {
            return transaction;
        }
    }
}