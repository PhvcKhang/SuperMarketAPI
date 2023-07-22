using SuperMarketAPI.Application.DTOs;
using SuperMarketAPI.Domain.Services;
using SuperMarketAPI.Domain.Models;
using SuperMarketAPI.Domain.Repositories;

namespace SuperMarketAPI.Application.Services
{
    public class CategoryService:ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task CreateCategoryAsync(CreateCategoryDTO createCategoryDTO)
        {
            var category = new Category(createCategoryDTO.Name);
            _categoryRepository.CreateCategory(category);
            await _categoryRepository.UnitOfWork.SaveChangesAsync();
        }
        public IEnumerable<Category> ListAllCategories()
        {
            return _categoryRepository.ListAll();
        }
        public async Task DeleteCategoryAsync(int id)
        {
            _categoryRepository.DeleteCategory(id);
            await _categoryRepository.UnitOfWork.SaveChangesAsync();
        }
        public async Task UpdateCategoryAsync (int id, CreateCategoryDTO createCategoryDTO)
        {
            var category = new Category(createCategoryDTO.Name);
            _categoryRepository.UpdateCategory(id,category);
            await _categoryRepository.UnitOfWork.SaveChangesAsync();
        }
     }
}

