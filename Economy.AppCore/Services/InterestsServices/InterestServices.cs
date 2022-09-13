using Economy.AppCore.IServices;
using Economy.AppCore.Processes;
using Economy.AppCore.Processes.Calculate;
using Economy.Domain.Entities;
using Economy.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Economy.AppCore.Services.InterestsServices
{
    public class InterestServices : IInterestServices<Interest>
    {
        IInterestRepository<Interest> repository;
        IInterestRepository<Annuity> AnnuityRepository;
        IInterestRepository<Serie> SerieRepository;
        private ICalculateServices<Interest> interestServices = new CalculateInterest();
        public InterestServices(IInterestRepository<Interest> Prepository,IInterestRepository<Annuity> annuityRepository, IInterestRepository<Serie> serieRepository)
        {
            this.repository = Prepository;
            this.AnnuityRepository = annuityRepository;
            this.SerieRepository = serieRepository;
        }
        public int Create(Interest t)
        {
            if (t.Payment < 0)
            {
                throw new ArgumentException("The payment must not be negative");
            }
            if (t.Rate <= 0)
            {
                throw new ArgumentException("La tasa no debe de ser negativa.");
            }
            #region validate number period
            if (t.Initial < 0)
            {
                throw new ArgumentException("The initial period must not be less than 0");
            }
            else if (t.Initial > t.TotalPeriod)
            {
                throw new ArgumentException("the initial period must not be longer than the total period");
            }
            #endregion
            #region Validate period
            List<object> objects = new List<object>();
            if (SerieRepository.GetIdProject(t.ProjectId) != null)
            {
                objects.AddRange(SerieRepository.GetIdProject(t.ProjectId));
            }
            if (AnnuityRepository.GetIdProject(t.ProjectId) != null)
            {
                objects.AddRange(AnnuityRepository.GetIdProject(t.ProjectId));
            }
            if (repository.GetIdProject(t.ProjectId) != null)
            {
                objects.AddRange(repository.GetIdProject(t.ProjectId));
            }
            //if (!ValidateInterest.Validar<Interest>(objects, t))
            //{
            //    throw new ArgumentException($"the Serie cannot be since it is between the intervals of another interest.");
            //}
            #endregion
            t.Future = Math.Round(interestServices.Future(t), 2);
            t.Present = Math.Round(interestServices.Present(t), 2);
            return repository.Create(t);
        }

        public bool Delete(Interest t)
        {
            return repository.Delete(t);
        }

        public List<Interest> FindByOption(Func<Interest, bool> where)
        {
            return repository.FindByOption(where);
        }

        public List<Interest> GetAll()
        {
            return repository.GetAll();
        }

        public List<Interest> GetIdProject(int Id)
        {
            return this.repository.GetIdProject(Id);
        }

        public int Update(Interest t)
        {
            return repository.Update(t);
        }
    }
}
