using Appcore.Interface;
using Dominio.Entities;
using Dominio.Interface;
using Economy.AppCore.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appcore.Service
{
    public class ConvertService : IConvertService
    {

        private IModelConverticion comp;
        public ConvertService(IModelConverticion comp)
        {
            this.comp = comp;
        }
        public decimal ConvertNomialToEfective(decimal i, int m)
        {
            return comp.ConvertNomialToEfective(i, m);
        }

        public decimal ConvertNominalToPeriodicEfective(decimal i, int m)
        {
            return comp.ConvertNominalToPeriodicEfective(i, m);
        }

        public decimal ConvertPeriodicEfectiveToNominal(decimal i, int m)
        {
            return comp.ConvertPeriodicEfectiveToNominal(i,m);
        }

       

        public int Create(TasaConvert t)
        {
            throw new NotImplementedException();
        }

        
        public bool Delete(TasaConvert t)
        {
            throw new NotImplementedException();
        }

        public List<TasaConvert> GetAll()
        {
            return comp.GetAll();
        }

      
        public int Update(TasaConvert t)
        {
            throw new NotImplementedException();
        }

        List<TasaConvert> IServices<TasaConvert>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
