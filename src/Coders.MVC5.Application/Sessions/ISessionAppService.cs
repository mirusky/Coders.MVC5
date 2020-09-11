using System.Threading.Tasks;
using Abp.Application.Services;
using Coders.MVC5.Sessions.Dto;

namespace Coders.MVC5.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
