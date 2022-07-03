using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Domain.Entities
{
    public class Amortizacion
    {
        public int Id { get; set; }
        public double interes { get; set; }
        public double inversion { get; set; }
        public double plazo { get; set; }

        public double Abono { get; set; }
        public double Intereses { get; set; }
        public double Saldo { get; set; }
    }
}
