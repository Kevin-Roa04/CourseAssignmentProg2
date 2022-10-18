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
    public class FNEService : IFNEService
    {
        private IFNERepository FneRepository;
        public FNEService(IFNERepository FneRepository)
        {
            this.FneRepository = FneRepository;
        }
        public int Create(Fne t)
        {
            return FneRepository.Create(t);
        }

        public bool Delete(Fne t)
        {
            throw new NotImplementedException();
        }

        public List<Fne> GetAll()
        {
            throw new NotImplementedException();
        }

        public Fne GetByProjectId(int? ProjectId)
        {
            return FneRepository.GetByProjectId(ProjectId);
        }

        public int Update(Fne t)
        {
            return FneRepository.Update(t);
        }
    }
}
