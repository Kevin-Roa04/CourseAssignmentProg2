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
            throw new NotImplementedException();
        }

        public List<Cost> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Cost> GetByProjectId(int projectId)
        {
            throw new NotImplementedException();
        }

        public int Update(Cost t)
        {
            throw new NotImplementedException();
        }
    }
}
