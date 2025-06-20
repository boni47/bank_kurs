using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.ComponentModel;
using System.Windows.Forms;

namespace FinancialOperation
{
    public partial class Main : Form
    {
        private UserControl activeControl = null; // Текущий активный UserControl

        public Main()
        {
            InitializeComponent();
            LoadControl(new UserControlClients()); // Загружаем начальный экран
        }

        private void LoadControl(UserControl newControl) // Метод для загрузки нового UserControl
        {
            if (activeControl != null) // Убираем текущий UserControl, если он есть
                this.Controls.Remove(activeControl);

            activeControl = newControl; // Устанавливаем новый UserControl
            activeControl.Dock = DockStyle.Fill;

            this.Controls.Add(activeControl); // Добавляем новый UserControl на MainForm
            activeControl.BringToFront();
        }

        private void типСчетаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new UserControlAccountTypes());
        }
        private void типыБюджетовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new UserControlBudgetTypes());
        }

        private void типыВалютToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new UserControlCurrencies());
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new UserControlClients());
        }

        private void счетаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new UserControlAccounts());
        }

        private void бюджетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new UserControlBudgets());
        }

        private void журналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new UserControlLogs());
        }

        private void транзакцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new UserControlTransactions());
        }

        private void платежныеМаршрутыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new UserControlPaymentRoutes());
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var info = new Info())
            {
                if (info.ShowDialog() == DialogResult.OK) { }
            }
        }
    }
}