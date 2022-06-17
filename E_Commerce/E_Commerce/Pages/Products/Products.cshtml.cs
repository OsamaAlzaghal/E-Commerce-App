using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Models;
using E_Commerce.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

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

        public ProductsModel(IProduct product, ICategory category)
        {
            ProductService = product;
            CategoryService = category;
        }

        public async Task OnGet(int id)
        {
            CartCookie = HttpContext.Request.Cookies[$"{User.Identity.Name}'CartsList"];
            if (CartCookie != null && id == 0)
            {
                Products = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(CartCookie);

            }
            else
            {
                Products = await CategoryService.GetProductsByCategoryID(id);
            }
            //products = await CategoryService.GetProductsByCategoryID(id);
        }
    }
}