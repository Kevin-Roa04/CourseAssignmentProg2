using Economy.Domain.Entities;
using Economy.Domain.Enums;
using Economy.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Infraestructure.Repository.Interests
{
    public class InterestRepository : IInterestRepository<Interest>
    {
        public IEconomyDbContext economyDbContext;
        public InterestRepository(IEconomyDbContext economyDbContext)
        {
            this.economyDbContext = economyDbContext;
        }
        public int Create(Interest t)
        {
            try
            {
                if (t is null)
                {
                    throw new ArgumentException($"The object Serie doesn't be null ");
                }

                economyDbContext.Interests.Add(t);
                return economyDbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public bool Delete(Interest t)
        {

            try
            {
                if (t == null)
                {
                    throw new ArgumentException("The object t isn't be a null");
                }
                Interest interest = GetAll().Where(x => x.Id == t.Id && x.ProjectId == t.ProjectId).ToList().First();
                if (interest == null)
                {
                    throw new Exception($"The object with Id: {t.Id} don't exist");
                }
                economyDbContext.Interests.Remove(t);
                return true ? economyDbContext.SaveChanges() > 0 : false;
            }
            catch
            {
                throw;
            }
        }

        public List<Interest> FindByOption(Func<Interest, bool> where)
        {
            return economyDbContext.Interests.Where(where).ToList();
        }

        public List<Interest> GetAll()
        {
            return economyDbContext.Interests.ToList();
        }

        

        public List<Interest> GetIdProject(int Id)
        {
            return economyDbContext.Interests.Where(x => x.ProjectId == Id).ToList();
        }

        public int GlobalUpdate(int Duration, decimal rate, int projectID, int userID)
        {
            throw new NotImplementedException();
        }

        public int Update(Interest t)
        {


            try
            {
                if (t == null)
                {
                    throw new ArgumentException($"The object User doesn't be null");
                }
                Interest interest = GetAll().Where(x => x.Id == t.Id && x.ProjectId == t.ProjectId).First();
                if (interest is null)
                {
                    throw new ArgumentException($"The object with Id: {interest.Id} doesn't exist");
                }
                economyDbContext.Interests.Update(t);
                return economyDbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
