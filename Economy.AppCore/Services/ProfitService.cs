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
            throw new NotImplementedException();
        }

        public List<Profit> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Update(Profit t)
        {
            throw new NotImplementedException();
        }
    }
}
