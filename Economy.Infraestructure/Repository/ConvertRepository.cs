using Dominio.Entities;
using Dominio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class ConvertRepository : IModelConverticion
    {
        #region Convercion de tasas
        public decimal ConvertNomialToEfective(decimal i, int m)
        {
            double x = (double)(1 + ((i/100) / m));
            decimal I =(decimal) (Math.Pow(x, (double)m))-1;
            return I;
           
        }

        public decimal ConvertNominalToPeriodicEfective(decimal i, int m)
        {
            decimal Ip = ((i/100) / m);
            return Ip;
        }

        public decimal ConvertPeriodicEfectiveToNominal(decimal i, int m)
        {
            decimal J = ((i/100)*m);
            return J;
        }

        public void Create(TasaConvert t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(TasaConvert t)
        {
            throw new NotImplementedException();
        }

        public List<TasaConvert> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Update(TasaConvert t)
        {
            throw new NotImplementedException();
        }
        #endregion

        //CRUDS


    }
}
