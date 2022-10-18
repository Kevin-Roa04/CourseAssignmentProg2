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
    public class ProfitService : IProfitService
    {
        IProfitRepository profitRepository;
        public ProfitService(IProfitRepository profitRepository)
        {
            this.profitRepository = profitRepository;
        }
        public int Create(Profit t)
        {
            return profitRepository.Create(t);
        }

        public bool Delete(Profit t)
        {
            return profitRepository.Delete(t);
        }

        public List<Profit> GetAll()
        {
            throw new NotImplementedException();
        }

        public Profit GetByName(string name, int projectId)
        {
            return profitRepository.GetByName(name,projectId);
        }

        public Profit GetById(int id)
        {
            return profitRepository.GetById(id);
        }

        public List<Profit> GetListByProjectId(int projectId)
        {
            return profitRepository.GetListByProjectId(projectId);
        }

        public int Update(Profit t)
        {
            return profitRepository.Update(t);
        }
    }
}
