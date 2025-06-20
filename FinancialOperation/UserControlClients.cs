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
    public partial class UserControlClients : UserControl
    {
        private DatabaseContext? databaseContext;
        public UserControlClients()
        {
            InitializeComponent();
        }

        private void UserControlClients_Load(object sender, EventArgs e)
        {
            this.databaseContext = new DatabaseContext();
            this.databaseContext.Database.EnsureCreated();
            this.databaseContext.Clients.Load();
            this.clientsBindingSource.DataSource = databaseContext.Clients.Local.ToBindingList();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (var addClientForm = new AddClients())
            {
                if (addClientForm.ShowDialog() == DialogResult.OK)
                {
                    var newClient = new Clients
                    {
                        Client_id = addClientForm.ClientId,
                        SurName = addClientForm.ClientSurName,
                        Name = addClientForm.ClientName,
                        MiddleName = addClientForm.ClientMiddleName,
                        Gender = addClientForm.ClientGender,
                        BirthDate = addClientForm.ClientBirthDate,
                        Mail = addClientForm.ClientMail,
                        AdditionDate = addClientForm.ClientAdditionDate
                    };

                    databaseContext.Clients.Add(newClient);
                    databaseContext.SaveChanges();
                    dataGridView1.Refresh();
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedClient = (Clients)dataGridView1.SelectedRows[0].DataBoundItem;

                using (var editClientForm = new AddClients(selectedClient))
                {
                    if (editClientForm.ShowDialog() == DialogResult.OK)
                    {
                        selectedClient.SurName = editClientForm.ClientSurName;
                        selectedClient.Name = editClientForm.ClientName;
                        selectedClient.MiddleName = editClientForm.ClientMiddleName;
                        selectedClient.Gender = editClientForm.ClientGender;
                        selectedClient.BirthDate = editClientForm.ClientBirthDate;
                        selectedClient.Mail = editClientForm.ClientMail;
                        selectedClient.AdditionDate = editClientForm.ClientAdditionDate;

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
                var selectedClient = (Clients)dataGridView1.SelectedRows[0].DataBoundItem;

                var confirmResult = MessageBox.Show("Вы уверены, что нужно удалить этот элемент?", "Подтвердите удаление", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    databaseContext.Clients.Remove(selectedClient);
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
                var filteredClients = databaseContext.Clients.Local.ToBindingList()
                    .Where(client => client.Client_id.ToString().Contains(filterText) ||
                                     (client.SurName != null && client.SurName.ToLower().Contains(filterText)) ||
                                     (client.Name != null && client.Name.ToLower().Contains(filterText)) ||
                                     (client.MiddleName != null && client.MiddleName.ToLower().Contains(filterText)) ||
                                     (client.Gender != null && client.Gender.ToLower().Contains(filterText)) ||
                                     (client.BirthDate.ToString("yyyy-MM-dd").Contains(filterText)) ||
                                     (client.Mail != null && client.Mail.ToLower().Contains(filterText)) ||
                                     (client.AdditionDate.ToString("yyyy-MM-dd").Contains(filterText)))
                    .ToList();

                clientsBindingSource.DataSource = filteredClients;
                dataGridView1.Refresh();
            }
        }
    }
}