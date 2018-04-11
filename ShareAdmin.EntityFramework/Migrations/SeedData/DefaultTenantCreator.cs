using System.Linq;
using ShareAdmin.EntityFramework;
using ShareAdmin.MultiTenancy;

namespace ShareAdmin.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly ShareAdminDbContext _context;

        public DefaultTenantCreator(ShareAdminDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
