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
    public partial class UserControlCurrencies : UserControl
    {
        private DatabaseContext? databaseContext;
        public UserControlCurrencies()
        {
            InitializeComponent();
        }

        private void UserControlCurrencies_Load(object sender, EventArgs e)
        {
            this.databaseContext = new DatabaseContext();
            this.databaseContext.Database.EnsureCreated();
            this.databaseContext.Currencies.Load();
            this.currenciesBindingSource.DataSource = databaseContext.Currencies.Local.ToBindingList();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddCurrencies())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    var newCurrency = new Currencies
                    {
                        Currency_id = addForm.CurrencyId,
                        Name = addForm.CurrencyName,
                        Symbol = addForm.CurrencySymbol
                    };

                    databaseContext.Currencies.Add(newCurrency);
                    databaseContext.SaveChanges();

                    dataGridView1.Refresh();
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedCurrency = (Currencies)dataGridView1.SelectedRows[0].DataBoundItem;

                using (var editForm = new AddCurrencies(selectedCurrency))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        selectedCurrency.Name = editForm.CurrencyName;
                        selectedCurrency.Symbol = editForm.CurrencySymbol;

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
                var selectedCurrency = (Currencies)dataGridView1.SelectedRows[0].DataBoundItem;

                var confirmResult = MessageBox.Show("Вы уверены, что нужно удалить этот элемент?", "Подтвердите удаление", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    databaseContext.Currencies.Remove(selectedCurrency);
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
                var filteredCurrencies = databaseContext.Currencies.Local.ToBindingList()
                    .Where(currency => currency.Currency_id.ToString().Contains(filterText) ||
                                       currency.Name.ToLower().Contains(filterText) ||
                                       currency.Symbol.ToLower().Contains(filterText))
                    .ToList();

                currenciesBindingSource.DataSource = filteredCurrencies;
                dataGridView1.Refresh();
            }
        }
    }
}