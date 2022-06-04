using Economy.Domain.Entities;
using Economy.Domain.Entities.API_Object;
using System.Threading.Tasks;

namespace Economy.AppCore.IServices
{
    public interface IUsersServices : IServices<User>
    {
        Task<Number> ValidationNumberAsync(string number);
        Task<Email> ValidationEmailAsync(string email);
        User Registration(string username, string password);
        User FindbyId(int id);
    }
}
