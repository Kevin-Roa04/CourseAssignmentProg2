using Economy.AppCore.IServices;
using Economy.AppCore.Processes;
using Economy.AppCore.Processes.Calculate;
using Economy.Domain.Entities;
using Economy.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Economy.AppCore.Services.InterestsServices
{
    public class SerieServices : IInterestServices<Serie>
    {
        IInterestRepository<Serie> repository;
        IInterestRepository<Annuity> AnnuityRepository;
        IInterestRepository<Interest> InterestRepository;
        private ICalculateServices<Serie> interestServices = new CalculateSerie();

        public SerieServices(IInterestRepository<Serie> Prepository, IInterestRepository<Annuity> annuity, IInterestRepository<Interest> interest)
        {
            this.repository = Prepository;
            this.AnnuityRepository = annuity;
            this.InterestRepository = interest;
        }
        public int Create(Serie t)
        {
            #region validate period
            List<object> objects = new List<object>();
            if (AnnuityRepository.GetIdProject(t.ProjectId)!=null)
            {
                objects.AddRange(AnnuityRepository.GetIdProject(t.ProjectId));
            }
            if (InterestRepository.GetIdProject(t.ProjectId) != null)
            {
                objects.AddRange(InterestRepository.GetIdProject(t.ProjectId));
            }
            if (repository.GetIdProject(t.ProjectId)!= null)
            {
                objects.AddRange(repository.GetIdProject(t.ProjectId));
            }
            if (!ValidateInterest.Validar<Serie>(objects, t))
            {
                throw new ArgumentException($"the Serie cannot be since it is between the intervals of another interest.");
            }

            #endregion

            t.Future = interestServices.Future(t);
            t.Present = interestServices.Present(t);
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

        public List<Serie> GetIdProject(int Id)
        {
            return repository.GetIdProject(Id);
        }

        public int Update(Serie t)
        {
            return repository.Update(t);
        }
    }
}
