using Abp.AspNetCore.Mvc.ViewComponents;

namespace CityInfo.Web.Views
{
    public abstract class CityInfoViewComponent : AbpViewComponent
    {
        protected CityInfoViewComponent()
        {
            LocalizationSourceName = CityInfoConsts.LocalizationSourceName;
        }
    }
}
