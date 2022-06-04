using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.AppCore.IServices
{
    public interface ICalculateServices<T>
    {
        decimal Present(T t);
        decimal Future(T t);
    }
}
