using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.AppCore.IServices
{
    public interface IInterestServices<T>: IServices<T>
    {
        List<T> GetIdProject(int Id);
        List<T> FindByOption(Func<T, bool> where);
    }
}
