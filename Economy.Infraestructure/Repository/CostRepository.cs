using Economy.Domain.Entities;
using Economy.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Infraestructure.Repository
{
    public class CostRepository : ICostRepository
    {
        private IEconomyDbContext context;
        public CostRepository (IEconomyDbContext context)
        {
            this.context = context;
        }
        public int Create(Cost t)
        {
            context.Costs.Add(t);
            return context.SaveChanges();
        }

        public bool Delete(Cost t)
        {
            throw new NotImplementedException();
        }

        public List<Cost> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Cost> GetByProjectId(int projectId)
        {
            throw new NotImplementedException();
        }

        public int Update(Cost t)
        {
            throw new NotImplementedException();
        }
    }
}
