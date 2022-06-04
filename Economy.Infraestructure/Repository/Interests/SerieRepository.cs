using Economy.Domain.Entities;
using Economy.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Infraestructure.Repository.Interests
{
    public class SerieRepository :IInterestRepository<Serie>
    {
        public IEconomyDbContext economyDbContext;
        public SerieRepository(IEconomyDbContext economyDbContext)
        {
            this.economyDbContext = economyDbContext;
        }
        public int Create(Serie t)
        {
            try
            {
                if (t is null)
                {
                    throw new ArgumentException($"The object Serie doesn't be null ");
                }

                economyDbContext.Series.Add(t);
                return economyDbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public bool Delete(Serie t)
        {
            try
            {
                if (t == null)
                {
                    throw new ArgumentException("The object t isn't be a null");
                }
                Serie serie = GetAll().Where(x => x.Id == t.Id && x.ProjectId == t.ProjectId).ToList().First();
                if (serie == null)
                {
                    throw new Exception($"The object with Id: {t.Id} don't exist");
                }
                economyDbContext.Series.Remove(t);
                return true ? economyDbContext.SaveChanges() > 0 : false;
            }
            catch
            {
                throw;
            }
        }

        public List<Serie> GetAll()
        {
            try
            {
                return economyDbContext.Series.ToList();
            }
            catch
            {
                throw;
            }
        }

        public List<Serie> GetIdProject(int Id)
        {
            return economyDbContext.Series.Where(x => x.ProjectId == Id).ToList();
        }

        public int Update(Serie t)
        {
            try
            {
                if (t == null)
                {
                    throw new ArgumentException($"The object User doesn't be null");
                }
                Serie serie = GetAll().Where(x => x.Id == t.Id && x.ProjectId == t.ProjectId).First();
                if (serie is null)
                {
                    throw new ArgumentException($"The object with Id: {serie.Id} doesn't exist");
                }
                economyDbContext.Series.Update(t);
                return economyDbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
