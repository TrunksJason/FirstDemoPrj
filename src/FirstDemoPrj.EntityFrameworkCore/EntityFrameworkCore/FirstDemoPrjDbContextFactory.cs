using FirstDemoPrj.Configuration;
using FirstDemoPrj.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace FirstDemoPrj.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class FirstDemoPrjDbContextFactory : IDesignTimeDbContextFactory<FirstDemoPrjDbContext>
    {
        public FirstDemoPrjDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<FirstDemoPrjDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(FirstDemoPrjConsts.ConnectionStringName)
            );

            return new FirstDemoPrjDbContext(builder.Options);
        }
    }
}