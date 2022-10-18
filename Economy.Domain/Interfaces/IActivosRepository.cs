using Economy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Domain.Interfaces
{
    public interface IActivosRepository : IRepository<Activo>
    {
        public Activo GetById(int id);
        public Activo GetByName(string name);
    }
}
