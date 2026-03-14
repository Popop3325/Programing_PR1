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

namespace Програмування_ПР1
{
    public partial class FinanceTracker : Form
    {
        public FinanceTracker()
        {
            InitializeComponent();
            transHisHeader.Items.Add("Дата       | Категорія  | Сума   | Тип");
        }
        TransactionRepository<Transaction> repo = new TransactionRepository<Transaction>();

        private decimal currentBalance = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            AddTransactionForm addForm = new AddTransactionForm();

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                Transaction t = addForm.GetTransaction();
                repo.Add(t);
                UpdateBalance();
                UpdateHistory();
            }
        }
        private void UpdateBalance()
        {
            currentBalance = 0;
            foreach (var t in repo.GetAll)
            {
                currentBalance += (t.TransType == TransactionType.Income) ? t.Amount : -t.Amount;
            }

            labelCurrentBalance.Text = currentBalance.ToString("F2");
            if (currentBalance >= 0)
            {
                labelCurrentBalance.ForeColor = Color.Green;
            }
            else
            {
                labelCurrentBalance.ForeColor = Color.Red;
            }
        }

        private void UpdateHistory()
        {
            transHis.Items.Clear();

            foreach (var t in repo.GetAll)
            {
                string line = $"{t.Date:dd.MM.yy} | {t.Category} | {t.Amount} | {t.TransType}";
                transHis.Items.Add(line);
            }
        }

        private void buttonEditTrans_Click(object sender, EventArgs e)
        {

            if (transHis.SelectedIndex == -1) return;
            int id = transHis.SelectedIndex;

            TransactionEdit editForm = new TransactionEdit(repo.GetById(id));
            editForm.ShowDialog();

            if (editForm.DialogResult == DialogResult.OK)
            {
                repo.Update(editForm.GetEditedTransaction(), id);
                currentBalance = 0;

                foreach (var t in repo.GetAll)
                {
                    currentBalance += (t.TransType == TransactionType.Income) ? t.Amount : -t.Amount;
                }

                UpdateBalance();
                UpdateHistory();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (transHis.SelectedIndex == -1) return;
            int id = transHis.SelectedIndex;

            repo.Remove(repo.GetById(id));
            UpdateBalance();
            UpdateHistory();
        }
    }
}       