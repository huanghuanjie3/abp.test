using System.Linq;
using abp.test.EntityFramework;
using abp.test.MultiTenancy;

namespace abp.test.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly testDbContext _context;

        public DefaultTenantCreator(testDbContext context)
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
