using Dominio.Entities;
using Dominio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class SimpleRepository : IModelSimple
    {
        #region Calculo de Interes simple
        public decimal CalculateInteres(double f, int n, double p)
        {
            decimal i,x;
            if (p == 0 || n == 0)
            {
                return -1;
            }
            else
            {

                x = (decimal)((f / p) - 1);
                i = (decimal)(x/n);
                return i;
            }
        }


        public int CalculatePeriodo(double f, double p, decimal i)
        {
            int n;
            double x;
            if (p == 0 || i == 0)
            {
                return -1;
            }
            else
            {
                
                x = ((f / p) - 1);
                n = (int)(x / ((double)i/100));
                return n;
            }
        }


        public double CalculateVF(double p, int n, decimal i)
        {
            double f,x;
           
            if(p == 0 || n == 0)
            { 
                return -1;
            }
            else{
              
                x = (1 + ((double)i /100)* n);
                f = (x * p);
                return f;
            }
        }
           

        public double CalculateVP(double f, int n, decimal i)
        {
            double p,x;

            x = (1 + (((double)i/100 )* n));
            
            if (x == 0) 
            {
                return -1;
            }
            else
            {
                p = (f / x);
                return p;
            }

        }
        #endregion

        // Los CRUDS no los hare dado que esta es solo una prueba y los cruds son identicos siempre 
        public void Create(InteresSimple t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(InteresSimple t)
        {
            throw new NotImplementedException();
        }

        public List<InteresSimple> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Update(InteresSimple t)
        {
            throw new NotImplementedException();
        }
    }
}
