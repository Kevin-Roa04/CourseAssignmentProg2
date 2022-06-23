using Economy.Domain.Entities;
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
          

          


            double y = amotizacion.interes / 100;
            amotizacion.Cuota = Math.Round(amotizacion.inversion * (y * Math.Pow(1 + y, amotizacion.plazo)) / (Math.Pow(1 + y, amotizacion.plazo) - 1));

            for (int i = 1; i <= amotizacion.plazo; i = i + 1)
            {
           


                amotizacion.Intereses = Math.Round(amotizacion.inversion * y, 2);

                amotizacion.Abono = Math.Round(amotizacion.Cuota - amotizacion.Intereses, 2);
                amotizacion.inversion = Math.Round(amotizacion.inversion - amotizacion.Abono, 2);


                if (amotizacion.inversion <= 1)
                {

                     amotizacion.inversion = 0;
                }
                
            

            }
        }

        public void Metodo2(Amotizacion amotizacion)
        {
            double y = amotizacion.interes / 100;
            amotizacion.Abono = amotizacion.inversion / amotizacion.plazo;
            for (int i = 1; i <= amotizacion.plazo; i = i + 1)
            {
                amotizacion.Intereses = Math.Round(amotizacion.inversion * y, 2);
                amotizacion.Cuota= Math.Round(amotizacion.Abono + amotizacion.Intereses, 2);
                amotizacion.Saldo = Math.Round(amotizacion.inversion - amotizacion.Abono, 2);
                if (amotizacion.Saldo <= 1)
                {

                    amotizacion.inversion = 0;
                }
            }
        }

        public int Update(Amotizacion t)
        {
            throw new NotImplementedException();
        }
    }
}
