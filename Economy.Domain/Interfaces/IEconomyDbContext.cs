using Economy.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Economy.Domain.Interfaces
{
   public interface IEconomyDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Annuity> Annuities { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Activo> Activos { get; set; }
        public DbSet<Fne> Fnes { get; set; }
        public DbSet<Amortizacion> Amortizacions { get; set; }
        public DbSet<Cost> Costs { get; set; }
        public DbSet<Depreciacion> Depreciacions { get; set; }
        public DbSet<InversionFne> InversionFnes { get; set; }
        public DbSet<Profit> Profits { get; set; }
        public int SaveChanges();
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
