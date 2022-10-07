using System;
using System.Collections.Generic;

#nullable disable

namespace Economy.Domain.Entities
{
    public partial class Project
    {
        public Project()
        {
            Annuities = new HashSet<Annuity>();
            Interests = new HashSet<Interest>();
            Series = new HashSet<Serie>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public DateTime Creation { get; set; }
        public string Type { get; set; }
        public string Period { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Annuity> Annuities { get; set; }
        public virtual ICollection<Interest> Interests { get; set; }
        public virtual ICollection<Serie> Series { get; set; }
    }
}
