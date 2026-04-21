using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using THUONGPROJECT.EntityFrameworkCore;
using THUONGPROJECT.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace THUONGPROJECT.Web.Tests
{
    [DependsOn(
        typeof(THUONGPROJECTWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class THUONGPROJECTWebTestModule : AbpModule
    {
        public THUONGPROJECTWebTestModule(THUONGPROJECTEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(THUONGPROJECTWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(THUONGPROJECTWebMvcModule).Assembly);
        }
    }
}