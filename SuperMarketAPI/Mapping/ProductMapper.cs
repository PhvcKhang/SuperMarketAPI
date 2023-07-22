using AutoMapper;
using SuperMarketAPI.Domain.Models;

namespace SuperMarketAPI.Mapping
{
    public class ProductMapper:Profile
    {
        public ProductMapper()
        {
            CreateMap<Product, ProductViewModel>();
        }
    }
}
