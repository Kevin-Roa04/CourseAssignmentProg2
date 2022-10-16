using Economy.AppCore.IServices;
using Economy.Domain.Entities;
using Economy.Domain.Entities.DTO;
using Economy.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.AppCore.Services.InterestsServices
{
    public class AmortizacionServices : IAmortizacionServices
    {
        public IAmortizacion amortizacion;
        public AmortizacionServices (IAmortizacion amor)
        {
            this.amortizacion = amor;
        }
        public int Create(Amortizacion t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Amortizacion t)
        {
            throw new NotImplementedException();
        }

        public List<Amortizacion> GetAll()
        {
            throw new NotImplementedException();
        }

        public AmortizationDTO Metodo1(Amortizacion amotizacion, double saldo)
        {
            return amortizacion.Metodo1(amotizacion, saldo);
        }

        public AmortizationDTO Metodo2(Amortizacion amotizacion, double saldo)
        {
            return amortizacion.Metodo2(amotizacion, saldo);
        }

        public int Update(Amortizacion t)
        {
            throw new NotImplementedException();
        }
    }
}
