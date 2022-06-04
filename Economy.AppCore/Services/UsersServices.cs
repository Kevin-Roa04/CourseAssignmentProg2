using Economy.AppCore.IServices;
using Economy.Domain.Entities;
using Economy.Domain.Entities.API_Object;
using Economy.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Economy.AppCore.Services
{
    public class UsersServices : IUsersServices
    {
        private IUsersRepository usersRepository;
        public UsersServices(IUsersRepository userRepository)
        {
            this.usersRepository = userRepository;
        }
        public int Create(User t)
        {
            try
            {
                return usersRepository.Create(t);
            }
            catch
            {
                throw;
            }
        }

        public bool Delete(User t)
        {
            try
            {
                return usersRepository.Delete(t);
            }
            catch
            {
                throw;
            }
        }

        public User FindbyId(int id)
        {
            try
            {
                return usersRepository.FindbyId(id);
            }
            catch
            {
                throw;
            }
        }

        public List<User> GetAll()
        {
            try
            {
                return usersRepository.GetAll();
            }
            catch
            {
                throw;
            }
        }

        public User Registration(string username, string password)
        {
            try
            {
                return usersRepository.Registration(username, password);
            }
            catch
            {
                throw;
            }
        }

        public int Update(User t)
        {
            try
            {
                return usersRepository.Update(t);
            }
            catch
            {
                throw;
            }
        }

        public Task<Email> ValidationEmailAsync(string email)
        {
            try
            {
                return usersRepository.ValidationEmailAsync(email);
            }
            catch
            {
                throw;
            }
        }

        public Task<Number> ValidationNumberAsync(string number)
        {
            try
            {
                return usersRepository.ValidationNumberAsync(number);
            }
            catch
            {
                throw;
            }
        }
    }
}
