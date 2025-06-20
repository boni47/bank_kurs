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
    public partial class AddAccountTypes : Form
    {
        public int AccountTypeId => (int)numericUpDown1.Value;
        public string AccountTypeName => textBox1.Text;
        public string AccountTypeDescription => textBox2.Text;

        private bool isEditing;

        public AddAccountTypes()
        {
            InitializeComponent();
            isEditing = false;
            this.Size = new Size(310, 180);
        }

        public AddAccountTypes(AccountTypes selectedAccountType) : this()
        {
            numericUpDown1.Value = selectedAccountType.AccountType_id;
            textBox1.Text = selectedAccountType.Name;
            textBox2.Text = selectedAccountType.Description;
            numericUpDown1.Enabled = false;
            button3.Visible = true;
            button1.Visible = false;
            isEditing = true;
        }

        private void AddAccountTypes_Load(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                numericUpDown1.Value = GetNextAccountTypeId();
            }
        }

        private int GetNextAccountTypeId()
        {
            using (var context = new DatabaseContext())
            {
                if (!context.AccountTypes.Any())
                {
                    return 1;
                }

                var existingIds = context.AccountTypes.Select(t => t.AccountType_id).ToList();
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
            if (AccountTypeId <= 0 || string.IsNullOrWhiteSpace(AccountTypeName) || string.IsNullOrWhiteSpace(AccountTypeDescription))
            {
                MessageBox.Show("Пожалуйста, заполните все поля действительными данными.");
                return;
            }

            using (var context = new DatabaseContext())
            {
                if (context.AccountTypes.Any(bt => bt.AccountType_id == AccountTypeId))
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
            if (string.IsNullOrWhiteSpace(AccountTypeName) || string.IsNullOrWhiteSpace(AccountTypeDescription))
            {
                MessageBox.Show("Пожалуйста, заполните все поля действительными данными.");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}