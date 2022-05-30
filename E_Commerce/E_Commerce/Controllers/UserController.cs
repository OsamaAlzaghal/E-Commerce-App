using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Controllers
{
    public class UserController : Controller
    {
        public IActionResult List()
        {
            List<User> Users = new List<User>();
            Users.Add(new User { ID = 1, Name = "Laith", Email = "123@LTUC.com", Password = "123", PhoneNumber = "079" });
            Users.Add(new User { ID = 2, Name = "Osama", Email = "456@LTUC.com", Password = "456", PhoneNumber = "078" });
            
            return View(Users);
        }
    }
}
