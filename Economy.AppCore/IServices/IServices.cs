using System.Collections.Generic;

namespace Economy.AppCore.IServices
{

    public interface IServices<T>
    {
        int Create(T t);
        int Update(T t);
        bool Delete(T t);
        List<T> GetAll();
    }
}
 