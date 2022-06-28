using E_Commerce.Models;
using E_Commerce.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        /// <summary>
        /// This method gets the categories to view them in a page.
        /// </summary>
        /// <returns> None. </returns>
        public async Task OnGet()
        {
            categories = await CategoryService.GetCategories();
        }
    }
}
