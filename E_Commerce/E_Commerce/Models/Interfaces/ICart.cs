using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models.Interfaces
{
    public interface ICart
    {
        public Task<List<Cart>> GetCarts();
        public Task<Cart> GetCart(int id);
        public Task AddProductToCart(int cartID, ProductCart product);
    }
}