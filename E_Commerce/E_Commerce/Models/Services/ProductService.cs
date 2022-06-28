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
        private readonly E_CommerceDbContext _context;
        private readonly IConfiguration _configuration;

        public ProductService(E_CommerceDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        /// <summary>
        /// This methods creates a product and adds an image to that product using the Azure and blob container.
        /// </summary>
        /// <param name="product"></param>
        /// <param name="file"></param>
        /// <returns> Returns the new created product. </returns>
        public async Task<Product> CreateProduct(Product product, IFormFile file)
        {
            // Set the category for that product.
            product.Category = await _context.Categories.FindAsync(product.CategoryID);

            // Connection.
            // Configuration.GetConnectionString("AzureBlob"), "attachments"
            BlobContainerClient container = new BlobContainerClient(_configuration.GetConnectionString("AzureBlob"), "ecommercecontainer");
            await container.CreateIfNotExistsAsync();
            BlobClient blob = container.GetBlobClient(file.FileName);
            using var stream = file.OpenReadStream();

            // Options for blob.
            BlobUploadOptions options = new BlobUploadOptions()
            {
                HttpHeaders = new BlobHttpHeaders() { ContentType = file.ContentType }
            };

            // If it does not exist, upload it.
            if (!blob.Exists())
            {
                await blob.UploadAsync(stream, options);
            }

            // Get the image's URL from blob's URI.
            product.URL = blob.Uri.ToString();
            stream.Close();
            // Change the state for the product to be added.
            _context.Entry(product).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return product;
        }

        /// <summary>
        /// This method gets all products in the database.
        /// </summary>
        /// <returns> Returns a list of all products in the database. </returns>
        public async Task<List<Product>> GetProducts()
        {
            return await _context.Products.Select(x => x).ToListAsync();
        }

        /// <summary>
        /// This method gets a specific product from the database.
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Returns a specific product from the database. </returns>
        public async Task<Product> GetProduct(int id)
        {
            return await _context.Products.Where(x => x.ID == id).Select(x => x).FirstOrDefaultAsync();
        }

        /// <summary>
        /// This method adds a product to a category.
        /// </summary>
        /// <param name="categoryID"></param>
        /// <param name="productID"></param>
        /// <returns> Returns the added product. </returns>
        public async Task<Product> AddProductToCategory(int categoryID, int productID)
        {
            Product product = await GetProduct(productID);
            product.CategoryID = categoryID;
            return product;
        }

        /// <summary>
        /// This method gets a product and update it's information.
        /// </summary>
        /// <param name="product"></param>
        /// <returns> Returns the new updated product. </returns>
        public async Task<Product> UpdateProduct(Product product, IFormFile file)
        {
            Category category = await _context.Categories.Where(x => x.ID == product.CategoryID).Select(x => x).FirstOrDefaultAsync();
            Product oldProduct = await GetProduct(product.ID);
            // Very important step.
            oldProduct.Category = category;
            oldProduct.Name = product.Name;
            oldProduct.Price = product.Price;
            oldProduct.InStock = product.InStock;
            oldProduct.Description = product.Description;
            BlobContainerClient container = new BlobContainerClient(_configuration.GetConnectionString("AzureBlob"), "ecommercecontainer");
            await container.CreateIfNotExistsAsync();
            BlobClient blob = container.GetBlobClient(file.FileName);
            using var stream = file.OpenReadStream();

            // Options for blob.
            BlobUploadOptions options = new BlobUploadOptions()
            {
                HttpHeaders = new BlobHttpHeaders() { ContentType = file.ContentType }
            };

            // If it does not exist, upload it.
            if (!blob.Exists())
            {
                await blob.UploadAsync(stream, options);
            }

            // Get the image's URL from blob's URI.
            oldProduct.URL = blob.Uri.ToString();
            stream.Close();
            _context.Entry(oldProduct).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return oldProduct;
        }

        /// <summary>
        /// This method gets a specific product and deletes it from the database.
        /// </summary>
        /// <param name="id"></param>
        /// <returns> None. </returns>
        public async Task DeleteProduct(int id)
        {
            Product product = await GetProduct(id);
            _context.Entry(product).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// This method adds four random products from our database to view them to the user as suggested products.
        /// </summary>
        /// <returns> Return a list of four random products. </returns>
        public async Task<List<Product>> RandomProduct()
        {
            List<Product> Randoms = new List<Product>();
            List<Product> Products = await GetProducts();
            Random Rnd = new Random();

            for (int i = 0; i < 4; i++)
            {
                Randoms.Add(Products[Rnd.Next(0, Products.Count - 1)]);
            }
            return Randoms;
        }
    }
}