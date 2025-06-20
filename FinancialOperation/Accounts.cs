using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialOperation
{
    public class Accounts
    {
        [Key]
        public int Account_id { get; set; }
        public int? Client_id { get; set; }
        public int? AccountType_id { get; set; }
        public string? Number { get; set; }
        [Column(TypeName = "decimal(15, 2)")]
        public decimal? Balance { get; set; }
        public int? Currency_id { get; set; }
        public DateTime AdditionDate { get; set; }
    }
}