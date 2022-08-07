using API._Repositories;
using API._Services.Interfaces;
using API.Dtos;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace API._Services.Services
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly IRepositoryAccessor _repositoryAccessor;
        private readonly IMapper _mapper;
        public ProductCategoryService(IRepositoryAccessor repositoryAccessor, IMapper mapper)
        {
            _repositoryAccessor = repositoryAccessor;
            _mapper = mapper;
        }


        public async Task<List<ProductCategoryDTO>> GetProductCategories()
        {
           var data = await _repositoryAccessor.ProductCategory.FindAll()
                            .Select(x => new ProductCategoryDTO()
                            {
                                ProductCategoryId = x.ProductCategoryId,
                                Title = x.Title,
                                Status = x.Status,
                                CreateBy = x.CreateBy,
                                CreateTime = x.CreateTime,
                                Position = x.Position,
                                Image = x.Image
                            })
                            .OrderBy(x => x.Position)
                            .ToListAsync();
            return data;
        }
    }
}