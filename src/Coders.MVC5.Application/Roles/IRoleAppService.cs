using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Coders.MVC5.Roles.Dto;

namespace Coders.MVC5.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
