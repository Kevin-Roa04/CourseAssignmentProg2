using System;
using System.Collections.Generic;

#nullable disable

namespace Economy.Domain.Entities
{
    public partial class Depreciacion
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public short TipoDepreciacion { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorResidual { get; set; }
        public int? FneprojectId { get; set; }

        public virtual Fneproject Fneproject { get; set; }
        public virtual User User { get; set; }
    }
}
