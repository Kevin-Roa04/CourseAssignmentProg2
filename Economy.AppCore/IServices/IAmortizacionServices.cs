using Economy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.AppCore.IServices
{
    public interface IAmortizacionServices : IServices<Amotizacion>
    {
        void Metodo1(Amotizacion amotizacion);
        void Metodo2(Amotizacion amotizacion);
    }
}
