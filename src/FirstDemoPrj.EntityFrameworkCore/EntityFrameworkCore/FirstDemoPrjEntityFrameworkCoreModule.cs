using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace FirstDemoPrj.EntityFrameworkCore
{
    [DependsOn(
        typeof(FirstDemoPrjCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class FirstDemoPrjEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FirstDemoPrjEntityFrameworkCoreModule).GetAssembly());
        }
    }
}