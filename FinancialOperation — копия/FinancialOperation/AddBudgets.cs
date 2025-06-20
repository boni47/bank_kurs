using Microsoft.Identity.Client;
using Microsoft.Identity.Client.NativeInterop;
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
    public partial class AddBudgets : Form
    {
        public int BudgetId => (int)numericUpDown1.Value;
        public int BudgetClientId => (int)comboBox1.SelectedValue;
        public int BudgetBudgetTypeId => (int)comboBox2.SelectedValue;
        public int BudgetCurrencyId => (int)comboBox3.SelectedValue;
        public string BudgetName => textBox1.Text;
        public decimal BudgetAmount => decimal.TryParse(textBox2.Text, out var balance) ? balance : 0;
        public DateTime BudgetStartDate => dateTimePicker1.Value;
        public DateTime BudgetEndDate => dateTimePicker2.Value;
        public DateTime BudgetAdditionDate => dateTimePicker3.Value;

        private Budgets budget;

        public AddBudgets()
        {
            InitializeComponent();
            this.Size = new Size(350, 350);
        }

        public AddBudgets(Budgets budget) : this()
        {
            this.budget = budget;
        }

        private void AddBudgets_Load(object sender, EventArgs e)
        {
            LoadData();

            if (budget != null)
            {
                numericUpDown1.Value = budget.Budget_id;
                numericUpDown1.Enabled = false;
                button1.Visible = false;
                button3.Visible = true;
                comboBox1.SelectedValue = budget.Client_id;
                comboBox2.SelectedValue = budget.BudgetType_id;
                comboBox3.SelectedValue = budget.Currency_id;
                textBox1.Text = budget.Name;
                textBox2.Text = budget.Amount.ToString();
                dateTimePicker1.Value = budget.StartDate;
                dateTimePicker2.Value = budget.EndDate;
                dateTimePicker3.Value = budget.AdditionDate;
            }
            if (budget == null)
            {
                numericUpDown1.Value = GetNextBudgetId();
            }
        }

        private int GetNextBudgetId()
        {
            using (var context = new DatabaseContext())
            {
                if (!context.Budgets.Any())
                {
                    return 1;
                }

                var existingIds = context.Budgets.Select(t => t.Budget_id).ToList();
                int nextId = 1;
                while (existingIds.Contains(nextId))
                {
                    nextId++;
                }
                return nextId;
            }
        }

        private void LoadData()
        {
            using (var context = new DatabaseContext())
            {
                clientsBindingSource.DataSource = context.Clients.ToList();
                budgetTypesBindingSource.DataSource = context.BudgetTypes.ToList();
                currenciesBindingSource.DataSource = context.Currencies.ToList();
            }

            if (budget != null)
            {
                comboBox1.SelectedValue = budget.Client_id;
                comboBox2.SelectedValue = budget.BudgetType_id;
                comboBox3.SelectedValue = budget.Currency_id;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BudgetId <= 0 || comboBox1.SelectedValue == null || comboBox2.SelectedValue == null || comboBox3.SelectedValue == null || string.IsNullOrWhiteSpace(BudgetName) || BudgetAmount <= 0 || BudgetEndDate < BudgetStartDate || BudgetAdditionDate > DateTime.Now)
            {
                MessageBox.Show("Пожалуйста, заполните все поля действительными данными.");
                return;
            }

            using (var context = new DatabaseContext())
            {
                if (context.Budgets.Any(a => a.Budget_id == BudgetId))
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (BudgetId <= 0 || comboBox1.SelectedValue == null || comboBox2.SelectedValue == null || comboBox3.SelectedValue == null || string.IsNullOrWhiteSpace(BudgetName) || BudgetAmount <= 0 || BudgetEndDate < BudgetStartDate || BudgetAdditionDate > DateTime.Now)
            {
                MessageBox.Show("Пожалуйста, заполните все поля действительными данными.");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}