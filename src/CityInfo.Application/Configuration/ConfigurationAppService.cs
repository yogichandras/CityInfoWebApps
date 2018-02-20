using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using CityInfo.Configuration.Dto;

namespace CityInfo.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CityInfoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
