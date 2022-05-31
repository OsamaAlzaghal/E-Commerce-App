using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models.Interfaces
{
    interface IUser
    {
        public Task<List<User>> GetUsers();
        public Task<User> GetUser(int id);
        public Task<User> CreateUser(User user);
    }
}