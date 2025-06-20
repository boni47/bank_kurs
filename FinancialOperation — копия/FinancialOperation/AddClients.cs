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
    public partial class AddClients : Form
    {
        public int ClientId => (int)numericUpDown1.Value;
        public string ClientSurName => textBox1.Text;
        public string ClientName => textBox2.Text;
        public string ClientMiddleName => textBox3.Text;
        public string ClientGender => comboBox1.SelectedItem.ToString();
        public DateTime ClientBirthDate => dateTimePicker1.Value;
        public string ClientMail => textBox4.Text;
        public DateTime ClientAdditionDate => dateTimePicker2.Value;

        private Clients client;

        public AddClients()
        {
            InitializeComponent();
            this.Size = new Size(350, 330);
        }

        public AddClients(Clients client) : this()
        {
            this.client = client;
        }

        private void AddClients_Load(object sender, EventArgs e)
        {
            if (client != null)
            {
                numericUpDown1.Value = client.Client_id;
                numericUpDown1.Enabled = false;
                button1.Visible = false;
                button3.Visible = true;
                textBox1.Text = client.SurName;
                textBox2.Text = client.Name;
                textBox3.Text = client.MiddleName;
                comboBox1.SelectedItem = client.Gender;
                dateTimePicker1.Value = client.BirthDate;
                textBox4.Text = client.Mail;
                dateTimePicker2.Value = client.AdditionDate;
            }
            if (client == null)
            {
                numericUpDown1.Value = GetNextClientId();
            }
        }

        private int GetNextClientId()
        {
            using (var context = new DatabaseContext())
            {
                if (!context.Clients.Any())
                {
                    return 1;
                }

                var existingIds = context.Clients.Select(t => t.Client_id).ToList();
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
            if (ClientId <= 0 || string.IsNullOrWhiteSpace(ClientSurName) || string.IsNullOrWhiteSpace(ClientName) || string.IsNullOrWhiteSpace(ClientSurName) || comboBox1.SelectedItem == null || ClientBirthDate > DateTime.Now || string.IsNullOrWhiteSpace(ClientMail) || ClientAdditionDate > DateTime.Now)
            {
                MessageBox.Show("Пожалуйста, заполните все поля действительными данными.");
                return;
            }

            using (var context = new DatabaseContext())
            {
                if (context.Clients.Any(a => a.Client_id == ClientId))
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
            if (ClientId <= 0 || string.IsNullOrWhiteSpace(ClientSurName) || string.IsNullOrWhiteSpace(ClientName) || string.IsNullOrWhiteSpace(ClientSurName) || comboBox1.SelectedItem == null || ClientBirthDate > DateTime.Now || string.IsNullOrWhiteSpace(ClientMail) || ClientAdditionDate > DateTime.Now)
            {
                MessageBox.Show("Пожалуйста, заполните все поля действительными данными.");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}