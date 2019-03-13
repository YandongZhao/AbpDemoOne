using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AbpDemoOne.Configuration;
using AbpDemoOne.Web;

namespace AbpDemoOne.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AbpDemoOneDbContextFactory : IDesignTimeDbContextFactory<AbpDemoOneDbContext>
    {
        public AbpDemoOneDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AbpDemoOneDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AbpDemoOneDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AbpDemoOneConsts.ConnectionStringName));

            return new AbpDemoOneDbContext(builder.Options);
        }
    }
}
