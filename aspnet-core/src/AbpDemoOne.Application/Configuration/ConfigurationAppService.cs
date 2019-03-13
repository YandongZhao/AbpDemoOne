using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AbpDemoOne.Configuration.Dto;

namespace AbpDemoOne.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AbpDemoOneAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
