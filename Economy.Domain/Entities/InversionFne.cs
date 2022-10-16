using System;
using System.Collections.Generic;

#nullable disable

namespace Economy.Domain.Entities
{
    public partial class InversionFne
    {
        public int Id { get; set; }
        public decimal Monto { get; set; }
        public int ActivoId { get; set; }
        public int FneprojectId { get; set; }

        public virtual Activo Activo { get; set; }
        public virtual Fneproject Fneproject { get; set; }
    }
}
