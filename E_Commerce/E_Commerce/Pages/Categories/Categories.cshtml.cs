using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Models;
using E_Commerce.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Commerce.Pages.Categories
{
    public class CategoriesModel : PageModel
    {
        private readonly ICategory CategoryService;
        [BindProperty]
        public List<Category> categories { get; set; }

        public CategoriesModel(ICategory service)
        {
            CategoryService = service;
        }

        public async Task OnGet()
        {
            categories = await CategoryService.GetCategories();
        }
    }
}
