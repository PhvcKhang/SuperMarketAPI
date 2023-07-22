using SuperMarketAPI.Application.DTOs;
using SuperMarketAPI.Domain.Models;

namespace SuperMarketAPI.Domain.Services
{
    public interface IProductService
    {
        Task CreateProductAsync(CreateProductDTO DTO);
        Product GetProduct(GetProductDTO DTO);
    }
}
