using Economy.AppCore.IServices;
using Economy.Domain.Entities;
using Economy.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Economy.AppCore.Services
{
    public class ActivosService : IActivosService
    {
        private IActivosRepository activosRepository;
        public ActivosService(IActivosRepository activosRepository)
        {
            this.activosRepository = activosRepository;
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
            return activosRepository.GetAll();
        }

        public Activo GetById(int id)
        {
            return activosRepository.GetById(id);
        }

        public Activo GetByName(string name)
        {
            return activosRepository.GetByName(name);
        }

        public int Update(Activo t)
        {
            throw new NotImplementedException();
        }
    }
}
