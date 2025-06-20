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
    public partial class UserControlBudgetTypes : UserControl
    {
        private DatabaseContext? databaseContext;
        public UserControlBudgetTypes()
        {
            InitializeComponent();
        }

        private void UserControlBudgetTypes_Load(object sender, EventArgs e)
        {
            this.databaseContext = new DatabaseContext();
            this.databaseContext.Database.EnsureCreated();
            this.databaseContext.BudgetTypes.Load();
            this.budgetTypesBindingSource.DataSource = databaseContext.BudgetTypes.Local.ToBindingList();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddBudgetTypes()) // Создаём и открываем форму добавления новой записи
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    var newBudgetType = new BudgetTypes // Получаем новую запись из формы
                    {
                        BudgetType_id = addForm.BudgetTypeId,
                        Name = addForm.BudgetTypeName,
                        Description = addForm.BudgetTypeDescription
                    };

                    databaseContext.BudgetTypes.Add(newBudgetType); // Добавляем запись в базу данных и сохраняем изменения
                    databaseContext.SaveChanges();

                    dataGridView1.Refresh(); // Обновляем DataGridView
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Проверяем, выбрана ли строка для редактирования
            {
                var selectedBudgetType = (BudgetTypes)dataGridView1.SelectedRows[0].DataBoundItem; // Получаем выбранный объект `BudgetTypes` из `BindingSource`

                using (var editForm = new AddBudgetTypes(selectedBudgetType)) // Создаём форму для редактирования, заполняя её данными выбранной строки
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        selectedBudgetType.Name = editForm.BudgetTypeName; // Обновляем данные объекта на основе данных формы
                        selectedBudgetType.Description = editForm.BudgetTypeDescription;

                        databaseContext.SaveChanges();// Сохраняем изменения в базе данных
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
                var selectedBudgetType = (BudgetTypes)dataGridView1.SelectedRows[0].DataBoundItem; // Получаем выбранный объект `BudgetTypes` из `BindingSource`

                var confirmResult = MessageBox.Show("Вы уверены, что нужно удалить этот элемент?", "Подтвердите удаление", MessageBoxButtons.YesNo); // Подтверждаем удаление
                if (confirmResult == DialogResult.Yes)
                {
                    databaseContext.BudgetTypes.Remove(selectedBudgetType); // Удаляем элемент из базы данных
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
                var filteredBudgetTypes = databaseContext.BudgetTypes.Local.ToBindingList()
                    .Where(budgetType => budgetType.BudgetType_id.ToString().Contains(filterText) ||
                                         budgetType.Name.ToLower().Contains(filterText) ||
                                         budgetType.Description.ToLower().Contains(filterText))
                    .ToList();

                budgetTypesBindingSource.DataSource = filteredBudgetTypes;
                dataGridView1.Refresh();
            }
        }
    }
}