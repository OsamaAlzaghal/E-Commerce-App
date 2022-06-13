using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Auth.Model.DTO;
using E_Commerce.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Commerce.Pages.UserHome
{
    public class SignInModel : PageModel
    {
        private readonly IUser UserService;

        [BindProperty]
        public LoginDTO input { get; set; }
        public UserDTO user;

        public SignInModel(IUser user)
        {
            UserService = user;
        }

        public async Task OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {

            LoginDTO person = new LoginDTO()
            {
                UserName = input.UserName,
                Password = input.Password
            };
            user = await UserService.Authenticate(person.UserName, person.Password);
            if(user !=null)
            return RedirectToPage("/categories/categories");
            return RedirectToPage("/UserHome/SignIn");

        }
    }
}
