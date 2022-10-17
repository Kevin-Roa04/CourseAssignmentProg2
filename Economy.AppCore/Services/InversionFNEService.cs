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
    public class InversionFNEService : IInversionFNEService
    {
        private IInversionFNERepository inversionFneRepository;
        public InversionFNEService(IInversionFNERepository inversionFneRepository)
        {
            this.inversionFneRepository = inversionFneRepository;
        }
        public int Create(InversionFne t)
        {
            return inversionFneRepository.Create(t);
        }

        public bool Delete(InversionFne t)
        {
            throw new NotImplementedException();
        }

        public List<InversionFne> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<InversionFne> GetByProjectId(int ProjectId)
        {
            throw new NotImplementedException();
        }

        public int Update(InversionFne t)
        {
            throw new NotImplementedException();
        }
    }
}
