using System;
using System.Collections.Generic;

#nullable disable

namespace Economy.Domain.Entities
{
    public partial class Depreciacion
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? ActivoId { get; set; }
        public short TipoDepreciacion { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorResidual { get; set; }
        public int? ProjectId { get; set; }

        public virtual Activo Activo { get; set; }
        public virtual Project Project { get; set; }
        public virtual User User { get; set; }
    }
}
