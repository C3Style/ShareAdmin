using ShareAdmin.EntityFramework;
using EntityFramework.DynamicFilters;

namespace ShareAdmin.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly ShareAdminDbContext _context;

        public InitialHostDbBuilder(ShareAdminDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
