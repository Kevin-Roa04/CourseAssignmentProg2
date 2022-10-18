using Economy.Domain.Entities;
using Economy.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Infraestructure.Repository
{
    public class DepreciacionRepository : IDepreciacionRepository
    {
        private IEconomyDbContext context;
        public DepreciacionRepository(IEconomyDbContext context)
        {
            this.context = context;
        }
        public int Create(Depreciacion t)
        {
            context.Depreciacions.Add(t);
            return context.SaveChanges();
        }

        public bool Delete(Depreciacion t)
        {
            throw new NotImplementedException();
        }

        public List<Depreciacion> GetAll()
        {
            throw new NotImplementedException();
        }

        public Depreciacion GetByProjectId(int? projectId)
        {
            return context.Depreciacions.Where(x => x.ProjectId == projectId).FirstOrDefault();
        }

        public int Update(Depreciacion t)
        {
            Depreciacion depreciacion = GetByProjectId(t.ProjectId);
            if (depreciacion == null) return 0;

            depreciacion.TipoDepreciacion = t.TipoDepreciacion;
            depreciacion.Valor = t.Valor;
            depreciacion.ValorResidual = t.ValorResidual;
            context.Depreciacions.Update(depreciacion);
            return context.SaveChanges();
        }
    }
}
