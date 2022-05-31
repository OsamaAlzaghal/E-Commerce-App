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
        public async Task AddProductToCart(int cartID, ProductCart product)
        {
            Cart cart = await GetCart(cartID);
            cart.ProductCarts.Add(product);
            await _context.SaveChangesAsync();
        }
        public async Task<List<Cart>> GetCarts()
        {
            return await _context.Carts.Select(x => x).ToListAsync();
        }

        public async Task<Cart> GetCart(int id)
        {
            return await _context.Carts.Where(x => x.ID == id).Select(x => x).FirstOrDefaultAsync();
        }

    }
}