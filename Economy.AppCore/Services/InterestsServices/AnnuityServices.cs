using Economy.AppCore.IServices;
using Economy.AppCore.Processes.Calculate;
using Economy.Domain.Entities;
using Economy.Domain.Enums;
using Economy.Domain.Interfaces;
using System.Collections.Generic;

namespace Economy.AppCore.Services.InterestsServices
{
    class AnnuityServices : IServices<Annuity>
    {
        private IRepository<Annuity> repository;
        private IRepository<Serie> serieRepository;
        private IRepository<Interest> interestRepository;
        
        private IInterestServices<Annuity> interestServices = new CalculateAnnuities();
        public AnnuityServices(IRepository<Annuity> Prepository)
        {
            this.repository = Prepository;
        }
        public int Create(Annuity t)
        {
            
            if (t.Initial == 1)
            {
                t.Type = TypeAnnuities.Ordinary.ToString();
            }
            else if (t.Initial == 0)
            {
                t.Type = TypeAnnuities.Anticipated.ToString();
            }
            else if (t.Initial > 1)
            {
                t.Type = TypeAnnuities.Deferred.ToString();
            }
            t.Future = interestServices.Future(t);
            t.Present = interestServices.Present(t);
            return repository.Create(t);
        }

        public bool Delete(Annuity t)
        {
            return repository.Delete(t);
        }

        public List<Annuity> GetAll()
        {
            return repository.GetAll();
        }

        public int Update(Annuity t)
        {
            return repository.Update(t);
        }
    }
}
