using Economy.AppCore.IServices;
using Economy.Domain.Entities;
using Economy.Domain.Interfaces;
using System.Collections.Generic;

namespace Economy.AppCore.Services.InterestsServices
{
    public class SerieServices : IServices<Serie>
    {
        private IRepository<Serie> repository;
        public SerieServices(IRepository<Serie> Prepository)
        {
            this.repository = Prepository;
        }
        public int Create(Serie t)
        {
            return repository.Create(t);
        }

        public bool Delete(Serie t)
        {
            return repository.Delete(t);
        }

        public List<Serie> GetAll()
        {
            return repository.GetAll();
        }

        public int Update(Serie t)
        {
            return repository.Update(t);
        }
    }
}
