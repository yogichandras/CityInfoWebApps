using System.Threading.Tasks;
using CityInfo.Configuration.Dto;

namespace CityInfo.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
