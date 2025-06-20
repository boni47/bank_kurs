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
    public partial class UserControlAccountTypes : UserControl
    {
        private DatabaseContext? databaseContext;
        public UserControlAccountTypes()
        {
            InitializeComponent();
        }

        private void UserControlAccountTypes_Load(object sender, EventArgs e)
        {
            this.databaseContext = new DatabaseContext();
            this.databaseContext.Database.EnsureCreated();
            this.databaseContext.AccountTypes.Load();
            this.accountTypesBindingSource.DataSource = databaseContext.AccountTypes.Local.ToBindingList();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddAccountTypes())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    var newAccountType = new AccountTypes
                    {
                        AccountType_id = addForm.AccountTypeId,
                        Name = addForm.AccountTypeName,
                        Description = addForm.AccountTypeDescription
                    };

                    databaseContext.AccountTypes.Add(newAccountType);
                    databaseContext.SaveChanges();

                    dataGridView1.Refresh();
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedAccountType = (AccountTypes)dataGridView1.SelectedRows[0].DataBoundItem;

                using (var editForm = new AddAccountTypes(selectedAccountType))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        selectedAccountType.Name = editForm.AccountTypeName;
                        selectedAccountType.Description = editForm.AccountTypeDescription;

                        databaseContext.SaveChanges();
                        dataGridView1.Refresh();
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
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedAccountType = (AccountTypes)dataGridView1.SelectedRows[0].DataBoundItem;

                var confirmResult = MessageBox.Show("Вы уверены, что нужно удалить этот элемент?", "Подтвердите удаление", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    databaseContext.AccountTypes.Remove(selectedAccountType);
                    databaseContext.SaveChanges();

                    dataGridView1.Refresh();
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
                var filteredAccountTypes = databaseContext.AccountTypes.Local.ToBindingList()
                    .Where(accountType => accountType.AccountType_id.ToString().Contains(filterText) ||
                                          accountType.Name.ToLower().Contains(filterText) ||
                                          (accountType.Description != null && accountType.Description.ToLower().Contains(filterText)))
                    .ToList();

                accountTypesBindingSource.DataSource = filteredAccountTypes;
                dataGridView1.Refresh();
            }
        }
    }
}