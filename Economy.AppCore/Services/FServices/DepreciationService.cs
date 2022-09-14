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
    public class DepreciationService : IDepreciationService
    {
        private IModelDepreciation dep;

        public DepreciationService(IModelDepreciation modelDepreciation)
        {
            this.dep = modelDepreciation;
        }
        public int Create(Depreciations t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Depreciations t)
        {
            throw new NotImplementedException();
        }

        public double Depreciacion(double valor, double vr, int vida)
        {
            return dep.Depreciacion(valor, vr, vida);
        }

        public double DepreciationDDB(double Residual, double value, int year, int coeficiente)
        {
            return dep.DepreciationDDB(Residual, value, year, coeficiente);
        }

        public double DepreciationSDA(double Residual, double Value, int years, int period)
        {
            return dep.DepreciationSDA(Residual, Value, years, period);
        }

        public List<Depreciations> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Update(Depreciations t)
        {
            throw new NotImplementedException();
        }
    }
}
