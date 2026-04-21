using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using THUONGPROJECT.Configuration;

namespace THUONGPROJECT.Web.Host.Startup
{
    [DependsOn(
       typeof(THUONGPROJECTWebCoreModule))]
    public class THUONGPROJECTWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public THUONGPROJECTWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(THUONGPROJECTWebHostModule).GetAssembly());
        }
    }
}
