using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Controllers
{
    public class HomeController : Controller
    {
        //[AllowAnonymous]
        //[Authorize(Roles = "adminstrator")]
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Auth");
        }

        ////[Authorize(Roles = "user")]
        //public IActionResult IndexUser()
        //{
        //    return View();
        //}

        ////[Authorize(Roles = "editor")]
        //public IActionResult IndexEditor()
        //{
        //    return View();
        //}
    }
}