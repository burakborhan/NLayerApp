using AutoMapper;
using NLayer.Core.DTO_s;
using NLayer.Core.Models;

namespace NLayer.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<ProductFeature, ProductFeatureDTO>().ReverseMap();
            CreateMap<ProductUpdateDTO, Product>();
            CreateMap<Product, ProductWithCategoryDTO>().ReverseMap();
            CreateMap<Category, CategoryWithProductsDTO>();
        }
    }
}
