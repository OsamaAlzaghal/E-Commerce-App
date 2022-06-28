using E_Commerce.Models;
using E_Commerce.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace E_Commerce.Controllers
{
    [Authorize(Roles = "administrator,editor")]
    public class ProductController : Controller
    {
        private readonly IProduct _products;
        public ProductController(IProduct product)
        {
            _products = product;
        }

        /// <summary>
        /// A method that calls GetProducts method from ProductService.cs.
        /// </summary>
        /// <returns> Returns a view of these products. </returns>
        public async Task<IActionResult> List()
        {
            return View(await _products.GetProducts());
        }

        /// <summary>
        /// A method to call the Add product page.
        /// </summary>
        /// <returns> Returns a view for adding product form. </returns>
        [Authorize(Roles = "administrator")]
        public IActionResult Add()
        {
            return View();
        }

        /// <summary>
        /// This method calls CreateProduct method to create one.
        /// </summary>
        /// <param name="product"></param>
        /// <param name="file"></param>
        /// <returns> Returns a view for a list of products if it was added. </returns>
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

        /// <summary>
        /// This method calls GetProduct method to update one that already exists.
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Return NotFound if it was not found, else, returns a form to update the product. </returns>
        [Authorize(Roles = "editor")]
        public async Task<IActionResult> Update(int id)
        {
            Product product = await _products.GetProduct(id);

            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        /// <summary>
        /// Gets the products object, then update it and return to the list of products page.
        /// </summary>
        /// <param name="product"></param>
        /// <returns> Returns a list of product if updated, else, return a to the form to update. </returns>
        [Authorize(Roles = "editor")]
        [HttpPost]
        public async Task<IActionResult> Update(Product product, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                await _products.UpdateProduct(product, file);
                return RedirectToAction("List", "Product");
            }
            return View(product);
        }

        /// <summary>
        /// Gets a product to be deleted.
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Return a list of products after deleting the product. </returns>
        [Authorize(Roles = "administrator")]
        public async Task<IActionResult> Delete(int id)
        {
            await _products.DeleteProduct(id);
            return RedirectToAction("List", "Product");
        }
    }
}
