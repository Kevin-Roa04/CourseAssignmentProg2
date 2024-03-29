﻿using Economy.AppCore.IServices;
using Economy.AppCore.Processes;
using Economy.AppCore.Processes.Calculate;
using Economy.Domain.Entities;
using Economy.Domain.Enums;
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

            if (t.Quantity <= 0)
            {
                throw new ArgumentException("La tasa o la cantidad no puede ser 0.");
            }
            if (t.Rate <= 0)
            {
                throw new ArgumentException("La tasa no debe de ser 0.");
            }
            
            #region Validate number period
            if (t.Initial < 0 || t.End < 0)
            {
                throw new ArgumentException("The initial period or the final period must not be less than 0");
            }
            if (t.Initial > t.End)
            {
                throw new ArgumentException("The initial period must not be longer than the final period");
            }
            else if (t.End > t.TotalPeriod || t.Initial > t.TotalPeriod)
            {
                throw new ArgumentException("the initial period or the final period must not be longer than the total period");
            }
            else if (t.End == t.Initial)
            {
                throw new ArgumentException("The initial period must not be equal than the final period");
            }
            #endregion
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
            //if (!ValidateInterest.Validar<Serie>(objects, t))
            //{
            //    throw new ArgumentException($"the Serie cannot be since it is between the intervals of another interest.");
            //}

            #endregion
            #region Assing value
            if (t.Type == TypeSeries.Arithmetic.ToString())
            {
                if (t.Quantity == 0.0M)
                {

                    t.Quantity =Math.Round((decimal) (t.FinalPayment - t.DownPayment) / ((t.End - t.Initial)),2);
                    t.Quantity = Math.Abs(t.Quantity);
                }
                else if (t.DownPayment == 0.0M)
                {
                    if (!t.Incremental)
                    {
                      t.DownPayment = Math.Round((decimal)(t.FinalPayment + (((t.End-t.Initial) ) * t.Quantity)), 2);
                    }
                    else
                        t.DownPayment = Math.Round((decimal)(t.FinalPayment - (((t.End-t.Initial))*t.Quantity)),2);
                }
                else if (t.FinalPayment == 0.0M)
                {
                    if (!t.Incremental)
                    {
                        t.FinalPayment = Math.Round((decimal)(t.DownPayment -(((t.End-t.Initial)) * t.Quantity)), 2);
                        if (t.FinalPayment < 0)
                        {
                            throw new ArgumentException("Al hacer el decremento el pago final no debería ser menor que 0, compruebe la cantidad monetaria o el pago inicial.");
                        }
                    }
                    else
                    {
                        t.FinalPayment = Math.Round((decimal)(t.DownPayment + (((t.End-t.Initial)) * t.Quantity)), 2);
                    }
                   
                }
            }
            if (t.Type == TypeSeries.Geometric.ToString())
            {
                if (t.Quantity == 0.0M)
                {
                    double exponent = ((double)1 / (double)(t.End - t.Initial));
                    t.Quantity =Math.Round( (decimal)(Math.Pow((double)(t.FinalPayment/t.DownPayment), exponent)-1)*100 ,2);
                    t.Quantity = Math.Abs(t.Quantity);
                }
                else if (t.DownPayment == 0.0M)
                {
                    decimal decimalPercent = t.Quantity / 100;
                    if (!t.Incremental)
                    {
                      t.DownPayment= Math.Round((decimal)(t.FinalPayment) / (decimal)Math.Pow((double)(1  -decimalPercent), (t.End-t.Initial)), 2);
                    }
                    else
                        t.DownPayment = Math.Round((decimal)(t.FinalPayment) / (decimal)Math.Pow((double)(1 + decimalPercent), (t.End-t.Initial) ), 2);
                }
                else if (t.FinalPayment == 0.0M)
                {
                    decimal decimalPercent = t.Quantity / 100;
                    if (!t.Incremental)
                    {
                        t.FinalPayment = Math.Round((decimal)t.DownPayment * (decimal)(Math.Pow((double)(1 - decimalPercent), t.End - 1)), 2);
                        if (t.FinalPayment < 0)
                        {
                            throw new ArgumentException("Al hacer el decremento el pago final no debería ser menor que 0, compruebe la cantidad porcentual o el pago inicial.");
                        }
                    }
                    else
                        t.FinalPayment = Math.Round((decimal)t.DownPayment * (decimal)(Math.Pow((double)(1 + decimalPercent), t.End - 1)), 2);
                }
                
            }
#endregion
            t.Present = Math.Round(interestServices.Present(t), 2);
            t.Future = Math.Round(interestServices.Future(t), 2);
            return repository.Create(t);
        }
       
        public bool Delete(Serie t)
        {
            return repository.Delete(t);
        }

        public List<Serie> FindByOption(Func<Serie, bool> where)
        {
          return repository.FindByOption(where);
        }

        public List<Serie> GetAll()
        {
            return repository.GetAll();
        }

        public List<Serie> GetIdProject(int Id)
        {
            return repository.GetIdProject(Id);
        }

        public int GlobalUpdate(int Duration, decimal rate, int projectID, int userID)
        {
            throw new NotImplementedException();
        }

        public int Update(Serie t)
        {
            t.Future = Math.Round(interestServices.Future(t), 2);
            t.Present = Math.Round(interestServices.Present(t), 2);
            return repository.Update(t);
        }
    }
}
