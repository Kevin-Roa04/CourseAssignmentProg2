using Economy.AppCore.IServices;
using Economy.Domain.Entities;
using Economy.Domain.Interfaces;
using System.Collections.Generic;

namespace Economy.AppCore.Services.InterestsServices
{
    public class InterestServices : IServices<Interest>
    {
        private IRepository<Interest> repository;
        public InterestServices(IRepository<Interest> Prepository)
        {
            this.repository = Prepository;
        }
        public int Create(Interest t)
        {
            return repository.Create(t);
        }

        public bool Delete(Interest t)
        {
            return repository.Delete(t);
        }

        public List<Interest> GetAll()
        {
            return repository.GetAll();
        }

        public int Update(Interest t)
        {
            return repository.Update(t);
        }
    }
}
