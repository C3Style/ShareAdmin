using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using ShareAdmin.EntityFramework;

namespace ShareAdmin
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(ShareAdminCoreModule))]
    public class ShareAdminDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ShareAdminDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
