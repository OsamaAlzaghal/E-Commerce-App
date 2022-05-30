using E_Commerce.Data;
using E_Commerce.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models.Services
{
    public class CartService : ICart
    {
        private readonly E_CommerceDbContext _context;

        public CartService(E_CommerceDbContext context)
        {
            _context = context;
        }

        public async Task<List<Cart>> GetCarts()
        {
            return await _context.Carts.Select(x => x).ToListAsync();
        }
    }
}
