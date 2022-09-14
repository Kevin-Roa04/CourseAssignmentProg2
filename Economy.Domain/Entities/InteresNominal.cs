using Economy.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Domain.Entities
{
     public class InteresNominal
    {
        public double Futuro { get; set; }
        public double presente { get; set; }
        public double nominal { get; set; }

        public double periodo { get; set; }
        public Producto producto { get; set; }

    }
}
