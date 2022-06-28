using E_Commerce.Models;
using E_Commerce.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace E_Commerce.Controllers
{
    [Authorize(Roles = "administrator,editor")]
    public class CategoryController : Controller
    {
        private readonly ICategory _category;
        public CategoryController(ICategory category)
        {
            _category = category;
        }

        /// <summary>
        /// A method that calls GetCategories method from CategoryService.cs.
        /// </summary>
        /// <returns> Returns a view of these categories. </returns>
        public async Task<IActionResult> List()
        {
            return View(await _category.GetCategories());
        }

        /// <summary>
        /// A method to call the Add category page.
        /// </summary>
        /// <returns> Returns a view for adding category form. </returns>
        [Authorize(Roles = "administrator")]
        public IActionResult Add()
        {
            return View();
        }

        /// <summary>
        /// This method calls CreateCategory method to create one.
        /// </summary>
        /// <param name="category"></param>
        /// <returns> Returns a list of categories after adding. </returns>
        [Authorize(Roles = "administrator")]
        [HttpPost]
        public async Task<IActionResult> Add(Category category)
        {
            if (ModelState.IsValid)
            {
                await _category.CreateCategory(category);
                return RedirectToAction("List", "Category");
            }
            return View(category);
        }

        /// <summary>
        /// This method gets an existing category to update it.
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Returns NotFound if it does not exist, else shows the update form of the category. </returns>
        [Authorize(Roles = "editor")]
        public async Task<IActionResult> Update(int id)
        {
            Category category = await _category.GetCategory(id);

            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        /// <summary>
        /// Gets the updated object and saves it into the database.
        /// </summary>
        /// <param name="category"></param>
        /// <returns> Returns a list of categories if updated. </returns>
        [Authorize(Roles = "editor")]
        [HttpPost]
        public async Task<IActionResult> Update(Category category)
        {
            if (ModelState.IsValid)
            {
                await _category.UpdateCategory(category);
                return RedirectToAction("List", "Category");
            }
            return View(category);
        }

        /// <summary>
        /// This method calls DeleteCategory to deleted a specific category.
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Returns a list of categories after deleting a category. </returns>
        [Authorize(Roles = "administrator")]
        public async Task<IActionResult> Delete(int id)
        {
            await _category.DeleteCategory(id);
            return RedirectToAction("List", "Category");
        }

        /// <summary>
        /// This method calls GetProductsByCategoryID to view products in a category.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returns a view for a list of products in a specific category. </returns>
        public async Task<IActionResult> ProductsInCategory(int id)
        {
            return View(await _category.GetProductsByCategoryID(id));
        }
    }
}
