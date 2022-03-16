using Microsoft.EntityFrameworkCore;

namespace FirstDemoPrj.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<FirstDemoPrjDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for FirstDemoPrjDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
