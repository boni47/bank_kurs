using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialOperation
{
    public partial class UserControlTransactions : UserControl
    {
        private DatabaseContext? databaseContext;
        public UserControlTransactions()
        {
            InitializeComponent();
        }

        private void UserControlTransactions_Load(object sender, EventArgs e)
        {
            this.databaseContext = new DatabaseContext();
            this.databaseContext.Database.EnsureCreated();
            this.databaseContext.Transactions.Load();
            this.transactionsBindingSource.DataSource = databaseContext.Transactions.Local.ToBindingList();

            using (var context = new DatabaseContext())
            {
                accountsBindingSource.DataSource = context.Accounts.ToList();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (var addTransactionForm = new AddTransactions())
            {
                if (addTransactionForm.ShowDialog() == DialogResult.OK)
                {
                    var newTransaction = new Transactions
                    {
                        Transaction_id = addTransactionForm.TransactionId,
                        Account_id = addTransactionForm.TransactionAccountId,
                        Type = addTransactionForm.TransactionType,
                        Amount = addTransactionForm.TransactionAmount,
                        AdditionDate = addTransactionForm.TransactionAdditionDate,
                        Description = addTransactionForm.TransactionDescription
                    };

                    databaseContext.Transactions.Add(newTransaction);
                    UpdateAccountBalance(newTransaction);
                    databaseContext.SaveChanges();
                    dataGridView1.Refresh();
                }
            }
        }

        private void UpdateAccountBalance(Transactions transaction)
        {
            var account = databaseContext.Accounts.Find(transaction.Account_id);
            if (account != null)
            {
                if (transaction.Type == "Пополнение")
                {
                    account.Balance += transaction.Amount;
                }
                else if (transaction.Type == "Снятие")
                {
                    account.Balance -= transaction.Amount;
                }
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            string filterText = toolStripTextBox1.Text.ToLower();

            if (databaseContext != null)
            {
                var filteredTransactions = databaseContext.Transactions.Local.ToBindingList()
                    .Where(transaction => transaction.Transaction_id.ToString().Contains(filterText) ||
                                         transaction.Account_id.ToString().Contains(filterText) ||
                                         transaction.Type.ToLower().Contains(filterText) ||
                                         transaction.Amount.ToString().Contains(filterText) ||
                                         transaction.AdditionDate.ToString("dd/MM/yyyy").Contains(filterText) ||
                                         transaction.Description.ToLower().Contains(filterText))
                    .ToList();

                transactionsBindingSource.DataSource = filteredTransactions;
                dataGridView1.Refresh();
            }
        }
    }
}