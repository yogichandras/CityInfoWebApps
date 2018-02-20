using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CityInfo.Authorization;

namespace CityInfo
{
    [DependsOn(
        typeof(CityInfoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class CityInfoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<CityInfoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(CityInfoApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
