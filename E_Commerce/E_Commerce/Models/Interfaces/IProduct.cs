using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace E_Commerce.Models.Interfaces
{
    public interface IProduct
    {
        public Task<List<Product>> GetProducts();
        public Task<Product> GetProduct(int id);
        public Task<Product> CreateProduct(Product product, IFormFile file);
        public Task<Product> UpdateProduct(Product product, IFormFile file);
        public Task DeleteProduct(int id);
        public Task<List<Product>> RandomProduct();
    }
}