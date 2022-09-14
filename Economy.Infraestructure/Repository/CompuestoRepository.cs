using Dominio.Entities;
using Dominio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class CompuestoRepository : IModelCompuesto
    {
        #region Calculo de Interes Compuesto
        public decimal CalculateInteres(double f, int n, double p)
        {

            decimal i, y, x;
            x = ((decimal)f / (decimal)p);
            y = (1 / (decimal)n);

            i = (decimal)Math.Pow((double)x, (double)y);
            



            // return (decimal)i;
            return (decimal)i-1;
            
        }


        public int CalculatePeriodo(double f, double p, decimal i)
        {
            int n;
            double x,y;

            if (p == 0)
            {
                return -1;
            }
            else
            {
                i = (i / 100);
                x = Math.Log((f / p));
                y = Math.Log((1 + (double)i));
                n = (int)(x/y);
                return n;
            }
        
        }


        public double CalculateVF(double p, int n, decimal i)
        {
            double f;
            f = (p * (Math.Pow((1 + ((double)i/100)), (double)n)));
            return f;
            
        }


        public double CalculateVP(double f, int n, decimal i)
        {
            double p, x;
            x = Math.Pow(1 + ((double)i / 100), n);
            p = (f/x);
            return p;
        }

        #endregion

        public void Create(InteresCompuesto t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(InteresCompuesto t)
        {
            throw new NotImplementedException();
        }

        public List<InteresCompuesto> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Update(InteresCompuesto t)
        {
            throw new NotImplementedException();
        }
    }
}
