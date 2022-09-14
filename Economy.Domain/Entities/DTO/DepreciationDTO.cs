using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Domain.Entities.DTO
{
    public class DepreciationDTO
    {
        public int Year { get; set; }
        public double Depreciation { get; set; }
        public double Depreciation_Acumulada { get; set; }
        public double Valor_Libro { get; set; }
    }
}
