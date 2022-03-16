using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace FirstDemoPrj
{
    [DependsOn(
        typeof(FirstDemoPrjCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class FirstDemoPrjApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FirstDemoPrjApplicationModule).GetAssembly());
        }
    }
}