using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Components
{
    public class MiniCartTotalViewComponent : ViewComponent
    {
        [BindProperty]
        public List<Product> CartProducts { get; set; }
        [BindProperty]
        public Cart ProductsCart { get; set; }
        public string CartCookie { get; set; }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            CartCookie = HttpContext.Request.Cookies[$"{User.Identity.Name}'CartsList"];
            if (CartCookie != null)
            {
                CartProducts = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(CartCookie);
                return View(new Cart { Count = CartProducts.Count, Products = CartProducts });
            }
            else
            {
                return View(new Cart { Count = 0, Products = new List<Product> { } });
            }
        }

        public class Cart
        {
            public int Count { get; set; }
            public List<Product> Products { get; set; }
        }
    }
}
