using System;
using System.Collections.Generic;

#nullable disable

namespace Economy.Domain.Entities
{
    public partial class Amortizacion
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public decimal TasaPrestamo { get; set; }
        public decimal ValorInversion { get; set; }
        public int Plazo { get; set; }
        public short TipoAmortizacion { get; set; }
        public int? FneprojectId { get; set; }

        public virtual Fneproject Fneproject { get; set; }
        public virtual User User { get; set; }
    }
}
