using E_Commerce.Models;
using E_Commerce.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProduct _products;
        private readonly ICategory _categories;
        public ProductController(IProduct product, ICategory category)
        {
            _products = product;
            _categories = category;
        }

        public async Task<IActionResult> List()
        {
            //List<Product> Products = new List<Product>();
            //Products.Add(new Product { ID = 1, Name = "gaming laptop", CategoryID = 1, InStock = true, Price = 1000, Description  = "good" });
            //Products.Add(new Product { ID = 2, Name = "4K TV", CategoryID = 2, InStock = true, Price = 500, Description = "good" });

            return View(await _products.GetProducts());
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Product product)
        {
            if (ModelState.IsValid)
            {
                await _products.CreateProduct(product);
                return Content("You have successfully added a category ! Name: " + product.Name + " Description: " + product.Description);
            }
            return View(product);
        }

        public async Task<IActionResult> Update(int id)
        {
            Product product = await _products.GetProduct(id);

            if(product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Product product)
        {
            if (ModelState.IsValid)
            {
                await _products.UpdateProduct(product);
                return Content("You have successfully updated product (Name: " + product.Name + ")");
            }
            return View(product);
        }

        //[HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _products.DeleteProduct(id);
            return Content("You have successfully deleted the product");
            //return View("~/Views/Product/List.cshtml");
        }
    }
}
