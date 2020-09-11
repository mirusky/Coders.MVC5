using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Coders.MVC5.Configuration.Dto;

namespace Coders.MVC5.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MVC5AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
