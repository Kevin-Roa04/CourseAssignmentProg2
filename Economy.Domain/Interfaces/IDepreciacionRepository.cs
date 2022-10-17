using Economy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Domain.Interfaces
{
    public interface IDepreciacionRepository: IRepository<Depreciacion>
    {
        public Depreciacion GetByProjectId(int? projectId);
    }
}
