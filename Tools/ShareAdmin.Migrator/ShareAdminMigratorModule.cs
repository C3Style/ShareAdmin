using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using ShareAdmin.EntityFramework;

namespace ShareAdmin.Migrator
{
    [DependsOn(typeof(ShareAdminDataModule))]
    public class ShareAdminMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<ShareAdminDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}