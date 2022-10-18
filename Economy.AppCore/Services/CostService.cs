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
    public class CostService : ICostService
    {
        private ICostRepository costRepository;
        public CostService(ICostRepository costRepository)
        {
            this.costRepository = costRepository;
        }
        public int Create(Cost t)
        {
            return costRepository.Create(t);
        }

        public bool Delete(Cost t)
        {
            return !costRepository.Delete(t);
        }

        public List<Cost> GetAll()
        {
            throw new NotImplementedException();
        }

        public Cost GetById(int id)
        {
            return costRepository.GetById(id);
        }

        public Cost GetByName(string name, int projectId)
        {
            return costRepository.GetByName(name, projectId);
        }

        public List<Cost> GetListByProjectId(int projectId)
        {
            return costRepository.GetListByProjectId(projectId);
        }

        public int Update(Cost t)
        {
            return costRepository.Update(t);
        }
    }
}
