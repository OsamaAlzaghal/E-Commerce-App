using E_Commerce.Data;
using E_Commerce.Models;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public abstract class Mock : IDisposable
    {
        private readonly SqliteConnection _connection;
        protected readonly E_CommerceDbContext _db;

        public Mock()
        {
            _connection = new SqliteConnection("Filename=:memory:");
            _connection.Open();

            _db = new E_CommerceDbContext(
                new DbContextOptionsBuilder<E_CommerceDbContext>()
                    .UseSqlite(_connection)
                    .Options);

            _db.Database.EnsureCreated();
        }

        public void Dispose()
        {
            _db?.Dispose();
            _connection?.Dispose();
        }

        protected async Task<Product> CreateAndSaveTestProduct()
        {
            var product = new Product { Name = "laptop", Description= "gaming laptop", CategoryID = 1 };
            _db.Products.Add(product);
            await _db.SaveChangesAsync();
            Assert.NotEqual(0, product.ID); // Sanity check
            return product;
        }

        protected async Task<Category> CreateAndSaveTestCategory()
        {
            var category = new Category { Name= "electronics", Description = "electronics category" };
            _db.Categories.Add(category);
            await _db.SaveChangesAsync();
            Assert.NotEqual(0, category.ID); // Sanity check
            return category;
        }
    }

}
