
using API._Repositories.Interfaces;
using API.Data;
using API.Models;

namespace API._Repositories.Respositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DBContext context) : base(context)
        {
            
        }
    }
}