using Economy.AppCore.IServices;
using Economy.Domain.Entities;
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
        public int Create(Amotizacion t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Amotizacion t)
        {
            throw new NotImplementedException();
        }

        public List<Amotizacion> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Metodo1(Amotizacion amotizacion)
        {
            amortizacion.Metodo1(amotizacion);
        }

        public void Metodo2(Amotizacion amotizacion)
        {
            amortizacion.Metodo2(amotizacion);
        }

        public int Update(Amotizacion t)
        {
            throw new NotImplementedException();
        }
    }
}
