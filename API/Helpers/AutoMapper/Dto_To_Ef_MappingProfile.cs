using API.Models;
using API.Dtos;
using AutoMapper;

namespace API.AutoMapper.Helpers
{
    public class Dto_To_Ef_MappingProfile : Profile
    {
        public Dto_To_Ef_MappingProfile()
        {
            CreateMap<Cart, CartDTO>();
            CreateMap<ColorCategory, ColorCategoryDTO>();
            CreateMap<Product, ProductDTO>();
            CreateMap<ProductCategory, ProductCategoryDTO>();
            CreateMap<ProductSizeCategory, ProductSizeCategoryDTO>();
            CreateMap<ProductStatus, ProductStatusDTO>();
            CreateMap<Role, RoleDTO>();
            CreateMap<User, UserDTO>();
        }
    }
}