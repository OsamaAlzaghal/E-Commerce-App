using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models.Interfaces
{
    interface IProductCart
    {
        public Task<List<ProductCart>> GetAllProducstInCart(int cartID);
        public Task<ProductCart> GetAProductFromCart(int cartID, int productID);
    }
}