using System;
using System.Collections.Generic;

#nullable disable

namespace Economy.Domain.Entities
{
    public partial class Activo
    {
        public Activo()
        {
            InversionFnes = new HashSet<InversionFne>();
        }

        public int Id { get; set; }
        public string NombreActivo { get; set; }
        public string DescripcionActivo { get; set; }
        public short VidaUtil { get; set; }
        public bool Depreciable { get; set; }

        public virtual ICollection<InversionFne> InversionFnes { get; set; }
    }
}
