﻿using E_Commerce.Auth.Model.DTO;
using E_Commerce.Models.Interfaces;
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
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult<UserDTO>> SignUp(RegisterDTO register)
        {
            var user = await userService.Register(register, this.ModelState);
            if (ModelState.IsValid)
            {
                return Redirect("/");
            }
            return View();
        }

        public async Task<ActionResult<UserDTO>> Authenticate(LoginDTO login)
        {
            var user = await userService.Authenticate(login.UserName, login.Password);
            if (user == null)
            {
                return RedirectToAction("Index");
            }
            return Redirect("/");
        }

        //[HttpGet("me")]
        //[Authorize(Policy = "create")]
        //public async Task<ActionResult<UserDto>> Me()
        //{
        //    // Following the [Authorize] phase, this.User will be ... you.
        //    // Put a breakpoint here and inspect to see what's passed to our getUser method
        //    return await _userService.GetUser(this.User);
        //}

    }
}
