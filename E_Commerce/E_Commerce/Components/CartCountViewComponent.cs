using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace E_Commerce.Components
{
    public class CartCountViewComponent : ViewComponent
    {
        // By convention.
        [BindProperty]
        public List<Product> Products { get; set; }
        [BindProperty]
        public Cart ProductsCart { get; set; }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (Products != null)
            {
                Products = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(HttpContext.Request.Cookies["Cart"]);
                ProductsCart.Count = Products.Count;
                ProductsCart.Products = Products;
                return View(ProductsCart);
            }
            else
            {
                return View(new Cart { Count = 0, Products = null });
            }
        }

        public class Cart
        {
            public int Count { get; set; }
            public List<Product> Products { get; set; }
        }
    }
}
