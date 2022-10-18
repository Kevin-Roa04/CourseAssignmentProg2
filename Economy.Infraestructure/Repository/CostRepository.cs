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
            Cost cost = GetByName(t.Nombre, t.ProjectId);
            if (cost == null) return false;
            context.Costs.Remove(cost);
            context.SaveChanges();
            return true;
        }

        public List<Cost> GetAll()
        {
            throw new NotImplementedException();
        }

        public Cost GetById(int id)
        {
            return context.Costs.Where(c => c.Id == id).FirstOrDefault();
        }

        public Cost GetByName(string name, int projectId)
        {
            return context.Costs.Where(x => x.Nombre == name && x.ProjectId == projectId).FirstOrDefault();
        }

        public List<Cost> GetListByProjectId(int projectId)
        {
            return context.Costs.Where(x => x.ProjectId == projectId).ToList();
        }

        public int Update(Cost t)
        {
            Cost cost = GetById(t.Id);
            if (cost == null) return 0;
            cost.Nombre = t.Nombre;
            cost.ValorInicial = t.ValorInicial;
            cost.TipoIncremento = t.TipoIncremento;
            cost.ValorIncremento = t.ValorIncremento;

            context.Costs.Update(cost);
            return context.SaveChanges();
        }
    }
}
