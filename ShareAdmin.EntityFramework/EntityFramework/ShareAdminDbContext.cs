using System.Data.Common;
using Abp.Zero.EntityFramework;
using ShareAdmin.Authorization.Roles;
using ShareAdmin.Authorization.Users;
using ShareAdmin.MultiTenancy;

namespace ShareAdmin.EntityFramework
{
    public class ShareAdminDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public ShareAdminDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in ShareAdminDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of ShareAdminDbContext since ABP automatically handles it.
         */
        public ShareAdminDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public ShareAdminDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public ShareAdminDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
