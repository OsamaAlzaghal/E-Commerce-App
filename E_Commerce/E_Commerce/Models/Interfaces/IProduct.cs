using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models.Interfaces
{
    interface IProduct
    {
        public Task<List<Product>> GetProducts();
        public Task<Product> GetProduct(int id);
        public Task<Product> CreateProduct(Product product);
        public Task<Product> UpdateProduct(Product product);
        public Task DeleteProduct(int id);
    }
}