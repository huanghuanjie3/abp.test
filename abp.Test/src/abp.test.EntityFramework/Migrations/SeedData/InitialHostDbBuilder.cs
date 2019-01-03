using abp.test.EntityFramework;
using EntityFramework.DynamicFilters;

namespace abp.test.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly testDbContext _context;

        public InitialHostDbBuilder(testDbContext context)
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
