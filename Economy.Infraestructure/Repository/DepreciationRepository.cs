using Dominio.Entities;
using Dominio.Interface;
using Economy.Domain.Entities.DTO;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class DepreciationRepository : IModelDepreciation
    {

        public void Create(Depreciations t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Depreciations t)
        {
            throw new NotImplementedException();
        }
        public List<Depreciations> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Update(Depreciations t)
        {
            throw new NotImplementedException();
        }

        public double Depreciacion(double valor, double vr, int vida)
        {
            return Math.Round((valor - vr) / vida, 2);
        }

        public double DepreciationSDA(double Residual, double Value, int years, int period)
        {
            int Sum = 0;
            for (int i = 1; i <= years; i++)
            {
                Sum = (i * (i + 1)) / 2;
            }

            return Math.Round(((years - period + 1) / Sum) * (Value - Residual), 2);
        }

        public double DepreciationDDB(double Residual, double value, int year, int coeficiente)
        {
            double division = ((double)coeficiente / year);
            return division * value;
        }
    }
}
