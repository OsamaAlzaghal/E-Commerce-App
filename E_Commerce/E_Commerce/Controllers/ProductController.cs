using E_Commerce.Models;
using E_Commerce.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
        public ProductController(IProduct product)
        {
            _products = product;
        }

        public async Task<IActionResult> List()
        {
            return View(await _products.GetProducts());
        }

        [Authorize(Roles = "administrator")]
        public IActionResult Add()
        {
            return View();
        }

        [Authorize(Roles = "administrator")]
        [HttpPost]
        public async Task<IActionResult> Add(Product product, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                await _products.CreateProduct(product, file);
                return RedirectToAction("List", "Product");
            }
            return View(product);
        }

        [Authorize(Roles = "editor")]
        public async Task<IActionResult> Update(int id)
        {
            Product product = await _products.GetProduct(id);

            if(product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [Authorize(Roles = "editor")]
        [HttpPost]
        public async Task<IActionResult> Update(Product product)
        {
            if (ModelState.IsValid)
            {
                await _products.UpdateProduct(product);
                return RedirectToAction("List", "Product");
            }
            return View(product);
        }

        [Authorize(Roles = "administrator")]
        public async Task<IActionResult> Delete(int id)
        {
            await _products.DeleteProduct(id);
            return RedirectToAction("List", "Product");
        }
    }
}
