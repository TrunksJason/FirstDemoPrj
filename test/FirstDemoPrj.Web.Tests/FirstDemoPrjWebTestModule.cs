using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FirstDemoPrj.Web.Startup;
namespace FirstDemoPrj.Web.Tests
{
    [DependsOn(
        typeof(FirstDemoPrjWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class FirstDemoPrjWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FirstDemoPrjWebTestModule).GetAssembly());
        }
    }
}