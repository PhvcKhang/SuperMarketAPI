using SuperMarketAPI.Domain.Services;
using SuperMarketAPI.Domain.Repositories;
using SuperMarketAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace SuperMarketAPI.Infracstrure.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
        }
        public void CreateCategory(Category category)
        {
            _context.Categories.Add(category);
        }
        public IEnumerable<Category> ListAll()
        {
            return _context.Categories.Include(p => p.Products); 
        }
        public void DeleteCategory(int id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Id == id);
            _context.Categories.Remove(category);
        }
        public void UpdateCategory(int id, Category category)
        {
            var UpdatedCategory=_context.Categories.FirstOrDefault(c => c.Id==id);
            UpdatedCategory.Name = category.Name;
        }
    }

    }
