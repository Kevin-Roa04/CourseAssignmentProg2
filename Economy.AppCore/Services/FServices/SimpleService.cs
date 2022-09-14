using Appcore.Interface;
using Dominio.Entities;
using Dominio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appcore.Service
{
    public class SimpleService : ISimpleService
    {
        private IModelSimple simp;
        #region methods
        public SimpleService(IModelSimple simp)
        {
            this.simp = simp;
           
        }
        public decimal CalculateInteres(double f, int n, double p)
        {
            return simp.CalculateInteres(f, n, p);
        }

        public int CalculatePeriodo(double f, double p, decimal i)
        {
            return simp.CalculatePeriodo(f, p, i);
        }

        public double CalculateVF(double p, int n, decimal i)
        {
            return simp.CalculateVF(p, n, i);
        }

        public double CalculateVP(double f, int n, decimal i)
        {

            return simp.CalculateVP(f, n, i);
        }

        public int Create(InteresSimple t)
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


        #endregion
    }
}
