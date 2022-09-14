using Economy.Domain.Entities;
using Economy.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Infraestructure.Repository
{
    public class ProjectRepository : IProjectRepository
    {

        public IEconomyDbContext economyDbContext;


        public ProjectRepository( IEconomyDbContext economyDbContexts)
        {
            this.economyDbContext = economyDbContexts;
        }
        public int Create(Project t)
        {
            try
            {
                if (t is null)
                {
                    throw new ArgumentException($"The object User doesn't be null ");
                }
             
                economyDbContext.Projects.Add(t);
                return economyDbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public bool Delete(Project t)
        {
            try
            {
                if (t == null)
                {
                    throw new ArgumentException("The object User isn't be a null");
                }
                Project project = FindbyId(t.Id);
                if (project== null)
                {
                    throw new Exception($"The object with Id: {t.Id} don't exist");
                }
                economyDbContext.Projects.Remove(t);
                return true ? economyDbContext.SaveChanges() > 0 : false;
            }
            catch
            {
                throw;
            }

        }

        public Project FindbyId(int id)
        {

            try
            {
                if (id <= 0)
                {
                    throw new Exception($"The Id: {id} doesn't less or equals than cero");
                }
                List<Project> projects = GetProjectByUser(id);
                return projects.Find(x => x.Id == id);
            }
            catch
            {
                throw;
            }
        }

        public List<Project> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Project> GetProjectByUser(int IdUser)
        {
            return economyDbContext.Projects.Where(x=>x.UserId==IdUser).ToList();
        }

        public int Update(Project t)
        {
            try
            {
                if (t == null)
                {
                    throw new ArgumentException($"The object User doesn't be null");
                }
                Project project = FindbyId(t.Id);
                if (project is null)
                {
                    throw new ArgumentException($"The object with Id: {project.Id} doesn't exist");
                }
                economyDbContext.Projects.Update(t);
                return economyDbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
