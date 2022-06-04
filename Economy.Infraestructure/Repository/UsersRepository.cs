using Economy.Common;
using Economy.Domain.Entities;
using Economy.Domain.Entities.API_Object;
using Economy.Domain.Entities.Safety;
using Economy.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Infraestructure.Repository
{
    public class UsersRepository : IUsersRepository
    {
        public IEconomyDbContext economyDbContext;
        public UsersRepository(IEconomyDbContext economyDbContext)
        {
            this.economyDbContext = economyDbContext;
        }
        private void ValidationsUsernameAndPassword(string username, string password)
        {
            try
            {
                List<User> users = GetAll();
                if (users.FindAll(x => x.Name.Equals(username) && x.Password.Equals(password)).Count > 0)
                    throw new ArgumentException($"The username: {username} and password: {password} don't be equals with other user");
            }
            catch
            {
                throw;
            }

        }
        public int Create(User t)
        {
            try
            {
                if (t is null)
                {
                    throw new ArgumentException($"The object User doesn't be null ");
                }
                t.Password = Safety.Encrypt(t.Password);
                ValidationsUsernameAndPassword(t.Name, t.Password);
                economyDbContext.Users.Add(t);
                return economyDbContext.SaveChanges();
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
                if (t == null)
                {
                    throw new ArgumentException("The object User isn't be a null");
                }
                User user = FindbyId(t.Id);
                if (user == null)
                {
                    throw new Exception($"The object with Id: {t.Id} don't exist");
                }
                economyDbContext.Users.Remove(t);
                return true ? economyDbContext.SaveChanges() > 0 : false;
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
                return economyDbContext.Users.ToList();
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
                string Encryptedpassword = Safety.Encrypt(password);
                User User = economyDbContext.Users.Where(x => x.Name.Equals(username) && x.Password.Equals(Encryptedpassword)).FirstOrDefault();
                if (User != null)
                {
                    return User;
                }
                return null;
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
                if (t == null)
                {
                    throw new ArgumentException($"The object User doesn't be null");
                }
                User user = FindbyId(t.Id);
                if (user is null)
                {
                    throw new ArgumentException($"The object with Id: {user.Id} doesn't exist");
                }
                economyDbContext.Users.Update(t);
                return economyDbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        public async Task<Number> ValidationNumberAsync(string number)
        {
            string url = $"{AppSettings.ApiNumberUrl}{AppSettings.TokenNumber}&number={number}&country_code=&format=1";
            string jsonObject = string.Empty;
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    jsonObject = await httpClient.GetAsync(url).Result.Content.ReadAsStringAsync();
                }

                if (string.IsNullOrEmpty(jsonObject))
                {
                    throw new NullReferenceException("El objeto json no puede ser null.");
                }

                return Newtonsoft.Json.JsonConvert.DeserializeObject<Number>(jsonObject);
            }
            catch
            {
                throw;
            }
        }

        public async Task<Email> ValidationEmailAsync(string email)
        {
            string url = $"{AppSettings.ApiEmailUrl}{email}?apikey={AppSettings.Token}";
            string jsonObject = string.Empty;
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    jsonObject = await httpClient.GetAsync(url).Result.Content.ReadAsStringAsync();
                }

                if (string.IsNullOrEmpty(jsonObject))
                {
                    throw new NullReferenceException("El objeto json no puede ser null.");
                }

                return Newtonsoft.Json.JsonConvert.DeserializeObject<Email>(jsonObject);
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
                if (id <= 0)
                {
                    throw new Exception($"The Id: {id} doesn't less or equals than cero");
                }
                List<User> users = GetAll();
                return users.Find(x => x.Id == id);
            }
            catch
            {
                throw;
            }
        }

        public List<User> GetId(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
