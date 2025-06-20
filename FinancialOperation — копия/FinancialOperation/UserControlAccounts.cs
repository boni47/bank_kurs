using Microsoft.EntityFrameworkCore;
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
    public partial class UserControlAccounts : UserControl
    {
        private DatabaseContext? databaseContext;
        public UserControlAccounts()
        {
            InitializeComponent();
        }

        private void UserControlAccounts_Load(object sender, EventArgs e)
        {
            this.databaseContext = new DatabaseContext();
            this.databaseContext.Database.EnsureCreated();
            this.databaseContext.Accounts.Load();
            this.accountsBindingSource.DataSource = databaseContext.Accounts.Local.ToBindingList();

            using (var context = new DatabaseContext())
            {
                clientsBindingSource.DataSource = context.Clients.ToList();
                accountTypesBindingSource.DataSource = context.AccountTypes.ToList();
                currenciesBindingSource.DataSource = context.Currencies.ToList();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (var addAccountForm = new AddAccounts())
            {
                if (addAccountForm.ShowDialog() == DialogResult.OK)
                {
                    var newAccount = new Accounts
                    {
                        Account_id = addAccountForm.AccountId,
                        Client_id = addAccountForm.AccountClientId,
                        AccountType_id = addAccountForm.AccountAccountTypeId,
                        Currency_id = addAccountForm.AccountCurrencyId,
                        Number = addAccountForm.AccountNumber,
                        Balance = addAccountForm.AccountBalance,
                        AdditionDate = addAccountForm.AccountAdditionDate
                    };

                    databaseContext.Accounts.Add(newAccount);
                    databaseContext.SaveChanges();
                    dataGridView1.Refresh();
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedAccount = (Accounts)dataGridView1.SelectedRows[0].DataBoundItem; // Получаем выбранный объект Accounts из DataGridView

                using (var editAccountForm = new AddAccounts(selectedAccount))
                {
                    if (editAccountForm.ShowDialog() == DialogResult.OK) // Если данные были изменены и пользователь нажал "Сохранить"
                    {
                        selectedAccount.Client_id = editAccountForm.AccountClientId; // Обновляем данные в выбранном объекте
                        selectedAccount.AccountType_id = editAccountForm.AccountAccountTypeId;
                        selectedAccount.Currency_id = editAccountForm.AccountCurrencyId;
                        selectedAccount.Number = editAccountForm.AccountNumber;
                        selectedAccount.Balance = editAccountForm.AccountBalance;
                        selectedAccount.AdditionDate = editAccountForm.AccountAdditionDate;

                        databaseContext.SaveChanges(); // Сохраняем изменения в базе данных
                        dataGridView1.Refresh(); // Обновляем DataGridView
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку для редактирования.");
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Проверяем, выбрана ли строка
            {
                var selectedAccount = (Accounts)dataGridView1.SelectedRows[0].DataBoundItem;

                var confirmResult = MessageBox.Show("Вы уверены, что нужно удалить этот элемент?", "Подтвердите удаление", MessageBoxButtons.YesNo); // Подтверждаем удаление
                if (confirmResult == DialogResult.Yes)
                {
                    databaseContext.Accounts.Remove(selectedAccount); // Удаляем элемент из базы данных
                    databaseContext.SaveChanges();
                    dataGridView1.Refresh(); // Обновляем DataGridView
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку для удаления.");
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            string filterText = toolStripTextBox1.Text.ToLower();

            if (databaseContext != null)
            {
                var filteredAccounts = databaseContext.Accounts.Local.ToBindingList()
                    .Where(account => account.Account_id.ToString().Contains(filterText) ||
                                      account.Client_id.ToString().Contains(filterText) ||
                                      account.AccountType_id.ToString().Contains(filterText) ||
                                      account.Currency_id.ToString().Contains(filterText) ||
                                      (account.Number != null && account.Number.ToLower().Contains(filterText)) ||
                                      account.Balance.ToString().Contains(filterText) ||
                                      account.AdditionDate.ToString("yyyy-MM-dd").Contains(filterText))
                    .ToList();

                accountsBindingSource.DataSource = filteredAccounts;
                dataGridView1.Refresh();
            }
        }
    }
}