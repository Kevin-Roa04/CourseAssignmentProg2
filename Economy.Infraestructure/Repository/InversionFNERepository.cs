using Economy.Domain.Entities;
using Economy.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            InversionFne inversionFne = GetById(t.Id);
            if(inversionFne == null) return false;
            context.InversionFnes.Remove(inversionFne);
            context.SaveChanges();
            return true;
        }

        public List<InversionFne> GetAll()
        {
            throw new NotImplementedException();
        }

        public InversionFne GetById(int id)
        {
            return context.InversionFnes.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<InversionFne> GetByProjectId(int projectId)
        {
            return context.InversionFnes.Where(x => x.ProjectId == projectId).ToList();
        }

        public InversionFne GetByName(string name, int projectId)
        {
            List<InversionFne> inversionfne = context.InversionFnes.Where(x => x.ProjectId == projectId).Include(a => a.Activo).ToList();
            return inversionfne.Where(x => x.Activo.NombreActivo == name).FirstOrDefault();
        }

        public List<InversionFne> GetListByProjectId(int projectId)
        {
            return context.InversionFnes.Where(x => x.ProjectId == projectId).Include(a => a.Activo).ToList();
        }

        public int Update(InversionFne t)
        {
            InversionFne inversionFne = GetById(t.Id);
            if(inversionFne == null) return 0;
            inversionFne.Monto = t.Monto;
            context.InversionFnes.Update(inversionFne);
            return context.SaveChanges();
        }
    }
}
