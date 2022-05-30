using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Cart()
        {
            List<Cart> carts = new List<Cart>();
            carts.Add(new Cart { ID = 1, UserID = 1 });
            carts.Add(new Cart { ID = 2, UserID = 2 });
            carts.Add(new Cart { ID = 3, UserID = 3 });
            carts.Add(new Cart { ID = 4, UserID = 4 });
            return View(carts);
        }
    }
}
