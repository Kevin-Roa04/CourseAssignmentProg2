using System;
using System.Collections.Generic;

#nullable disable

namespace Economy.Domain.Entities
{
    public partial class Profit
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal ValorInicial { get; set; }
        public short TipoIncremento { get; set; }
        public decimal ValorIncremento { get; set; }
        public int FneprojectId { get; set; }

        public virtual Fneproject Fneproject { get; set; }
    }
}
