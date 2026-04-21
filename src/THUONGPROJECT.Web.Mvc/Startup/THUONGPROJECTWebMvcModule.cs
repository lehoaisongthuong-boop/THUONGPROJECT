using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using THUONGPROJECT.Configuration;

namespace THUONGPROJECT.Web.Startup
{
    [DependsOn(typeof(THUONGPROJECTWebCoreModule))]
    public class THUONGPROJECTWebMvcModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public THUONGPROJECTWebMvcModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<THUONGPROJECTNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(THUONGPROJECTWebMvcModule).GetAssembly());
        }
    }
}
