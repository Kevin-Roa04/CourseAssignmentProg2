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
    public class CompuestoService : ICompuestoService
    {
        private IModelCompuesto comp;
        public CompuestoService(IModelCompuesto comp)
        {
            this.comp = comp;
        }
        public decimal CalculateInteres(double f, int n, double p)
        {
            return comp.CalculateInteres(f, n, p);
        }

        public int CalculatePeriodo(double f, double p, decimal i)
        {
            return comp.CalculatePeriodo(f, p, i);

        }

        public double CalculateVF(double p, int n, decimal i)
        {
            return comp.CalculateVF(p, n,i);
        }

        public double CalñculateVP(double f, int n, decimal i)
        {
            return comp.CalculateVP(f, n, i);
        }

        public void Create(InteresCompuesto t)
        {
            comp.Create(t);
        }

        public bool Delete(InteresCompuesto t)
        {
            return comp.Delete(t);
;        }

        public List<InteresCompuesto> GetAll()
        {
            return comp.GetAll();
        }

        public int Update(InteresCompuesto t)
        {
            return comp.Update(t);
        }

        int IServices<InteresCompuesto>.Create(InteresCompuesto t)
        {
            throw new NotImplementedException();
        }
    }
}
