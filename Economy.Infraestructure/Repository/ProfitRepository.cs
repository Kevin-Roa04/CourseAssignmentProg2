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
            Profit profit = GetByName(t.Nombre, t.ProjectId);
            if (profit == null) return false;
            context.Profits.Remove(profit);
            context.SaveChanges();
            return true;
        }

        public List<Profit> GetAll()
        {
            throw new NotImplementedException();
        }

        public Profit GetByName(string name, int projectId)
        {
            return context.Profits.Where(x => x.Nombre == name && x.ProjectId == projectId).FirstOrDefault();
        }

        public Profit GetById(int id)
        {
            return context.Profits.Where(p => p.Id == id).FirstOrDefault();
        }

        public List<Profit> GetListByProjectId(int projectId)
        {
            return context.Profits.Where(p => p.ProjectId == projectId).ToList();
        }

        public int Update(Profit t)
        {
            Profit profit = GetById(t.Id);
            if(profit == null) return 0;
            profit.Nombre = t.Nombre;
            profit.ValorInicial = t.ValorInicial;
            profit.TipoIncremento = t.TipoIncremento;
            profit.ValorIncremento = t.ValorIncremento;

            context.Profits.Update(profit);
            return context.SaveChanges();
        }
    }
}
