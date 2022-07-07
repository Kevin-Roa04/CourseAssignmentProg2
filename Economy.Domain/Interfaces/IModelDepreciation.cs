using Dominio.Entities;
using Economy.Domain.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interface
{
    public  interface IModelDepreciation: IModel<Depreciations>
    {

        public double Depreciacion(double valor, double vr, int vida);
        public double DepreciationSDA(double Residual, double Value, int years, int period);

        public double DepreciationDDB(double Residual, double value, int year, int coeficiente);
    }
}
