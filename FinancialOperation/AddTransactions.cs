using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialOperation
{
    public partial class AddTransactions : Form
    {
        public int TransactionId => (int)numericUpDown1.Value;
        public int TransactionAccountId => (int)comboBox1.SelectedValue;
        public string TransactionType => comboBox2.SelectedItem.ToString();
        public decimal TransactionAmount => decimal.TryParse(textBox1.Text, out var amount) ? amount : 0;
        public DateTime TransactionAdditionDate => dateTimePicker1.Value;
        public string TransactionDescription => textBox2.Text;

        public AddTransactions()
        {
            InitializeComponent();
        }

        private void AddTransactions_Load(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                accountsBindingSource.DataSource = context.Accounts.ToList();
            }

            numericUpDown1.Value = GetNextTransactionId();
        }

        private bool IsTransactionValid()
        {
            using (var context = new DatabaseContext())
            {
                var account = context.Accounts.Find(TransactionAccountId);

                if (TransactionType == "Снятие" && account.Balance < TransactionAmount)
                {
                    MessageBox.Show("Недостаточно средств для этой транзакции.");
                    return false;
                }
            }
            return true;
        }

        private int GetNextTransactionId()
        {
            using (var context = new DatabaseContext())
            {
                if (!context.Transactions.Any())
                {
                    return 1;
                }

                var existingIds = context.Transactions.Select(t => t.Transaction_id).ToList();
                int nextId = 1;
                while (existingIds.Contains(nextId))
                {
                    nextId++;
                }
                return nextId;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TransactionAccountId <= 0 || string.IsNullOrWhiteSpace(TransactionType) || TransactionAmount <= 0 || TransactionAdditionDate > DateTime.Now)
            {
                MessageBox.Show("Пожалуйста, заполните все поля действительными данными.");
                return;
            }

            if (!IsTransactionValid())
            {
                return;
            }

            using (var context = new DatabaseContext())
            {
                if (context.Transactions.Any(t => t.Transaction_id == TransactionId))
                {
                    MessageBox.Show("Запись с таким идентификатором уже существует. Пожалуйста, введите уникальный идентификатор.");
                    return;
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}