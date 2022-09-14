using Economy.Domain.Entities;
using Economy.Domain.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.AppCore.IServices
{
    public interface IAmortizacionServices : IServices<Amortizacion>
    {
        AmortizationDTO Metodo1(Amortizacion amotizacion);
        AmortizationDTO Metodo2(Amortizacion amotizacion);
    }
}
