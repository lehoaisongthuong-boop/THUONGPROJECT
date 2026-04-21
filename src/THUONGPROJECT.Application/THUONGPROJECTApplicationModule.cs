using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using THUONGPROJECT.Authorization;

namespace THUONGPROJECT
{
    [DependsOn(
        typeof(THUONGPROJECTCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class THUONGPROJECTApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<THUONGPROJECTAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(THUONGPROJECTApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
