
using API.Dtos;

namespace API._Services.Interfaces
{
    public interface IProductCategoryService
    {
        Task<List<ProductCategoryDTO>> GetProductCategories();
    }
}