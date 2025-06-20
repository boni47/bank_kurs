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
    public partial class AddPaymentRoutes : Form
    {
        public int PaymentRouteId => (int)numericUpDown1.Value;
        public int AccountFromId => (int)comboBox1.SelectedValue;
        public int AccountToId => (int)comboBox2.SelectedValue;
        public decimal RouteAmount => decimal.TryParse(textBox1.Text, out var amount) ? amount : 0;
        public DateTime RouteAdditionDate => dateTimePicker1.Value;
        public string RouteDescription => textBox2.Text;

        public AddPaymentRoutes()
        {
            InitializeComponent();
        }

        private void AddPaymentRoutes_Load(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                accountsBindingSource.DataSource = context.Accounts.ToList();
                accountsBindingSource1.DataSource = context.Accounts.ToList();
            }

            numericUpDown1.Value = GetNextPaymentRouteId();
        }

        private int GetNextPaymentRouteId()
        {
            using (var context = new DatabaseContext())
            {
                if (!context.PaymentRoutes.Any())
                {
                    return 1;
                }

                var existingIds = context.PaymentRoutes.Select(pr => pr.PaymentRoute_id).ToList();
                int nextId = 1;
                while (existingIds.Contains(nextId))
                {
                    nextId++;
                }
                return nextId;
            }
        }

        private bool IsRouteValid()
        {
            if (AccountFromId == AccountToId)
            {
                MessageBox.Show("Учетные записи отправителя и получателя не могут совпадать.");
                return false;
            }

            using (var context = new DatabaseContext())
            {
                var accountFrom = context.Accounts.Find(AccountFromId);

                if (accountFrom.Balance < RouteAmount)
                {
                    MessageBox.Show("Недостаточно средств на счете отправителя.");
                    return false;
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AccountFromId <= 0 || AccountToId <= 0 || RouteAmount <= 0 || RouteAdditionDate > DateTime.Now)
            {
                MessageBox.Show("Пожалуйста, заполните все поля действительными данными.");
                return;
            }

            if (!IsRouteValid())
            {
                return;
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