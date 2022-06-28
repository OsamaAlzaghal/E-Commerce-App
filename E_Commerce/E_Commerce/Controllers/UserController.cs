using E_Commerce.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Controllers
{
    [Authorize(Roles = "administrator,editor")]
    public class UserController : Controller
    {
        public IActionResult List()
        {
            List<ApplicationUser> Users = new List<ApplicationUser>();
            return View(Users);
        }
    }
}
