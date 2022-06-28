using E_Commerce.Models;
using E_Commerce.Models.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class UnitTest1 : Mock
    {
        private readonly IConfiguration _configuration;
        [Fact]
        public void TestGettingProduct()
        {
            Product product = (Product)CreateAndSaveTestProduct().Result;
            product.Name = "New Laptop";
            var service = new ProductService(_db, _configuration);
            Product NewProduct = service.GetProduct(product.ID).Result;
            Assert.Equal(NewProduct.Name, product.Name);
        }

        [Fact]
        public void TestGettingCategory()
        {
            Category category = (Category)CreateAndSaveTestCategory().Result;
            category.Name = "New category";
            var service = new CategoryService(_db);
            Category Newcategory = service.GetCategory(category.ID).Result;
            Assert.Equal(category.Name, Newcategory.Name);
        }

        //[Fact]
        //public async void TestUpdatingProduct()
        //{
        //    Product product = (Product)CreateAndSaveTestProduct().Result;
        //    string OldProductName = product.Name;
        //    product.Name = "New Laptop";
        //    var service = new ProductService(_db, _configuration);
        //    product = await service.UpdateProduct(product);
        //    product = service.GetProduct(product.ID).Result;
        //    Assert.NotEqual(OldProductName, product.Name);
        //}

        [Fact]
        public async void TestUpdatingCategory()
        {
            Category category = (Category)CreateAndSaveTestCategory().Result;
            string OldCategoryName = category.Name;
            category.Name = "New Category";
            var service = new CategoryService(_db);
            category = await service.UpdateCategory(category);
            category = service.GetCategory(category.ID).Result;
            Assert.NotEqual(OldCategoryName, category.Name);
        }

        [Fact]
        public async void DeleteProduct()
        {
            Product product = (Product)CreateAndSaveTestProduct().Result;
            int id = product.ID;
            var repository = new ProductService(_db, _configuration);
            await repository.DeleteProduct(id);
            product = await repository.GetProduct(id);
            Assert.Null(product);
        }

        [Fact]
        public async void DeleteCategory()
        {
            Category category = (Category)CreateAndSaveTestCategory().Result;
            int id = category.ID;
            var repository = new CategoryService(_db);
            await repository.DeleteCategory(id);
            category = await repository.GetCategory(id);
            Assert.Null(category);
        }
    }
}
