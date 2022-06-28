using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{

    public class HomeController : Controller
    {
        /// <summary>
        /// Main page for the Admins to sign in.
        /// </summary>
        /// <returns> Returns the sign in page for the Admins. </returns>
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Auth");
        }
    }
}