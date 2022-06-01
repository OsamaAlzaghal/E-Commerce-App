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

        public async Task<Category> CreateCategory(Category category)
        {
            _context.Entry(category).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<List<Category>> GetCategories()
        {
            return await _context.Categories.Select(x => x).ToListAsync();
        }

        public async Task<Category> GetCategory(int id)
        {
            return await _context.Categories.Where(x => x.ID == id).Select(x => x).FirstOrDefaultAsync();
        }

        public async Task<Category> UpdateCategory(Category category)
        {
            Category oldCategory = await _context.Categories.FindAsync(category.ID);
            oldCategory.Name = category.Name;
            oldCategory.Description = category.Description;

            _context.Entry(oldCategory).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return oldCategory;
        }

        public async Task DeleteCategory(int id)
        {
            Category category = await GetCategory(id);
            //_context.Categories.Remove(category);
            _context.Entry(category).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }
    }
}