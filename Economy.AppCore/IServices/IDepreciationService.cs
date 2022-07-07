using Dominio.Entities;
using Economy.AppCore.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appcore.Interface
{
    public interface IDepreciationService: IServices<Depreciations>
    {
        public double Depreciacion(double valor, double vr, int vida);
        public double DepreciationSDA(double Residual, double Value, int years, int period);
        public double DepreciationDDB(double Residual, double value, int year, int coeficiente);
    }
}
