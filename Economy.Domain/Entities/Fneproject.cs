using System;
using System.Collections.Generic;

#nullable disable

namespace Economy.Domain.Entities
{
    public partial class Fneproject
    {
        public Fneproject()
        {
            Amortizacions = new HashSet<Amortizacion>();
            Costs = new HashSet<Cost>();
            Depreciacions = new HashSet<Depreciacion>();
            InversionFnes = new HashSet<InversionFne>();
            Profits = new HashSet<Profit>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Amortizacion> Amortizacions { get; set; }
        public virtual ICollection<Cost> Costs { get; set; }
        public virtual ICollection<Depreciacion> Depreciacions { get; set; }
        public virtual ICollection<InversionFne> InversionFnes { get; set; }
        public virtual ICollection<Profit> Profits { get; set; }
    }
}
