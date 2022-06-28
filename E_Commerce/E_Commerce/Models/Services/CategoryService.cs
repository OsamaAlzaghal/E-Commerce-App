using E_Commerce.Data;
using E_Commerce.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
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

        /// <summary>
        /// This method creates a new category and saves it into the database.
        /// </summary>
        /// <param name="category"></param>
        /// <returns> Returns the new created category. </returns>
        public async Task<Category> CreateCategory(Category category)
        {
            _context.Entry(category).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return category;
        }

        /// <summary>
        /// This method gets all the categories from the database.
        /// </summary>
        /// <returns> Returns a list of categories. </returns>
        public async Task<List<Category>> GetCategories()
        {
            return await _context.Categories.Select(x => x).ToListAsync();
        }

        /// <summary>
        /// This method gets a specific category from the database.
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Returns a specific category from the database. </returns>
        public async Task<Category> GetCategory(int id)
        {
            return await _context.Categories.Where(x => x.ID == id).Select(x => x).FirstOrDefaultAsync();
        }

        /// <summary>
        /// This method gets all the products in a specific category.
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Returns a list of the products in a specific category. </returns>
        public async Task<List<Product>> GetProductsByCategoryID(int id)
        {
            return await _context.Products.Where(x => x.CategoryID == id).Select(x => x).ToListAsync();
        }

        /// <summary>
        /// This method updates an existing category in the database.
        /// </summary>
        /// <param name="category"></param>
        /// <returns> Returns the updated category. </returns>
        public async Task<Category> UpdateCategory(Category category)
        {
            Category oldCategory = await _context.Categories.FindAsync(category.ID);
            oldCategory.Name = category.Name;
            oldCategory.Description = category.Description;

            _context.Entry(oldCategory).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return oldCategory;
        }

        /// <summary>
        /// This method deletes a category from the database.
        /// </summary>
        /// <param name="id"></param>
        /// <returns> None. </returns>
        public async Task DeleteCategory(int id)
        {
            Category category = await GetCategory(id);
            _context.Entry(category).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }
    }
}