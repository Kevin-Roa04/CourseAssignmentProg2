using Economy.Domain.Entities;
using Economy.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Infraestructure.Repository
{
    public class InversionFNERepository : IInversionFNERepository
    {
        private IEconomyDbContext context;
        public InversionFNERepository(IEconomyDbContext context)
        {
            this.context = context;
        }
        public int Create(InversionFne t)
        {
            context.InversionFnes.Add(t);
            return context.SaveChanges();
        }

        public bool Delete(InversionFne t)
        {
            throw new NotImplementedException();
        }

        public List<InversionFne> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<InversionFne> GetByProjectId(int Projectid)
        {
            throw new NotImplementedException();
        }

        public int Update(InversionFne t)
        {
            throw new NotImplementedException();
        }
    }
}
