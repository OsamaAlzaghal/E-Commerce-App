using E_Commerce.Models;
using E_Commerce.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace E_Commerce.Pages.Products
{
    public class ProductsModel : PageModel
    {
        private readonly IProduct ProductService;
        private readonly ICategory CategoryService;

        [BindProperty]
        public List<Product> Products { get; set; }
        [BindProperty]
        public List<Product> CartProducts { get; set; }
        [BindProperty]
        public string CartCookie { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }


        public ProductsModel(IProduct product, ICategory category)
        {
            ProductService = product;
            CategoryService = category;
        }

        /// <summary>
        /// This method gets the cookie and the products info.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returns a page for the list of products in a specific category. </returns>
        public async Task OnGet(int id)
        {
            CartCookie = HttpContext.Request.Cookies[$"{User.Identity.Name}'CartsList"];
            Products = await CategoryService.GetProductsByCategoryID(id);
            CategoryName = (await CategoryService.GetCategory(id)).Name;
            CategoryDescription = (await CategoryService.GetCategory(id)).Description;
        }
    }
}