using Economy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Domain.Interfaces
{
    public interface ICostRepository : IRepository<Cost>
    {
        public List<Cost> GetByProjectId(int projectId);
    }
}
