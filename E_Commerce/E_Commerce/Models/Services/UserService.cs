using E_Commerce.Data;
using E_Commerce.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models.Services
{
    public class UserService : IUser
    {
        private readonly E_CommerceDbContext _context;

        public UserService(E_CommerceDbContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetUsers()
        {
            return await _context.Users.Select(x => x).ToListAsync();
        }

        public async Task<User> GetUser(int id)
        {
            return await _context.Users.Where(x => x.ID == id).Select(x => x).FirstOrDefaultAsync();
        }

        public async Task<User> CreateUser(User user)
        {
            _context.Entry(user).State = EntityState.Added;
            Cart cart = new Cart { UserID = user.ID, ID = user.ID };
            user.Cart = cart;
            await _context.SaveChangesAsync();
            return user;
        }
    }
}