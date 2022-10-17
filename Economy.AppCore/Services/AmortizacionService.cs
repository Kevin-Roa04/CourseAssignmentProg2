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
    public class AmortizacionService : IAmorizacionService
    {
        private IAmortizacionRepository amortizacionRepository;
        public AmortizacionService(IAmortizacionRepository amortizacionRepository)
        {
            this.amortizacionRepository = amortizacionRepository;
        }
        public int Create(Amortizacion t)
        {
            return amortizacionRepository.Create(t);
        }

        public bool Delete(Amortizacion t)
        {
            throw new NotImplementedException();
        }

        public List<Amortizacion> GetAll()
        {
            throw new NotImplementedException();
        }

        public Amortizacion GetByProjectId(int? projectId)
        {
            return amortizacionRepository.GetByProjectId(projectId);
        }

        public int Update(Amortizacion t)
        {
            return amortizacionRepository.Update(t);
        }
    }
}
