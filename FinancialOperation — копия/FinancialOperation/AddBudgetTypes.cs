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
    public partial class AddBudgetTypes : Form
    {
        public int BudgetTypeId => (int)numericUpDown1.Value;
        public string BudgetTypeName => textBox1.Text;
        public string BudgetTypeDescription => textBox2.Text;

        private bool isEditing;

        public AddBudgetTypes()
        {
            InitializeComponent();
            isEditing = false;
            this.Size = new Size(310, 180);
        }

        public AddBudgetTypes(BudgetTypes selectedBudgetType) : this()
        {
            numericUpDown1.Value = selectedBudgetType.BudgetType_id;
            textBox1.Text = selectedBudgetType.Name;
            textBox2.Text = selectedBudgetType.Description;
            numericUpDown1.Enabled = false; // Блокируем ID при редактировании
            button3.Visible = true; // Показываем кнопку "Сохранить"
            button1.Visible = false; // Скрываем кнопку "Добавить"
            isEditing = true; // Устанавливаем флаг редактирования
        }

        private void AddBudgetTypes_Load(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                numericUpDown1.Value = GetNextBudgetTypeId();
            }
        }

        private int GetNextBudgetTypeId()
        {
            using (var context = new DatabaseContext())
            {
                if (!context.BudgetTypes.Any())
                {
                    return 1;
                }

                var existingIds = context.BudgetTypes.Select(t => t.BudgetType_id).ToList();
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
            if (BudgetTypeId <= 0 || string.IsNullOrWhiteSpace(BudgetTypeName) || string.IsNullOrWhiteSpace(BudgetTypeDescription))
            {
                MessageBox.Show("Пожалуйста, заполните все поля действительными данными.");
                return;
            }

            using (var context = new DatabaseContext()) // Проверка на уникальность ID в базе данных
            {
                if (context.BudgetTypes.Any(bt => bt.BudgetType_id == BudgetTypeId))
                {
                    MessageBox.Show("Запись с таким идентификатором уже существует. Пожалуйста, введите уникальный идентификатор.");
                    return;
                }
            }

            this.DialogResult = DialogResult.OK; // Закрываем форму и возвращаем DialogResult.OK при успешном вводе
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Закрываем форму без сохранения
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BudgetTypeName) || string.IsNullOrWhiteSpace(BudgetTypeDescription))
            {
                MessageBox.Show("Пожалуйста, заполните все поля действительными данными.");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}