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
        List<T> FindByOption(Func<T, bool> where);

        int GlobalUpdate(int Duration,decimal rate,int projectID,int userID);
    }
}
