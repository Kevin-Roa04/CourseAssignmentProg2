using Economy.AppCore.IServices;
using Economy.Domain.Entities;
using Economy.Domain.Interfaces;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.AppCore.Services
{
    public class DepreciacionService : IDepreciacionService
    {
        private IDepreciacionRepository depreciacionRepository;
        public DepreciacionService(IDepreciacionRepository depreciacionRepository)
        {
            this.depreciacionRepository = depreciacionRepository;
        }
        public int Create(Depreciacion t)
        {
            return depreciacionRepository.Create(t);
        }

        public bool Delete(Depreciacion t)
        {
            throw new NotImplementedException();
        }

        public List<Depreciacion> GetAll()
        {
            throw new NotImplementedException();
        }

        public Depreciacion GetByProjectId(int? projectId)
        {
            return depreciacionRepository.GetByProjectId(projectId);
        }

        public int Update(Depreciacion t)
        {
            return depreciacionRepository.Update(t);
        }
    }
}
