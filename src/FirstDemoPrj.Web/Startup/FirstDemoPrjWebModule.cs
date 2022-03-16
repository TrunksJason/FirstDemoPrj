using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FirstDemoPrj.Configuration;
using FirstDemoPrj.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;

namespace FirstDemoPrj.Web.Startup
{
    [DependsOn(
        typeof(FirstDemoPrjApplicationModule), 
        typeof(FirstDemoPrjEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class FirstDemoPrjWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public FirstDemoPrjWebModule(IWebHostEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(FirstDemoPrjConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<FirstDemoPrjNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(FirstDemoPrjApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FirstDemoPrjWebModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(FirstDemoPrjWebModule).Assembly);
        }
    }
}
