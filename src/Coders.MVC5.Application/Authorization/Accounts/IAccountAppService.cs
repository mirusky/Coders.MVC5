using System.Threading.Tasks;
using Abp.Application.Services;
using Coders.MVC5.Authorization.Accounts.Dto;

namespace Coders.MVC5.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
