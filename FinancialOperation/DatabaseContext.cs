using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialOperation
{
    public class DatabaseContext : DbContext
    {
        public DbSet<BudgetTypes> BudgetTypes { get; set; }
        public DbSet<AccountTypes> AccountTypes { get; set; }
        public DbSet<Currencies> Currencies { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<Budgets> Budgets { get; set; }
        public DbSet<Logs> Logs { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<PaymentRoutes> PaymentRoutes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=FinancialOperations;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;");
        }
    }
}