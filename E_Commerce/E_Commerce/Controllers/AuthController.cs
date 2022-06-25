using E_Commerce.Auth.Model.DTO;
using E_Commerce.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Controllers
{
    public class AuthController : Controller
    {
        private IUser userService;
        public AuthController(IUser userSer)
        {
            userService = userSer;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult<UserDTO>> Authenticate(LoginDTO login)
        {
            var user = await userService.Authenticate(login.UserName, login.Password);
            if (user == null)
            {
                return Redirect("/auth/index");
            }
            return RedirectToAction("List", "Category");
        }
        public IActionResult SignUp()
        {
            return View();
        }
        //[Authorize(Roles = "user")]
        [HttpPost]
        public async Task<ActionResult<UserDTO>> SignUp(RegisterDTO register)
        {
            var user = await userService.Register(register, this.ModelState);
            if (ModelState.IsValid)
            {
                return Redirect("/auth/index");
            }
            return View(user);
        }

        public IActionResult NotAuthorized()
        {
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await userService.Logout();
            return Redirect("/Categories/Categories");
        }

        public async Task<IActionResult> AdminLogout()
        {
            await userService.Logout();
            return Redirect("/Auth/Index");
        }
    }
}
