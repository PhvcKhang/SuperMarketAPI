using SuperMarketAPI.Domain.Models;

namespace SuperMarketAPI.Domain.Repositories
{
    public interface ICategoryRepository:IRepository
    {
        void CreateCategory(Category category);
        IEnumerable<Category> ListAll();
        void DeleteCategory(int id);
        void UpdateCategory(int id,Category category);
    }
}
