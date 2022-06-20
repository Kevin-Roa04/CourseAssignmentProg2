using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interface
{
    public interface IModelConverticion : IModel<TasaConvert>
    {
        decimal ConvertNominalToPeriodicEfective(decimal i, int m);
        decimal ConvertPeriodicEfectiveToNominal(decimal i, int m);
        decimal ConvertNomialToEfective(decimal i, int m);
    }
}
