using Dominio.Entities;
using Economy.AppCore.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appcore.Interface
{
    public interface IConvertService : IServices<TasaConvert>
    {
        decimal ConvertNominalToPeriodicEfective(decimal i, int m);
        decimal ConvertPeriodicEfectiveToNominal(decimal i, int m);
        decimal ConvertNomialToEfective(decimal i, int m);
    }
}
