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
                MessageBox.Show("Введіть коректне число! Наприклад: 10 або -10");
                return;
            }
            string category = comboBox1.SelectedItem?.ToString() ?? "Other";

            transaction = new Transaction(amount, category);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public Transaction GetTransaction()
        {
            return transaction;
        }

    }
}
