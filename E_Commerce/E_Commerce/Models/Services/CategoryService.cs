using E_Commerce.Data;
using E_Commerce.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models.Services
{
    public class CategoryService : ICategory
    {
        private readonly E_CommerceDbContext _context;

        public CategoryService(E_CommerceDbContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> GetCategories()
        {
            return await _context.Categories.Select(x => x).ToListAsync();

        }
    }
}
