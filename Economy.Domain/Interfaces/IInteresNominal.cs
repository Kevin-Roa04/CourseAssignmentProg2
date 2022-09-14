using Economy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Domain.Interfaces
{
     public interface IInteresNominal : IRepository<InteresNominal>
    {
        double Getfuturo(double Nominal, double M, double Presente, double periodo);
        double GetPresente(double nominal, double M, double futuro, double periodo);
        double GeTPeriodo(double nominal, double M, double presente, double futuro);
        double ConvertEfectiva(double nominal, double M);
        double ConvetNominal(double nominal, double M, double M1);
        double ConvertExponencial(double nominal);
        double EfectivaContinua(double efectiva);
    }
}
