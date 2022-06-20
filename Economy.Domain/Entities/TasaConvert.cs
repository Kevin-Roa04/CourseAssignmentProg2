using Dominio.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public  class TasaConvert
    {
        public decimal Tasa1 { get; set; }
        public  decimal Tasa2 { get; set; }
        public Convertion Conver { get; set; }
        public PeriodTime Time { get; set; }

        

    }
}
