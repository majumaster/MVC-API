using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example.Entities.Models;

namespace Example.DataAccessLayer.Repositories.Abstract
{
    public interface ICategoryRepository
    {
        Task<Category> GetCategoryAsync(int id);
        Task<List<Category>> GetCategoriesAsync();
        Task<bool> SaveCategoryAsync(Category category);
        Task<bool> DeleteCategoryAsync(Category category);
    }
}
