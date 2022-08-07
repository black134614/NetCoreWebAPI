using API._Repositories.Interfaces;
using API._Repositories;
using API.Data;
using API._Repositories.Respositories;

namespace API._Repositories
{
    public class RepositoryAccessor : IRepositoryAccessor
    {
        private DBContext _context;
        public RepositoryAccessor(DBContext context)
        {
            _context = context;
            User = new UserRepository(_context);
            ProductCategory = new ProductCategoryRepository(_context);
        }

        public IUserRepository User { get; private set; }
        public IProductCategoryRepository ProductCategory {get; private set;}
        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}