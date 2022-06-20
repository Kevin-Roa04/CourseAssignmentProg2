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
        public List<double> Depreciacion(double valor, double vr, int vida);
    }
}
