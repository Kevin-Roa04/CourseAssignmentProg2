using Economy.AppCore.IServices;
using Economy.Domain.Entities;
using Economy.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.AppCore.Services
{
    public class ProjectServices : IProjectServices
    {
        private IProjectRepository ProjectRepository;
        public ProjectServices(IProjectRepository projectRepository)
        {
            this.ProjectRepository = projectRepository;
        }
        public int Create(Project t)
        {
            return ProjectRepository.Create(t);
        }

        public bool Delete(Project t)
        {
           return this.ProjectRepository.Delete(t);
        }

        public Project FindbyId(int id)
        {
            return this.ProjectRepository.FindbyId(id);
        }

        public List<Project> GetAll()
        {
            return this.ProjectRepository.GetAll();
        }

        public List<Project> GetProjectByUser(int IdUser)
        {
            return this.ProjectRepository.GetProjectByUser(IdUser);
        }

        public int Update(Project t)
        {
            return this.ProjectRepository.Update(t);
        }
    }
}
