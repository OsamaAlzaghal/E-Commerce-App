using E_Commerce.Data;
using E_Commerce.Models;
using E_Commerce.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
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

        /// <summary>
        /// This method calls the page for the user's cart and get's the user's list of products in the cart.
        /// </summary>
        /// <returns> If the cart is empty, it redirects to an empty cart page. </returns>
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

        /// <summary>
        /// This method is responsible for deleting a product from the user's shopping cart. It gets the cart, then delete the specific product from the list of products.
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Redirect to the same page of products in the user's cart. </returns>
        public async Task OnPost(int id)
        {
            CartCookie = HttpContext.Request.Cookies[$"{User.Identity.Name}'CartsList"];
            if (CartCookie != null)
            {
                CartProducts = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(CartCookie);
            }

            Product deleted = CartProducts.Where(x => x.ID == id).Select(x => x).FirstOrDefault();
            CartProducts.Remove(deleted);
            // Set some settings for the cookie.
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = new System.DateTimeOffset(DateTime.Now.AddDays(7));
            CartCookie = JsonConvert.SerializeObject(CartProducts, Formatting.Indented);
            // Add the modified list to the cookie as a JSON string.
            HttpContext.Response.Cookies.Append($"{User.Identity.Name}'CartsList", CartCookie, cookieOptions);
            Redirect("/Cart/Cart");
        }
    }
}