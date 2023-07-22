using Microsoft.AspNetCore.Mvc;
using SuperMarketAPI.Domain.Models;
using SuperMarketAPI.Domain.Repositories;

namespace SuperMarketAPI.Infracstrure.Repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }
        public void CreateProduct(Product product)
        {
            _context.Products.Add(product);
        }

        public Product GetProductById(int categoryId, int productId)
        {
            return _context.Products.FirstOrDefault(p => p.CategoryId == categoryId && p.Id == productId);
        }
    }
}
