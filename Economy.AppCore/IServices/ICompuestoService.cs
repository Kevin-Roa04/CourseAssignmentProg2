using Dominio.Entities;
using Economy.AppCore.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appcore.Interface
{
    public interface ICompuestoService:IServices<InteresCompuesto>
    {
        double CalculateVF(double p, int n, decimal i);
        double CalñculateVP(double f, int n, decimal i);
        int CalculatePeriodo(double f, double p, decimal i);
        decimal CalculateInteres(double f, int n, double p);

    }
}
