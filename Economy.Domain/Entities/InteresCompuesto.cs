using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entities
{
   public  class InteresCompuesto
    {
        // Incognitas 
        public double Presente { get; set; }
        public double Futuro { get; set; }
        public decimal Interes { get; set; }
        public int  Periodos { get; set; }

        
    }
}
