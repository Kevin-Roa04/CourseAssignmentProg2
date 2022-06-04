using Economy.AppCore.IServices;
using Economy.AppCore.Processes;
using Economy.AppCore.Processes.Calculate;
using Economy.Domain.Entities;
using Economy.Domain.Enums;
using Economy.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Economy.AppCore.Services.InterestsServices
{
    class AnnuityServices : IInterestServices<Annuity>
    {
        private IInterestRepository<Annuity> repository;
        private IInterestRepository<Serie> SerieRepository;
        private IInterestRepository<Interest> InterestRepository;
        
        private ICalculateServices<Annuity> interestServices = new CalculateAnnuities();
        public AnnuityServices(IInterestRepository<Annuity> Prepository, IInterestRepository<Serie> serieRepository, IInterestRepository<Interest> interestRepository)
        {
            this.repository = Prepository;
            this.SerieRepository = serieRepository;
            this.InterestRepository = interestRepository;
        }
        public int Create(Annuity t)
        {
            #region Validate period
            List<object> objects = new List<object>();
            if (SerieRepository.GetIdProject(t.ProjectId) != null)
            {
                objects.AddRange(SerieRepository.GetIdProject(t.ProjectId));
            }
            if (InterestRepository.GetIdProject(t.ProjectId) != null)
            {
                objects.AddRange(InterestRepository.GetIdProject(t.ProjectId));
            }
            if (repository.GetIdProject(t.ProjectId) != null)
            {
                objects.AddRange(repository.GetIdProject(t.ProjectId));
            }
            if (!ValidateInterest.Validar<Annuity>(objects, t))
            {
                throw new ArgumentException($"the Serie cannot be since it is between the intervals of another interest.");
            }
            #endregion

            #region Assign the annuity type
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
            #endregion
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

        public List<Annuity> GetIdProject(int Id)
        {
            throw new NotImplementedException();
        }

        public int Update(Annuity t)
        {
            return repository.Update(t);
        }
    }
}
