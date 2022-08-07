using API._Repositories.Interfaces;

namespace API._Repositories
{
    public interface IRepositoryAccessor
    {

        IUserRepository User { get; }
        IProductCategoryRepository ProductCategory {get;}
        Task<bool> SaveChangesAsync();
    }
}