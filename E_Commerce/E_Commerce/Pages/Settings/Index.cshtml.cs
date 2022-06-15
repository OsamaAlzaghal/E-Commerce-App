using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace E_Commerce.Pages.Settings
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public List<Product> Products { get; set; }
        [BindProperty]
        public string Cart { get; set; }
        [BindProperty]
        public List<Product> CookieCart { get; set; }
        [BindProperty]
        public MiniCart miniCart { get; set; }

        public void OnGet()
        {
            var cookie = HttpContext.Request.Cookies["Cart"];
            if(cookie != null)
            {
                CookieCart = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(cookie);
            }
        }
        public async Task OnPost()
        {
            //Products.Add(new MiniCart { ID = });
            Cart = JsonConvert.SerializeObject(Products, Formatting.Indented);
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = new System.DateTimeOffset(DateTime.Now.AddDays(7));
            HttpContext.Response.Cookies.Append("Cart", Cart, cookieOptions);
        }

        public class MiniCart
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
        }
    }
}