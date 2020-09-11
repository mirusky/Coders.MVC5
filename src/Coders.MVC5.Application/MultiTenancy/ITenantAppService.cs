using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Coders.MVC5.MultiTenancy.Dto;

namespace Coders.MVC5.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
