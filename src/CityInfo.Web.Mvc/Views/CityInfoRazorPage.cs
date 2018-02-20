using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace CityInfo.Web.Views
{
    public abstract class CityInfoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected CityInfoRazorPage()
        {
            LocalizationSourceName = CityInfoConsts.LocalizationSourceName;
        }
    }
}
