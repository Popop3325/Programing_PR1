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
        }

        private List<Transaction> transactions = new List<Transaction>();
        private decimal currentBalance = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            AddTransactionForm addForm = new AddTransactionForm();

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                Transaction t = addForm.GetTransaction();
                transactions.Add(t);

                currentBalance += t.Amount;

                UpdateBalance();
                UpdateHistory();
            }
        }
        private void UpdateBalance()
        {
            labelCurrentBalance.Text = currentBalance.ToString("F2");
        }

        private void UpdateHistory()
        {
            transHis.Items.Clear();

            foreach (var t in transactions)
            {
                string sign = t.Amount >= 0 ? "+" : "";
                string line = $"{t.Date:dd.MM.yy} | {t.Category} | {sign}{t.Amount}";
                transHis.Items.Add(line);
            }
        }  
    }
}       