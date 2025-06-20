using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialOperation
{
    public class AccountTypes
    {
        [Key]
        public int AccountType_id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}