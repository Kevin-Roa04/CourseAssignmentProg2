using Dominio.Entities;
using Dominio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class DepreciationRepository : IModelDepreciation
    {
        Depreciations DEP;

        public void Create(Depreciations t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Depreciations t)
        {
            throw new NotImplementedException();
        }

        public List<double> Depreciacion(double valor, double vr, int vida)
        {
            double depreciacion = (valor - vr) / vida;
              return Enumerable.Repeat<double>(depreciacion, vida).ToList<double>();

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
