using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Data;
using E_Commerce.Models;
using E_Commerce.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace E_Commerce.Pages.Cart
{
    public class RecieptModel : PageModel
    {
        private readonly IEmail MailService;
        private readonly E_CommerceDbContext _context;
        public RecieptModel(E_CommerceDbContext context, IEmail Email)
        {
            _context = context;
            MailService = Email;
        }
        [BindProperty]
        public string CartCookie { get; set; }
        [BindProperty]
        public List<Product> CartProducts { get; set; }
        public double total { get; set; }
        public async Task OnGet()
        {
            CartCookie = HttpContext.Request.Cookies[$"{User.Identity.Name}'CartsList"];
            if (CartCookie != null)
            {
                CartProducts = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(CartCookie);
            
            }
        }
        public async Task<IActionResult> OnPost()
        {
            string email = await _context.Users.Where(x => x.UserName == User.Identity.Name).Select(x => x.Email).FirstOrDefaultAsync();
            CartCookie = HttpContext.Request.Cookies[$"{User.Identity.Name}'CartsList"];
            if (CartCookie != null)
            {
                CartProducts = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(CartCookie);
                HttpContext.Response.Cookies.Append($"{User.Identity.Name}'CartsList", JsonConvert.SerializeObject(new List<Product> { }, Formatting.Indented));
            }
            await MailService.SendMail(email, CartProducts);
            return Redirect("/Cart/CheckOut");
        }
    }
}
