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
            return inversionFneRepository.Delete(t);
        }

        public List<InversionFne> GetAll()
        {
            throw new NotImplementedException();
        }

        public InversionFne GetById(int id)
        {
            return inversionFneRepository.GetById(id);
        }

        public InversionFne GetByName(string name, int projectId)
        {
            return inversionFneRepository.GetByName(name, projectId);
        }

        public List<InversionFne> GetListByProjectId(int projectId)
        {
            return inversionFneRepository.GetListByProjectId(projectId);
        }

        public int Update(InversionFne t)
        {
            return inversionFneRepository.Update(t);
        }
    }
}
