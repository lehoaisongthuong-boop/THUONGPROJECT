using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using THUONGPROJECT.EntityFrameworkCore.Seed;

namespace THUONGPROJECT.EntityFrameworkCore
{
    [DependsOn(
        typeof(THUONGPROJECTCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class THUONGPROJECTEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<THUONGPROJECTDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        THUONGPROJECTDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        THUONGPROJECTDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(THUONGPROJECTEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
