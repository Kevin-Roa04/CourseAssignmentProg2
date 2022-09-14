using Economy.Domain.Entities;
using Economy.Domain.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Domain.Interfaces
{
   public interface IAmortizacion : IRepository<Amortizacion>
    {
        AmortizationDTO Metodo1(Amortizacion amotizacion );
        AmortizationDTO Metodo2(Amortizacion amotizacion);

    }
}
