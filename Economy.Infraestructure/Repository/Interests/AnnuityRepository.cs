using Economy.Domain.Entities;
using Economy.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Infraestructure.Repository.Interests
{
    public class AnnuityRepository : IRepository<Annuity>
    {
        public IEconomyDbContext economyDbContext;
        public AnnuityRepository(IEconomyDbContext economyDbContext)
        {
            this.economyDbContext = economyDbContext;
        }
        public int Create(Annuity t)
        {
            try
            {
                if (t is null)
                {
                    throw new ArgumentException($"The object Serie doesn't be null ");
                }

                economyDbContext.Annuities.Add(t);
                return economyDbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public bool Delete(Annuity t)
        {
            try
            {
                if (t == null)
                {
                    throw new ArgumentException("The object t isn't be a null");
                }
                Annuity annuity = GetAll().Where(x => x.Id == t.Id && x.ProjectId == t.ProjectId).ToList().First();
                if (annuity == null)
                {
                    throw new Exception($"The object with Id: {t.Id} don't exist");
                }
                economyDbContext.Annuities.Remove(t);
                return true ? economyDbContext.SaveChanges() > 0 : false;
            }
            catch
            {
                throw;
            }
        }

        public List<Annuity> GetAll()
        {
            return economyDbContext.Annuities.ToList();
        }

        public int Update(Annuity t)
        {

            try
            {
                if (t == null)
                {
                    throw new ArgumentException($"The object User doesn't be null");
                }
                Annuity annuity= GetAll().Where(x => x.Id == t.Id && x.ProjectId == t.ProjectId).First();
                if (annuity is null)
                {
                    throw new ArgumentException($"The object with Id: {annuity.Id} doesn't exist");
                }
                economyDbContext.Annuities.Update(t);
                return economyDbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
