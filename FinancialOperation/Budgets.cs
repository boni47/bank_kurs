using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialOperation
{
    public class Budgets
    {
        [Key]
        public int Budget_id { get; set; }
        public int? Client_id { get; set; }
        public int? BudgetType_id { get; set; }
        public string? Name { get; set; }
        [Column(TypeName = "decimal(15, 2)")]
        public decimal? Amount { get; set; }
        public int? Currency_id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime AdditionDate { get; set; }
    }
}