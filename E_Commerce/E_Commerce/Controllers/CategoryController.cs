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
        public CategoryController(ICategory category)
        {
            _category = category;
        }
        public async Task<IActionResult> List()
        {
            //List<Category> categories = new List<Category>();
            //categories.Add(new Category { ID = 1, Name = "Laptops", Description = "Good"});
            //categories.Add(new Category { ID = 2, Name = "TV", Description = "Good"});
            //categories.Add(new Category { ID = 3, Name = "Accessories", Description = "Good"});
            //categories.Add(new Category { ID = 4, Name = "Sound System", Description = "Good"});

            return View(await _category.GetCategories());
        }

        ////////////////////////////////////////
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Category category)
        {
            if (ModelState.IsValid)
            {
                await _category.CreateCategory(category);
                return Content("You have successfully added a category ! Name: " + category.Name + " Description: " + category.Description);
            }
            return View(category);
        }

        ////////////////////////////////////////

        public async Task<IActionResult> Update(int id)
        {
            Category category = await _category.GetCategory(id);

            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Category category)
        {
            if (ModelState.IsValid)
            {
                await _category.UpdateCategory(category);
                return Content("You have successfully updated category (Name: " + category.Name + ")");
            }
            return View(category);
        }

        //[HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _category.DeleteCategory(id);
            return Content("You have successfully deleted the category");
            //return View("~/Views/Category/List.cshtml");
        }
    }
}
