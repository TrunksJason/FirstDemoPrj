using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FirstDemoPrj.EntityFrameworkCore
{
    public class FirstDemoPrjDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...
        public DbSet<Taskss> Tasks { get; set; }
        public FirstDemoPrjDbContext(DbContextOptions<FirstDemoPrjDbContext> options) 
            : base(options)
        {

        }
    }
}
