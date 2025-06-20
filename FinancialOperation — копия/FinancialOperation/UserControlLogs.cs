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
    public partial class UserControlLogs : UserControl
    {
        private DatabaseContext? databaseContext;
        public UserControlLogs()
        {
            InitializeComponent();
        }

        private void UserControlLogs_Load(object sender, EventArgs e)
        {
            this.databaseContext = new DatabaseContext();
            this.databaseContext.Database.EnsureCreated();
            this.databaseContext.Logs.Load();
            this.logsBindingSource.DataSource = databaseContext.Logs.Local.ToBindingList();

            using (var context = new DatabaseContext())
            {
                accountsBindingSource.DataSource = context.Accounts.ToList();
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            string filterText = toolStripTextBox1.Text.ToLower();

            if (databaseContext != null)
            {
                var filteredLogs = databaseContext.Logs.Local.ToBindingList()
                    .Where(log => log.Log_id.ToString().Contains(filterText) ||
                                  log.Account_id.ToString().Contains(filterText) ||
                                  log.Operation.ToLower().Contains(filterText) ||
                                  log.AdditionDate.ToString("dd/MM/yyyy").Contains(filterText) ||
                                  log.Amount.ToString().Contains(filterText))
                    .ToList();

                logsBindingSource.DataSource = filteredLogs;
                dataGridView1.Refresh();
            }
        }
    }
}