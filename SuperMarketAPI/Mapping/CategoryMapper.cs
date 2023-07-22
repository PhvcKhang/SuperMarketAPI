using AutoMapper;
using SuperMarketAPI.ViewModels;
using SuperMarketAPI.Domain.Models;

namespace SuperMarketAPI.Mapping
{
    public class CategoryMapper : Profile
    {
        public CategoryMapper()
        {
            CreateMap<Category,CategoryViewModel>();
        }
    }
}
