using Economy.Domain.Entities;
using Economy.Domain.Entities.DTO;
using Economy.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Infraestructure.Repository.Interests
{
    public class AmortizacionRepository : IAmortizacion
    {
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

        public int Update(Amortizacion t)
        {
            throw new NotImplementedException();
        }

        public AmortizationDTO Metodo1(Amortizacion amotizacion)
        {
            AmortizationDTO amortizacion = new AmortizationDTO();
            double y = amotizacion.interes / 100;
            amortizacion.payment = Math.Round(amotizacion.inversion * (y * Math.Pow(1 + y, amotizacion.plazo)) / (Math.Pow(1 + y, amotizacion.plazo) - 1));
            amortizacion.interest = Math.Round(amotizacion.Saldo * y, 2);
            amortizacion.Credit_memo = Math.Round(amortizacion.payment - amortizacion.interest, 2);
            if(amortizacion.Credit_memo > amotizacion.Saldo)
            {
                amortizacion.Credit_memo = amotizacion.Saldo;
                amortizacion.outstanding_balance = Math.Round(amotizacion.Saldo - amortizacion.Credit_memo, 2);
            }
            else
            {
                amortizacion.outstanding_balance = Math.Round(amotizacion.Saldo - amortizacion.Credit_memo, 2);
            }
            return amortizacion;

        }

        public AmortizationDTO Metodo2(Amortizacion amotizacion)
        {
            AmortizationDTO amortizacion = new AmortizationDTO();
            double y = amotizacion.interes / 100;
            amortizacion.Credit_memo = Math.Round(amotizacion.inversion / amotizacion.plazo, 2);
            amortizacion.interest = Math.Round(amotizacion.Saldo * y, 2);
            amortizacion.payment = Math.Round(amortizacion.Credit_memo + amortizacion.interest, 2);
            if (amortizacion.Credit_memo > amotizacion.Saldo)
            {
                amortizacion.Credit_memo = amotizacion.Saldo;
                amortizacion.outstanding_balance = Math.Round(amotizacion.Saldo - amortizacion.Credit_memo, 2);
            }
            else
            {
                amortizacion.outstanding_balance = Math.Round(amotizacion.Saldo - amortizacion.Credit_memo, 2);
            }
            return amortizacion;
        }
    }
}
