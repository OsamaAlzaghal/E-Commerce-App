using E_Commerce.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace E_Commerce.Pages.Cart
{
    [Authorize(Roles = "user")]
    public class CartModel : PageModel
    {
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
        }
    }
}
