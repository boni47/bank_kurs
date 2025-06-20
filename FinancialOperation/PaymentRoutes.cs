using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialOperation
{
    public class PaymentRoutes
    {
        [Key]
        public int PaymentRoute_id { get; set; }
        public int? AccountFrom_id { get; set; }
        public int? AccountTo_id { get; set; }
        [Column(TypeName = "decimal(15, 2)")]
        public decimal? Amount { get; set; }
        public DateTime AdditionDate { get; set; }
        public string? Description { get; set; }
    }
}