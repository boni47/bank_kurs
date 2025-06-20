using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialOperation
{
    public class Logs
    {
        [Key]
        public int Log_id { get; set; }
        public DateTime AdditionDate { get; set; }
        public int? Account_id { get; set; }
        public string? Operation { get; set; }
        [Column(TypeName = "decimal(15, 2)")]
        public decimal? Amount { get; set; }
    }
}