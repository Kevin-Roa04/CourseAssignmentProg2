using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interface
{
    public interface IModelSimple:IModel<InteresSimple>
    {
        double CalculateVF(double p, int n, decimal i);
        double CalculateVP(double f, int n, decimal i);
        int CalculatePeriodo(double f, double p, decimal i);
        decimal CalculateInteres(double f, int n, double p);

    }
}
