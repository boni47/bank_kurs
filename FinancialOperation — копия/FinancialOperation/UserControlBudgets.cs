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
    public partial class UserControlBudgets : UserControl
    {
        private DatabaseContext? databaseContext;
        public UserControlBudgets()
        {
            InitializeComponent();
        }

        private void UserControlBudgets_Load(object sender, EventArgs e)
        {
            this.databaseContext = new DatabaseContext();
            this.databaseContext.Database.EnsureCreated();
            this.databaseContext.Budgets.Load();
            this.budgetsBindingSource.DataSource = databaseContext.Budgets.Local.ToBindingList();

            using (var context = new DatabaseContext())
            {
                clientsBindingSource.DataSource = context.Clients.ToList();
                budgetTypesBindingSource.DataSource = context.BudgetTypes.ToList();
                currenciesBindingSource.DataSource = context.Currencies.ToList();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (var addBudgetForm = new AddBudgets())
            {
                if (addBudgetForm.ShowDialog() == DialogResult.OK)
                {
                    var newBudget = new Budgets
                    {
                        Budget_id = addBudgetForm.BudgetId,
                        Client_id = addBudgetForm.BudgetClientId,
                        BudgetType_id = addBudgetForm.BudgetBudgetTypeId,
                        Currency_id = addBudgetForm.BudgetCurrencyId,
                        Name = addBudgetForm.BudgetName,
                        Amount = addBudgetForm.BudgetAmount,
                        StartDate = addBudgetForm.BudgetStartDate,
                        EndDate = addBudgetForm.BudgetEndDate,
                        AdditionDate = addBudgetForm.BudgetAdditionDate
                    };

                    databaseContext.Budgets.Add(newBudget);
                    databaseContext.SaveChanges();
                    dataGridView1.Refresh();
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedBudget = (Budgets)dataGridView1.SelectedRows[0].DataBoundItem;

                using (var editBudgetForm = new AddBudgets(selectedBudget))
                {
                    if (editBudgetForm.ShowDialog() == DialogResult.OK)
                    {
                        selectedBudget.Client_id = editBudgetForm.BudgetClientId;
                        selectedBudget.BudgetType_id = editBudgetForm.BudgetBudgetTypeId;
                        selectedBudget.Currency_id = editBudgetForm.BudgetCurrencyId;
                        selectedBudget.Name = editBudgetForm.BudgetName;
                        selectedBudget.Amount = editBudgetForm.BudgetAmount;
                        selectedBudget.StartDate = editBudgetForm.BudgetStartDate;
                        selectedBudget.EndDate = editBudgetForm.BudgetEndDate;
                        selectedBudget.AdditionDate = editBudgetForm.BudgetAdditionDate;

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
                var selectedBudget = (Budgets)dataGridView1.SelectedRows[0].DataBoundItem;

                var confirmResult = MessageBox.Show("Вы уверены, что нужно удалить этот элемент?", "Подтвердите удаление", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    databaseContext.Budgets.Remove(selectedBudget);
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
                var filteredBudgets = databaseContext.Budgets.Local.ToBindingList()
                    .Where(budget => budget.Budget_id.ToString().Contains(filterText) ||
                                     budget.Client_id.ToString().Contains(filterText) ||
                                     budget.BudgetType_id.ToString().Contains(filterText) ||
                                     budget.Currency_id.ToString().Contains(filterText) ||
                                     budget.Name.ToLower().Contains(filterText) ||
                                     budget.Amount.ToString().Contains(filterText) ||
                                     budget.StartDate.ToString().Contains(filterText) ||
                                     budget.EndDate.ToString().Contains(filterText) ||
                                     budget.AdditionDate.ToString().Contains(filterText))
                    .ToList();

                budgetsBindingSource.DataSource = filteredBudgets;
                dataGridView1.Refresh();
            }
        }
    }
}