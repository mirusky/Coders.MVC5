using System.Threading.Tasks;
using Abp.Application.Services;
using Coders.MVC5.Configuration.Dto;

namespace Coders.MVC5.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}