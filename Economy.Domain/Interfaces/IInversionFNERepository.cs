using Economy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Domain.Interfaces
{
    public interface IInversionFNERepository : IRepository<InversionFne>
    {
        public List<InversionFne> GetByProjectId(int Projectid);
    }
}
