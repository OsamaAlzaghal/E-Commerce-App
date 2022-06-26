using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using E_Commerce.Data;
using E_Commerce.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models.Services
{
    public class ProductService : IProduct
    {
        private  readonly E_CommerceDbContext _context;
        private readonly IConfiguration _configuration;

        public  ProductService(E_CommerceDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public async Task<Product> CreateProduct(Product product, IFormFile file)
        {
            product.Category = await _context.Categories.FindAsync(product.CategoryID);
            
            BlobContainerClient container = new BlobContainerClient(_configuration.GetConnectionString("AzureBlob"), "ecommercecontainer");
            await container.CreateIfNotExistsAsync();
            BlobClient blob = container.GetBlobClient(file.FileName);
            using var stream = file.OpenReadStream();

            BlobUploadOptions options = new BlobUploadOptions()
            {
                HttpHeaders = new BlobHttpHeaders() { ContentType = file.ContentType }
            };

            if (!blob.Exists())
            {
                await blob.UploadAsync(stream, options);
            }

            product.URL = blob.Uri.ToString();
            stream.Close();
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

        public async Task<List<Product>> RandomProduct()
        {
            List<Product> Randoms = new List<Product>();
            List<Product> Products = await GetProducts();
            Random Rnd = new Random();

            for (int i = 0; i < 4; i++)
            {
                Randoms.Add(Products[Rnd.Next(0,Products.Count-1)]);
            }
        return Randoms;
        }
    }
}