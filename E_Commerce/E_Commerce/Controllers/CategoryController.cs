using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult List()
        {
            List<Category> categories = new List<Category>();
            categories.Add(new Category { ID = 1, Name = "Laptops", Description = "Good"});
            categories.Add(new Category { ID = 2, Name = "TV", Description = "Good"});
            categories.Add(new Category { ID = 3, Name = "Accessories", Description = "Good"});
            categories.Add(new Category { ID = 4, Name = "Sound System", Description = "Good"});
            return View(categories);
        }
    }
}
