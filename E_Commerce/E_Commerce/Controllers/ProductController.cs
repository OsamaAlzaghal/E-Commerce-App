using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            List<Product> Products = new List<Product>();
            Products.Add(new Product { ID = 1, Name = "gaming laptop", CategoryID = 1, InStock = true, Price = 1000, Description  = "good" });
            Products.Add(new Product { ID = 2, Name = "4K TV", CategoryID = 2, InStock = true, Price = 500, Description = "good" });

            return View(Products);
        }
    }
}
