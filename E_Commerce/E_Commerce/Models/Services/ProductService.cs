using E_Commerce.Data;
using E_Commerce.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models.Services
{
    public class ProductService : IProduct
    {
        private  readonly E_CommerceDbContext _context;

        public  ProductService(E_CommerceDbContext context)
        {
            _context = context;
        }
        public async Task<Product> CreateProduct(Product product)
        {
            product.Category = await _context.Categories.FindAsync(product.CategoryID);
            
            _context.Entry(product).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _context.Products.Select(x => x).ToListAsync();
        }

        public  async Task<Product> GetProduct(int id)
        {
            return await _context.Products.Where(x => x.ID == id).Select(x => x).FirstOrDefaultAsync();
        }

        public async Task<Product> AddProductToCategory(int categoryID, int productID)
        {
            Product product = await GetProduct(productID);
            product.CategoryID = categoryID;
            return product;
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            Category category = await _context.Categories.FindAsync(product.CategoryID);
            Product oldProduct = await GetProduct(product.ID);
            // Very important step.
            oldProduct.Category = category;
            oldProduct.CategoryID = product.CategoryID;
            oldProduct.Name = product.Name;
            oldProduct.Price = product.Price;
            oldProduct.InStock = product.InStock;
            oldProduct.Description = product.Description;
            _context.Entry(oldProduct).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task DeleteProduct(int id)
        {
            Product product = await GetProduct(id);
            _context.Entry(product).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }
    }
}