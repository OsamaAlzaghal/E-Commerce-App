using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Models;
using E_Commerce.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Commerce.Pages.Products
{
    public class ProductsModel : PageModel
    {
        private readonly IProduct ProductService;
        private readonly ICategory CategoryService;

        [BindProperty]
        public List<Product> products { get; set; }

        public ProductsModel(IProduct product, ICategory category)
        {
            ProductService = product;
            CategoryService = category;
        }

        public async Task OnGet(int id)
        {
            products = await CategoryService.GetProductsByCategoryID(id);
        }
    }
}
