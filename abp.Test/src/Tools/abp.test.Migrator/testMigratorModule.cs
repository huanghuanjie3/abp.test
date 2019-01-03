using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using abp.test.EntityFramework;

namespace abp.test.Migrator
{
    [DependsOn(typeof(testDataModule))]
    public class testMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<testDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}