using System.Collections.Generic;
using System.Threading.Tasks;

namespace E_Commerce.Models.Interfaces
{
    public interface ICategory
    {
        public Task<List<Category>> GetCategories();
        public Task<Category> GetCategory(int id);
        public Task<Category> CreateCategory(Category category);
        public Task<Category> UpdateCategory(Category category);
        public Task DeleteCategory(int id);
        public Task<List<Product>> GetProductsByCategoryID(int id);
    }
}