using System;
using System.Collections.Generic;

#nullable disable

namespace Economy.Domain.Entities
{
    public partial class Project
    {
        public Project()
        {
            Amortizacions = new HashSet<Amortizacion>();
            Annuities = new HashSet<Annuity>();
            Costs = new HashSet<Cost>();
            Depreciacions = new HashSet<Depreciacion>();
            Interests = new HashSet<Interest>();
            InversionFnes = new HashSet<InversionFne>();
            Profits = new HashSet<Profit>();
            Series = new HashSet<Serie>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public DateTime Creation { get; set; }
        public string Type { get; set; }
        public string Path { get; set; }
        public string Period { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Amortizacion> Amortizacions { get; set; }
        public virtual ICollection<Annuity> Annuities { get; set; }
        public virtual ICollection<Cost> Costs { get; set; }
        public virtual ICollection<Depreciacion> Depreciacions { get; set; }
        public virtual ICollection<Interest> Interests { get; set; }
        public virtual ICollection<InversionFne> InversionFnes { get; set; }
        public virtual ICollection<Profit> Profits { get; set; }
        public virtual ICollection<Serie> Series { get; set; }
    }
}
