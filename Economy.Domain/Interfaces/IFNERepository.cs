using Economy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Domain.Interfaces
{
    public interface IFNERepository: IRepository<Fne>
    {
        public Fne GetByProjectId(int? ProjectId);
    }
}
