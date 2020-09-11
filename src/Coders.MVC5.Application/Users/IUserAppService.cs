using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Coders.MVC5.Roles.Dto;
using Coders.MVC5.Users.Dto;

namespace Coders.MVC5.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}