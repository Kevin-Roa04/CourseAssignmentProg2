using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Domain.Entities.DTO
{
    public class AmortizationDTO
    {
        public int Year { get; set; }
        public double Credit_memo { get; set; }
        public double interest { get; set; }
        public double payment { get; set; }
        public double outstanding_balance { get; set; }
    }
}
