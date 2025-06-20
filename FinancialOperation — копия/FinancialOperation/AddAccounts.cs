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
    public partial class AddAccounts : Form
    {
        public int AccountId => (int)numericUpDown1.Value;
        public int AccountClientId => (int)comboBox1.SelectedValue;
        public int AccountAccountTypeId => (int)comboBox2.SelectedValue;
        public int AccountCurrencyId => (int)comboBox3.SelectedValue;
        public string AccountNumber => textBox1.Text;
        public decimal AccountBalance => decimal.TryParse(textBox2.Text, out var balance) ? balance : 0;
        public DateTime AccountAdditionDate => dateTimePicker1.Value;

        private Accounts account;

        public AddAccounts()
        {
            InitializeComponent();
            this.Size = new Size(350, 300);
        }

        public AddAccounts(Accounts account) : this()
        {
            this.account = account;
        }

        private void AddAccounts_Load(object sender, EventArgs e)
        {
            LoadData();

            if (account != null)
            {
                numericUpDown1.Value = account.Account_id;
                numericUpDown1.Enabled = false; // Блокировка изменения Account_id
                button1.Visible = false;
                button3.Visible = true;
                comboBox1.SelectedValue = account.Client_id;
                comboBox2.SelectedValue = account.AccountType_id;
                comboBox3.SelectedValue = account.Currency_id;
                textBox1.Text = account.Number;
                textBox2.Text = account.Balance.ToString();
                dateTimePicker1.Value = account.AdditionDate;
            }
            if (account == null)
            {
                numericUpDown1.Value = GetNextAccountId();
            }
        }

        private int GetNextAccountId()
        {
            using (var context = new DatabaseContext())
            {
                if (!context.Accounts.Any())
                {
                    return 1;
                }

                var existingIds = context.Accounts.Select(t => t.Account_id).ToList();
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
                accountTypesBindingSource.DataSource = context.AccountTypes.ToList();
                currenciesBindingSource.DataSource = context.Currencies.ToList();
            }

            if (account != null) // Установите SelectedValue после загрузки данных в ComboBox
            {
                comboBox1.SelectedValue = account.Client_id;
                comboBox2.SelectedValue = account.AccountType_id;
                comboBox3.SelectedValue = account.Currency_id;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AccountId <= 0 || comboBox1.SelectedValue == null || comboBox2.SelectedValue == null || comboBox3.SelectedValue == null || string.IsNullOrWhiteSpace(AccountNumber) || AccountBalance < 0 || AccountAdditionDate > DateTime.Now)
            {
                MessageBox.Show("Пожалуйста, заполните все поля действительными данными.");
                return;
            }

            using (var context = new DatabaseContext()) // Проверка на уникальность ID в базе данных
            {
                if (context.Accounts.Any(a => a.Account_id == AccountId))
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
            if (AccountId <= 0 || comboBox1.SelectedValue == null || comboBox2.SelectedValue == null || comboBox3.SelectedValue == null || string.IsNullOrWhiteSpace(AccountNumber) || AccountBalance < 0 || AccountAdditionDate > DateTime.Now)
            {
                MessageBox.Show("Пожалуйста, заполните все поля действительными данными.");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}