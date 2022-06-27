using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Auth.Model.DTO;
using E_Commerce.Models;
using E_Commerce.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Commerce.Pages.UserHome
{
    public class UserHomeModel : PageModel
    {
        private readonly IUser UserService;
       
        [BindProperty]
        public RegisterDTO input { get; set; }

        public UserHomeModel(IUser user)
        {
            UserService = user;
        }

        public async Task OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            RegisterDTO person = new RegisterDTO()
            {
                UserName = input.UserName,
                Email = input.Email,
                Password = input.Password
            };
            //var user = await UserService.Register(person, this.ModelState);
            //CookieOptions cookieOptions = new CookieOptions();
            //cookieOptions.Expires = new System.DateTimeOffset(DateTime.Now.AddDays(7));

            //HttpContext.Response.Cookies.Append($"{User.Identity.Name}'CartsList", null, cookieOptions);

            return RedirectToPage("/UserHome/SignIn");
        }
    }
}
