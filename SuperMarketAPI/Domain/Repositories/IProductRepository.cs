using Microsoft.AspNetCore.Mvc;
using SuperMarketAPI.Domain.Models;

namespace SuperMarketAPI.Domain.Repositories
{
    public interface IProductRepository : IRepository
    {
        void CreateProduct(Product product);
        Product GetProductById(int categoryId, int productId);
    }
}
