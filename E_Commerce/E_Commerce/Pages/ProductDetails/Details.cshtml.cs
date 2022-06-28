using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Models;
using E_Commerce.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using RestSharp;

namespace E_Commerce.Pages.Product_Details
{
    public class DetailsModel : PageModel
    {
        private readonly IProduct ProductService;
        [BindProperty]
        public List<Product> items { get; set; }
        [BindProperty]
        public Product Product { get; set; }
        [BindProperty]
        public List<Product> Products { get; set; }
        [BindProperty]
        public List<Product> CartProducts { get; set; }
        [BindProperty]
        public string CartCookie { get; set; }

        public DetailsModel(IProduct product)
        {
            ProductService = product;
        }

        public async Task OnGet(int id)
        {
            Product = await ProductService.GetProduct(id);
            Products = await ProductService.GetProducts();
            items = await ProductService.RandomProduct();

        }
        
        public async Task<IActionResult> OnPostAsync(int id)
        {
            CartCookie = HttpContext.Request.Cookies[$"{User.Identity.Name}'CartsList"];
            if(CartCookie != null)
            {
                CartProducts = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(CartCookie);
            }
            CartProducts.Add(await ProductService.GetProduct(id));
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = new System.DateTimeOffset(DateTime.Now.AddDays(7));
            CartCookie = JsonConvert.SerializeObject(CartProducts, Formatting.Indented);
            HttpContext.Response.Cookies.Append($"{User.Identity.Name}'CartsList", CartCookie, cookieOptions);
            return Redirect($"/ProductDetails/Details?id={id}");
        }
    }
}
