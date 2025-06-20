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
    public partial class AddCurrencies : Form
    {
        public int CurrencyId => (int)numericUpDown1.Value;
        public string CurrencyName => textBox1.Text;
        public string CurrencySymbol => textBox2.Text;

        private bool isEditing;

        public AddCurrencies()
        {
            InitializeComponent();
            isEditing = false;
            this.Size = new Size(310, 180);
        }

        public AddCurrencies(Currencies selectedCurrency) : this()
        {
            numericUpDown1.Value = selectedCurrency.Currency_id;
            textBox1.Text = selectedCurrency.Name;
            textBox2.Text = selectedCurrency.Symbol;
            numericUpDown1.Enabled = false;
            button3.Visible = true;
            button1.Visible = false;
            isEditing = true;
        }

        private void AddCurrencies_Load(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                numericUpDown1.Value = GetNextCurrencyId();
            }
        }

        private int GetNextCurrencyId()
        {
            using (var context = new DatabaseContext())
            {
                if (!context.Currencies.Any())
                {
                    return 1;
                }

                var existingIds = context.Currencies.Select(t => t.Currency_id).ToList();
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
            if (CurrencyId <= 0 || string.IsNullOrWhiteSpace(CurrencyName) || string.IsNullOrWhiteSpace(CurrencySymbol))
            {
                MessageBox.Show("Пожалуйста, заполните все поля действительными данными.");
                return;
            }

            using (var context = new DatabaseContext())
            {
                if (context.Currencies.Any(bt => bt.Currency_id == CurrencyId))
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
            if (string.IsNullOrWhiteSpace(CurrencyName) || string.IsNullOrWhiteSpace(CurrencySymbol))
            {
                MessageBox.Show("Пожалуйста, заполните все поля действительными данными.");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}