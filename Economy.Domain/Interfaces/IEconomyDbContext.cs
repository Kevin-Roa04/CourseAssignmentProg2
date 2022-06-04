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
        public int SaveChanges();
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
