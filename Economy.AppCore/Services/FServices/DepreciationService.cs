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

        public int Create(Depreciations t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Depreciations t)
        {
            throw new NotImplementedException();
        }

        public List<double> Depreciacion(double valor, double vr, int vida)
        {
            return dep.Depreciacion(valor, vr, vida).ToList();
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
