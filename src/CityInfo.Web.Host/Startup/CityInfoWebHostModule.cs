using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CityInfo.Configuration;

namespace CityInfo.Web.Host.Startup
{
    [DependsOn(
       typeof(CityInfoWebCoreModule))]
    public class CityInfoWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public CityInfoWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CityInfoWebHostModule).GetAssembly());
        }
    }
}
