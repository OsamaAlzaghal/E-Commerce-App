using E_Commerce.Data;
using E_Commerce.Models;
using E_Commerce.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategory _category;
        public IActionResult List()
        {
            List<Category> categories = new List<Category>();
            categories.Add(new Category { ID = 1, Name = "Laptops", Description = "Good"});
            categories.Add(new Category { ID = 2, Name = "TV", Description = "Good"});
            categories.Add(new Category { ID = 3, Name = "Accessories", Description = "Good"});
            categories.Add(new Category { ID = 4, Name = "Sound System", Description = "Good"});
            return View(categories);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Category category)
        {
            if (ModelState.IsValid)
            {
                //_category.CreateCategory(category);
                return Content("You have successfully added a category ! Name: " + category.Name + " Description: " + category.Description);
            }
            return View(category);
        }
    }
}
