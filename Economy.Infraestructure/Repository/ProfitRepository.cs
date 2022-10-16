using Economy.Domain.Entities;
using Economy.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Infraestructure.Repository
{
    public class ProfitRepository : IProfitRepository
    {
        IEconomyDbContext context;
        public ProfitRepository(IEconomyDbContext context)
        {
            this.context = context;
        }

        public int Create(Profit t)
        {
            context.Profits.Add(t);
            return context.SaveChanges();
        }

        public bool Delete(Profit t)
        {
            throw new NotImplementedException();
        }

        public List<Profit> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Update(Profit t)
        {
            throw new NotImplementedException();
        }
    }
}
