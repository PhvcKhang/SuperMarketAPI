using SuperMarketAPI.Application.DTOs;
using SuperMarketAPI.Domain.Models;
using SuperMarketAPI.Domain.Services;
using SuperMarketAPI.Domain.Repositories;

namespace SuperMarketAPI.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task CreateProductAsync(CreateProductDTO DTO)
        {
            var product = new Product(DTO.Name, DTO.QuantityInPackage, DTO.unitOfMeasurement, DTO.CategoryId);
            _productRepository.CreateProduct(product);
            await _productRepository.UnitOfWork.SaveChangesAsync();
        }

        public Product GetProduct(GetProductDTO DTO)
        {
             return _productRepository.GetProductById(DTO.CategoryId, DTO.ProductId);
        }
    }
}
