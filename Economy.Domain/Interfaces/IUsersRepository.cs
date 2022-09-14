using Economy.Domain.Entities;
using Economy.Domain.Entities.API_Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Domain.Interfaces
{
    public interface IUsersRepository : IRepository<User>
    {
        Task<Number> ValidationNumberAsync(string number);
        Task<Email> ValidationEmailAsync(string email);
        User Registration(string username, string password);
        User FindbyId(int id);
    }
}
