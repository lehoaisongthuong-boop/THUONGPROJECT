using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using THUONGPROJECT.Configuration;
using THUONGPROJECT.EntityFrameworkCore;
using THUONGPROJECT.Migrator.DependencyInjection;

namespace THUONGPROJECT.Migrator
{
    [DependsOn(typeof(THUONGPROJECTEntityFrameworkModule))]
    public class THUONGPROJECTMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public THUONGPROJECTMigratorModule(THUONGPROJECTEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(THUONGPROJECTMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                THUONGPROJECTConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(THUONGPROJECTMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
