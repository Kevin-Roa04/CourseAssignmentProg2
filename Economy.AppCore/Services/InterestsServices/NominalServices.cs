using Economy.AppCore.IServices;
using Economy.Domain.Entities;
using Economy.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.AppCore.Services.InterestsServices
{
    public class NominalServices : INominalServices
    {
        public IInteresNominal interesNominal;
        public NominalServices(IInteresNominal interes)
        {
            this.interesNominal = interes;
        }
        public double ConvertEfectiva(double nominal, double M)
        {
            return interesNominal.ConvertEfectiva(nominal, M);
        }

        public double ConvertExponencial(double nominal)
        {
            return interesNominal.ConvertExponencial(nominal);
        }

        public double ConvetNominal(double nominal, double M, double M1)
        {
            return interesNominal.ConvetNominal(nominal, M, M1);
        }

        public int Create(InteresNominal t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(InteresNominal t)
        {
            throw new NotImplementedException();
        }

        public double EfectivaContinua(double efectiva)
        {
            return interesNominal.EfectivaContinua(efectiva);
        }

        public List<InteresNominal> GetAll()
        {
            throw new NotImplementedException();
        }

        public double Getfuturo(double Nominal, double M, double Presente, double periodo)
        {
            return interesNominal.Getfuturo(Nominal, M, Presente, periodo);
        }

        public double GeTPeriodo(double nominal, double M, double presente, double futuro)
        {
            return interesNominal.GeTPeriodo(nominal, M, presente, futuro);
        }

        public double GetPresente(double nominal, double M, double futuro, double periodo)
        {
            return interesNominal.GetPresente(nominal, M, futuro, periodo);
        }

        public int Update(InteresNominal t)
        {
            throw new NotImplementedException();
        }
    }
}
