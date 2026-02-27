using FinanceTracker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            string category = catEdit.SelectedItem?.ToString() ?? "Other";
            TransactionType transType = rbIncomeEdit.Checked ? TransactionType.Income : TransactionType.Expense;
            transaction = new Transaction(amount, category, transType);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public Transaction GetEditedTransaction()
        {
            return transaction;
        }
    }
}