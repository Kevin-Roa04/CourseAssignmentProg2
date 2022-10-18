using Economy.Domain.Entities;
using Economy.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Infraestructure.Repository
{
    public class AmortizacionRepository : IAmortizacionRepository
    {
        private IEconomyDbContext context;
        public AmortizacionRepository(IEconomyDbContext context)
        {
            this.context = context;
        }
        public int Create(Amortizacion t)
        {
            context.Amortizacions.Add(t);
            return context.SaveChanges();
        }

        public bool Delete(Amortizacion t)
        {
            throw new NotImplementedException();
        }

        public List<Amortizacion> GetAll()
        {
            throw new NotImplementedException();
        }

        public Amortizacion GetByProjectId(int? projectId)
        {
            return context.Amortizacions.Where(a => a.ProjectId == projectId).FirstOrDefault();
        }

        public int Update(Amortizacion t)
        {
            Amortizacion amortizacion = GetByProjectId(t.ProjectId);
            if (amortizacion == null) return 0;

            amortizacion.TasaPrestamo = t.TasaPrestamo;
            amortizacion.ValorInversion = t.ValorInversion;
            amortizacion.Plazo = t.Plazo;
            amortizacion.TipoAmortizacion = t.TipoAmortizacion;

            context.Amortizacions.Update(amortizacion);
            return context.SaveChanges();
        }
    }
}
