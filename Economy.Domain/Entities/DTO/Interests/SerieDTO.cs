using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Domain.Entities.DTO.Interests
{
    public class SerieDTO
    {
        public int Id { get; set; }
        public int Inicio { get; set; }
        public int Final { get; set; }
        public decimal? PagoInicial { get; set; }
        public decimal? PagoFinal { get; set; }
        public decimal Cantidad { get; set; }
        public decimal? Presente { get; set; }
        public decimal? Futuro { get; set; }
        public string Tipo { get; set; }
        public string Flujo { get; set; }
        public decimal Tasa { get; set; }
        public bool Incremental { get; set; }
    }
}
