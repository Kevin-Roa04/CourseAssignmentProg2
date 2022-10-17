using Economy.Domain.Entities;
using Economy.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Infraestructure.Repository
{
    public class ActivosRepository : IActivosRepository
    {
        private IEconomyDbContext context;
        public ActivosRepository(IEconomyDbContext context)
        {
            this.context = context; 
        }
        public int Create(Activo t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Activo t)
        {
            throw new NotImplementedException();
        }

        public List<Activo> GetAll()
        {
            return context.Activos.ToList();
        }

        public Activo GetById(int id)
        {
            return context.Activos.Where(x => x.Id == id).FirstOrDefault();
        }

        public Activo GetByName(string name)
        {
            return context.Activos.Where(x => x.NombreActivo == name).FirstOrDefault();
        }

        public int Update(Activo t)
        {
            throw new NotImplementedException();
        }
    }
}
