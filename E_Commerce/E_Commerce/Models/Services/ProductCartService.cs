using E_Commerce.Data;
using E_Commerce.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models.Services
{
    public class ProductCartService : IProductCart
    {
        private readonly E_CommerceDbContext _context;

        public ProductCartService(E_CommerceDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProductCart>> GetAllProducstInCart(int cartID)
        {
            return await _context.ProductCarts.Where(x => x.CartID == cartID).Select(x => x).ToListAsync();
        }

        public async Task<ProductCart> GetAProductFromCart(int cartID, int productID)
        {
            return await _context.ProductCarts.Where(x => x.CartID == cartID && x.ProductID == productID).Select(x => x).FirstOrDefaultAsync();
        }
    }
}