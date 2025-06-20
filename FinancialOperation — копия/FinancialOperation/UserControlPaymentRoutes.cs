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
    public partial class UserControlPaymentRoutes : UserControl
    {
        private DatabaseContext? databaseContext;
        public UserControlPaymentRoutes()
        {
            InitializeComponent();
        }

        private void UserControlPaymentRoutes_Load(object sender, EventArgs e)
        {
            this.databaseContext = new DatabaseContext();
            this.databaseContext.Database.EnsureCreated();
            this.databaseContext.PaymentRoutes.Load();
            this.paymentRoutesBindingSource.DataSource = databaseContext.PaymentRoutes.Local.ToBindingList();

            using (var context = new DatabaseContext())
            {
                accountsBindingSource.DataSource = context.Accounts.ToList();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (var addPaymentRouteForm = new AddPaymentRoutes())
            {
                if (addPaymentRouteForm.ShowDialog() == DialogResult.OK)
                {
                    var newPaymentRoute = new PaymentRoutes
                    {
                        PaymentRoute_id = addPaymentRouteForm.PaymentRouteId,
                        AccountFrom_id = addPaymentRouteForm.AccountFromId,
                        AccountTo_id = addPaymentRouteForm.AccountToId,
                        Amount = addPaymentRouteForm.RouteAmount,
                        AdditionDate = addPaymentRouteForm.RouteAdditionDate,
                        Description = addPaymentRouteForm.RouteDescription
                    };

                    ProcessTransaction(newPaymentRoute);
                    databaseContext.PaymentRoutes.Add(newPaymentRoute);
                    databaseContext.SaveChanges();
                    dataGridView1.Refresh();
                }
            }
        }

        private void ProcessTransaction(PaymentRoutes route)
        {
            var accountFrom = databaseContext.Accounts.Find(route.AccountFrom_id);
            var accountTo = databaseContext.Accounts.Find(route.AccountTo_id);

            if (accountFrom != null && accountTo != null)
            {
                accountFrom.Balance -= route.Amount.Value;
                accountTo.Balance += route.Amount.Value;
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            string filterText = toolStripTextBox1.Text.ToLower();

            if (databaseContext != null)
            {
                var filteredPaymentRoutes = databaseContext.PaymentRoutes.Local.ToBindingList()
                    .Where(route => route.PaymentRoute_id.ToString().Contains(filterText) ||
                                    route.AccountFrom_id.ToString().Contains(filterText) ||
                                    route.AccountTo_id.ToString().Contains(filterText) ||
                                    route.Amount.ToString().Contains(filterText) ||
                                    route.AdditionDate.ToString("dd/MM/yyyy").Contains(filterText) ||
                                    route.Description.ToLower().Contains(filterText))
                    .ToList();

                paymentRoutesBindingSource.DataSource = filteredPaymentRoutes;
                dataGridView1.Refresh();
            }
        }
    }
}