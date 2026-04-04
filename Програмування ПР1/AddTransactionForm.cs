using FinanceTracker;
using System;
using System.Windows.Forms;

namespace Програмування_ПР1
{
    public partial class AddTransactionForm : Form
    {
        public AddTransactionForm()
        {
            InitializeComponent();
        }

        private Transaction transaction;
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(inputNumber.Text, out decimal amount))
            {
                MessageBox.Show("Введіть коректне число!");
                return;
            }
            string category = comboBox1.SelectedItem?.ToString() ?? comboBox1.Text;
            TransactionType transType = rbIncome.Checked ? TransactionType.Income : TransactionType.Expense;

            var temp = new Transaction(amount, category, transType);

            if (!temp.IsValid(out string errorMessage))
            {
                MessageBox.Show(errorMessage);
                return;
            }

            transaction = temp;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public Transaction GetTransaction()
        {
            return transaction;
        }  
    }
}
