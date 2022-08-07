using API.Dtos;
using API.Helpers.Params;

namespace API._Services.Interfaces
{
    public interface IAuthService
    {
        Task<UserDTO> login(LoginParam param);
    }
}