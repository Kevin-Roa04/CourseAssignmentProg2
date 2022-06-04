using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Domain.Interfaces
{
    public interface IInterestRepository<T> : IRepository<T>
    {
        List<T> GetIdProject(int Id);
    }
}
