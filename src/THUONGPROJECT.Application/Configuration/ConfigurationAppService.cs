using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using THUONGPROJECT.Configuration.Dto;

namespace THUONGPROJECT.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : THUONGPROJECTAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
