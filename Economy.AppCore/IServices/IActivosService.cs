using Economy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.AppCore.IServices
{
    public interface IActivosService : IServices<Activo>
    {
        public Activo GetById(int id);
        public Activo GetByName(string name);
    }
}
