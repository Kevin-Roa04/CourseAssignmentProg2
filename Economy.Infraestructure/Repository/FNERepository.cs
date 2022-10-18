using Economy.Domain.Entities;
using Economy.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Infraestructure.Repository
{
    public class FNERepository : IFNERepository
    {
        private IEconomyDbContext context;
        public FNERepository(IEconomyDbContext context)
        {
            this.context = context;
        }
        public int Create(Fne t)
        {
            context.Fnes.Add(t);
            return context.SaveChanges();
        }

        public bool Delete(Fne t)
        {
            throw new NotImplementedException();
        }

        public List<Fne> GetAll()
        {
            throw new NotImplementedException();
        }

        public Fne GetByProjectId(int? ProjectId)
        {
            return context.Fnes.Where(x => x.ProjectId == ProjectId).FirstOrDefault();
        }

        public int Update(Fne t)
        {
            Fne fne = GetByProjectId(t.ProjectId);
            if(fne == null) return 0;

            fne.Years = t.Years;
            fne.Tmar = t.Tmar;
            context.Fnes.Update(fne);
            return context.SaveChanges();
        }
    }
}
