using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Coders.MVC5.EntityFramework;

namespace Coders.MVC5.Migrator
{
    [DependsOn(typeof(MVC5DataModule))]
    public class MVC5MigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<MVC5DbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}