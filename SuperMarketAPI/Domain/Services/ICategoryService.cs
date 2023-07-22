using SuperMarketAPI.Application.DTOs;
using SuperMarketAPI.Domain.Models;

namespace SuperMarketAPI.Domain.Services
{
    public interface ICategoryService
    {
        Task CreateCategoryAsync(CreateCategoryDTO categoryDTO);
        IEnumerable<Category>ListAllCategories();
        Task DeleteCategoryAsync(int categoryId);
        Task UpdateCategoryAsync(int id, CreateCategoryDTO categoryDTO);
    }
}
