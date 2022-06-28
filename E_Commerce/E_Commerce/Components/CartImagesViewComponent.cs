using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace E_Commerce.Components
{
    public class CartImagesViewComponent : ViewComponent
    {
        [BindProperty]
        public List<Product> CartProducts { get; set; }
        [BindProperty]
        public Cart ProductsCart { get; set; }
        public string CartCookie { get; set; }

        /// <summary>
        /// We created this ViewComponent to view the image of each product in the user's mini cart.
        /// </summary>
        /// <returns> It returns a list of images, else, empty list. </returns>
        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Get the user's cookie and check if it exists.
            CartCookie = HttpContext.Request.Cookies[$"{User.Identity.Name}'CartsList"];
            if (CartCookie != null)
            {
                // Get the list of products that we have in the cookie.
                CartProducts = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(CartCookie);
                // Check if the list is empty.
                if (CartProducts != null)
                {
                    return View(new Cart { Count = CartProducts.Count, Products = CartProducts });
                }
                else
                {
                    return View(new Cart { Count = 0, Products = new List<Product> { } });
                }
            }
            else
            {
                return View(new Cart { Count = 0, Products = new List<Product> { } });
            }
        }

        /// <summary>
        /// Our component that was passed to the view.
        /// </summary>
        public class Cart
        {
            public int Count { get; set; }
            public List<Product> Products { get; set; }
        }
    }
}
