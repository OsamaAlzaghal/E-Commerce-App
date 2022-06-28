using E_Commerce.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace E_Commerce.Controllers
{
    [Authorize(Roles = "administrator,editor")]
    public class UserController : Controller
    {
        /// <summary>
        /// Get the list of registered users.
        /// </summary>
        /// <returns> Return a view to show the users' info. </returns>
        public IActionResult List()
        {
            List<ApplicationUser> Users = new List<ApplicationUser>();
            return View(Users);
        }
    }
}
