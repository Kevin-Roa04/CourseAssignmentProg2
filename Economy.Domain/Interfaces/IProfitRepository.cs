using Economy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Domain.Interfaces
{
    public interface IProfitRepository : IRepository<Profit>
    {
        public List<Profit> GetListByProjectId(int projectId);
        public Profit GetById(int id);
        public Profit GetByName(string name, int projectId);
    }
}
