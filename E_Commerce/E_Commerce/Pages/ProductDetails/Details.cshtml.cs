using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Models;
using E_Commerce.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Commerce.Pages.Product_Details
{
    public class DetailsModel : PageModel
    {
        private readonly IProduct ProductService;

        [BindProperty]
        public Product product { get; set; }

        public DetailsModel(IProduct product)
        {
            ProductService = product;
        }

        public async Task OnGet(int id)
        {
            product = await ProductService.GetProduct(id);
        }
    }
}
