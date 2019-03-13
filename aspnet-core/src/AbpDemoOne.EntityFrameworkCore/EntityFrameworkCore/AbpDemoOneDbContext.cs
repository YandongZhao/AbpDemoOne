using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AbpDemoOne.Authorization.Roles;
using AbpDemoOne.Authorization.Users;
using AbpDemoOne.MultiTenancy;

namespace AbpDemoOne.EntityFrameworkCore
{
    public class AbpDemoOneDbContext : AbpZeroDbContext<Tenant, Role, User, AbpDemoOneDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AbpDemoOneDbContext(DbContextOptions<AbpDemoOneDbContext> options)
            : base(options)
        {
        }
    }
}
