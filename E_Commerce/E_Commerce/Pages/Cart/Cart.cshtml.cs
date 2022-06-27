using E_Commerce.Data;
using E_Commerce.Models;
using E_Commerce.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Pages.Cart
{
    [Authorize(Roles = "user")]
    public class CartModel : PageModel
    {
        private readonly IEmail MailService;
        private readonly E_CommerceDbContext _context;
        public CartModel(E_CommerceDbContext context, IEmail Email)
        {
            _context = context;
            MailService = Email;
        }

        [BindProperty]
        public string CartCookie { get; set; }
        [BindProperty]
        public List<Product> CartProducts { get; set; }

        public async Task OnGet()
        {
            CartCookie = HttpContext.Request.Cookies[$"{User.Identity.Name}'CartsList"];
            if (CartCookie != null)
            {
                CartProducts = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(CartCookie);
            }
            else
            {
                Redirect("/Cart/EmptyCart");
            }
        }

        //Delete
        public async Task OnPost(int id)
        {
            CartCookie = HttpContext.Request.Cookies[$"{User.Identity.Name}'CartsList"];
            if (CartCookie != null)
            {
                CartProducts = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(CartCookie);
            }

            Product deleted = CartProducts.Where(x => x.ID == id).Select(x => x).FirstOrDefault();
            CartProducts.Remove(deleted);

            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = new System.DateTimeOffset(DateTime.Now.AddDays(7));
            CartCookie = JsonConvert.SerializeObject(CartProducts, Formatting.Indented);
            HttpContext.Response.Cookies.Append($"{User.Identity.Name}'CartsList", CartCookie, cookieOptions);
            Redirect("/Cart/Cart");
        }
        
    }
}