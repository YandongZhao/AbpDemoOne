using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AbpDemoOne.EntityFrameworkCore
{
    public static class AbpDemoOneDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AbpDemoOneDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AbpDemoOneDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
