using API.Dtos;
using API.Models;
using AutoMapper;

namespace API.Helpers.AutoMapper
{
    public class Ef_To_Dto_MappingProfile : Profile
    {
        public Ef_To_Dto_MappingProfile()
        {
            CreateMap<CartDTO, Cart>();
            CreateMap<ColorCategoryDTO, ColorCategory>();
            CreateMap<ProductDTO, Product>();
            CreateMap<ProductCategoryDTO, ProductCategory>();
            CreateMap<ProductSizeCategoryDTO, ProductSizeCategory>();
            CreateMap<ProductStatusDTO, ProductStatus>();
            CreateMap<RoleDTO, Role>();
            CreateMap<UserDTO, User>();
        }
    }
}