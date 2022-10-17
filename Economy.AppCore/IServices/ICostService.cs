using Economy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.AppCore.IServices
{
    public interface ICostService : IServices<Cost>
    {
        public List<Cost> GetByProjectId(int projectId);
    }
}
