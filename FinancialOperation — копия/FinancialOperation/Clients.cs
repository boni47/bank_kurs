using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialOperation
{
    public class Clients
    {
        [Key]
        public int Client_id { get; set; }
        public string? SurName { get; set; }
        public string? Name { get; set; }
        public string? MiddleName { get; set; }
        public string? Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Mail { get; set; }
        public DateTime AdditionDate { get; set; }
    }
}