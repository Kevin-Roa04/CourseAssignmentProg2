using System;
using System.Collections.Generic;

#nullable disable

namespace Economy.Domain.Entities
{
    public partial class User
    {
        public User()
        {
            Amortizacions = new HashSet<Amortizacion>();
            Depreciacions = new HashSet<Depreciacion>();
            Fneprojects = new HashSet<Fneproject>();
            Projects = new HashSet<Project>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Amortizacion> Amortizacions { get; set; }
        public virtual ICollection<Depreciacion> Depreciacions { get; set; }
        public virtual ICollection<Fneproject> Fneprojects { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
