using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ShareAdmin.Configuration.Dto;

namespace ShareAdmin.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ShareAdminAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
